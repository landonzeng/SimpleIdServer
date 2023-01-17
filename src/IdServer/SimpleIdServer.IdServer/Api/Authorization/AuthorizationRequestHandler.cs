﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SimpleIdServer.IdServer.Api.Authorization.ResponseTypes;
using SimpleIdServer.IdServer.Api.Authorization.Validators;
using SimpleIdServer.IdServer.Api.Token.TokenProfiles;
using SimpleIdServer.IdServer.Domains;
using SimpleIdServer.IdServer.DTOs;
using SimpleIdServer.IdServer.Exceptions;
using SimpleIdServer.IdServer.Helpers;
using SimpleIdServer.IdServer.Options;
using SimpleIdServer.IdServer.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.IdServer.Api.Authorization
{
    public interface IAuthorizationRequestHandler
    {
        Task<AuthorizationResponse> Handle(HandlerContext context, CancellationToken token);
    }

    public class AuthorizationRequestHandler : IAuthorizationRequestHandler
    {
        private readonly IEnumerable<IResponseTypeHandler> _responseTypeHandlers;
        private readonly IEnumerable<IAuthorizationRequestValidator> _authorizationRequestValidators;
        private readonly IEnumerable<ITokenProfile> _tokenProfiles;
        private readonly IAuthorizationRequestEnricher _authorizationRequestEnricher;
        private readonly IClientRepository _clientRepository;
        private readonly IUserRepository _userRepository;
        private readonly IAudienceHelper _audienceHelper;
        private readonly IdServerHostOptions _options;

        public AuthorizationRequestHandler(IEnumerable<IResponseTypeHandler> responseTypeHandlers,
            IEnumerable<IAuthorizationRequestValidator> authorizationRequestValidators,
            IEnumerable<ITokenProfile> tokenProfiles, 
            IAuthorizationRequestEnricher authorizationRequestEnricher,
            IClientRepository clientRepository,
            IUserRepository userRepository,
            IAudienceHelper audienceHelper,
            IOptions<IdServerHostOptions> options)
        {
            _responseTypeHandlers = responseTypeHandlers;
            _authorizationRequestValidators = authorizationRequestValidators;
            _tokenProfiles = tokenProfiles;
            _authorizationRequestEnricher = authorizationRequestEnricher;
            _clientRepository = clientRepository;
            _userRepository = userRepository;
            _audienceHelper = audienceHelper;
            _options = options.Value;
        }

        public virtual async Task<AuthorizationResponse> Handle(HandlerContext context, CancellationToken token)
        {
            try
            {
                var result = await BuildResponse(context, token);
                var display = context.Request.RequestData.GetDisplayFromAuthorizationRequest();
                if (!string.IsNullOrWhiteSpace(display))
                    context.Response.Add(AuthorizationRequestParameters.Display, display);
                var sessionState = BuildSessionState(context);
                if (!string.IsNullOrWhiteSpace(sessionState))
                    context.Response.Add(AuthorizationRequestParameters.SessionState, sessionState);
                return result;
            }
            catch (OAuthUserConsentRequiredException ex)
            {
                context.Request.RequestData.Remove(AuthorizationRequestParameters.Prompt);
                return new RedirectActionAuthorizationResponse(ex.ActionName, ex.ControllerName, context.Request.OriginalRequestData);
            }
            catch (OAuthLoginRequiredException ex)
            {
                context.Request.RequestData.Remove(AuthorizationRequestParameters.Prompt);
                return new RedirectActionAuthorizationResponse("Index", "Authenticate", context.Request.OriginalRequestData, ex.Area, true, new List<string> { _options.SessionCookieName });
            }
            catch (OAuthSelectAccountRequiredException)
            {
                context.Request.RequestData.Remove(AuthorizationRequestParameters.Prompt);
                return new RedirectActionAuthorizationResponse("Index", "Accounts", context.Request.OriginalRequestData);
            }
        }

        protected async Task<AuthorizationResponse> BuildResponse(HandlerContext context, CancellationToken cancellationToken)
        {
            var requestedResponseTypes = context.Request.RequestData.GetResponseTypesFromAuthorizationRequest();
            if (!requestedResponseTypes.Any())
                throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.MISSING_PARAMETER, AuthorizationRequestParameters.ResponseType));

            var responseTypeHandlers = _responseTypeHandlers.Where(r => requestedResponseTypes.Contains(r.ResponseType));
            var unsupportedResponseType = requestedResponseTypes.Where(r => !_responseTypeHandlers.Any(rh => rh.ResponseType == r));
            if (unsupportedResponseType.Any())
                throw new OAuthException(ErrorCodes.UNSUPPORTED_RESPONSE_TYPE, string.Format(ErrorMessages.MISSING_RESPONSE_TYPES, string.Join(" ", unsupportedResponseType)));

            context.SetClient(await AuthenticateClient(context.Request.RequestData, cancellationToken));
            var user = await _userRepository.Query()
                .Include(u => u.Consents)
                .Include(u => u.Sessions)
                .Include(u => u.OAuthUserClaims)
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Id == context.Request.UserSubject, cancellationToken);
            context.SetUser(user);
            foreach (var validator in _authorizationRequestValidators)
            {
                await validator.Validate(context, cancellationToken);
            }

            var state = context.Request.RequestData.GetStateFromAuthorizationRequest();
            var redirectUri = context.Request.RequestData.GetRedirectUriFromAuthorizationRequest();
            if (!string.IsNullOrWhiteSpace(state))
            {
                context.Response.Add(AuthorizationResponseParameters.State, state);
            }

            _authorizationRequestEnricher.Enrich(context);
            if (!context.Client.RedirectionUrls.Contains(redirectUri))
            {
                redirectUri = context.Client.RedirectionUrls.First();
            }

            var scopes = context.Request.RequestData.GetScopesFromAuthorizationRequest();
            var resources = context.Request.RequestData.GetResourcesFromAuthorizationRequest();
            var extractionResult = await _audienceHelper.Extract(context.Client.ClientId, scopes, resources, cancellationToken);
            foreach (var responseTypeHandler in responseTypeHandlers)
            {
                await responseTypeHandler.Enrich(extractionResult.Scopes, extractionResult.Audiences, context.Request.RequestData.GetClaimsFromAuthorizationRequest(), context, cancellationToken);
            }

            _tokenProfiles.First(t => t.Profile == (context.Client.PreferredTokenProfile ?? _options.DefaultTokenProfile)).Enrich(context);
            return new RedirectURLAuthorizationResponse(redirectUri, context.Response.Parameters);
        }

        private async Task<Client> AuthenticateClient(JsonObject jObj, CancellationToken cancellationToken)
        {
            var clientId = jObj.GetClientIdFromAuthorizationRequest();
            if (string.IsNullOrWhiteSpace(clientId))
            {
                throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.MISSING_PARAMETER, AuthorizationRequestParameters.ClientId));
            }

            var client = await _clientRepository.Query().Include(c => c.Scopes).ThenInclude(s => s.Claims)
                .Include(c => c.SerializedJsonWebKeys)
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.ClientId == clientId, cancellationToken);
            if (client == null)
            {
                throw new OAuthException(ErrorCodes.INVALID_CLIENT, string.Format(ErrorMessages.UNKNOWN_CLIENT, clientId));
            }

            return client;
        }

        private string BuildSessionState(HandlerContext handlerContext)
        {
            var session = handlerContext.User.ActiveSession;
            if (session == null)
                return null;

            var redirectUrl = handlerContext.Request.RequestData.GetRedirectUriFromAuthorizationRequest();
            var clientId = handlerContext.Client.ClientId;
            var salt = Guid.NewGuid().ToString();
            return BuildSessionState(redirectUrl, clientId, salt, session.SessionId);
        }

        public static string BuildSessionState(string redirectUrl, string clientId, string salt, string sessionId)
        {
            var uri = new Uri(redirectUrl);
            var origin = uri.Scheme + "://" + uri.Host;
            if (!uri.IsDefaultPort)
            {
                origin += ":" + uri.Port;
            }

            var payload = Encoding.UTF8.GetBytes($"{clientId}{origin}{sessionId}{salt}");
            byte[] hash;
            using (var sha = SHA256.Create())
                hash = sha.ComputeHash(payload);

            return hash.Base64EncodeBytes() + "." + salt;
        }
    }
}
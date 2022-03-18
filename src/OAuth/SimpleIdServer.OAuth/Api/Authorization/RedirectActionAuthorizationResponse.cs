﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace SimpleIdServer.OAuth.Api.Authorization
{
    public class RedirectActionAuthorizationResponse : AuthorizationResponse
    {
        public RedirectActionAuthorizationResponse(string action, string controllerName, JObject queryParameters) : base(AuthorizationResponseTypes.RedirectAction)
        {
            Action = action;
            ControllerName = controllerName;
            QueryParameters = queryParameters;
        }

        public RedirectActionAuthorizationResponse(string action, string controllerName, JObject queryParameters, string area, bool disconnect = false, List<string> cookiesToRemove = null) : this(action, controllerName, queryParameters)
        {
            Area = area;
            Disconnect = disconnect;
            CookiesToRemove = cookiesToRemove;
        }

        public string Action { get; private set; }
        public string ControllerName { get; private set; }
        public JObject QueryParameters { get; private set; }
        public string Area { get; private set; }
        public bool Disconnect { get; private set; }
        public List<string> CookiesToRemove { get; private set; }
    }
}

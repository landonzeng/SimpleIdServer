﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.Did.Builders;
using SimpleIdServer.Did.Crypto;
using SimpleIdServer.Did.Crypto.Multicodec;
using SimpleIdServer.Did.Models;

namespace SimpleIdServer.Did.Formatters;

/// <summary>
/// https://w3c.github.io/vc-data-integrity/#key-agreement
/// </summary>
public class X25519KeyAgreementFormatter : IVerificationMethodFormatter
{
    public const string JSON_LD_CONTEXT = "https://w3id.org/security/suites/x25519-2019/v1";
    private readonly IMulticodecSerializer _serializer;

    public X25519KeyAgreementFormatter(IMulticodecSerializer serializer)
    {
        _serializer = serializer;
    }

    public string JSONLDContext => JSON_LD_CONTEXT;

    public string Type => "X25519KeyAgreementKey2019";

    public IAsymmetricKey Extract(DidDocumentVerificationMethod didDocumentVerificationMethod)
        => _serializer.Deserialize(didDocumentVerificationMethod.PublicKeyMultibase);

    public DidDocumentVerificationMethod Format(DidDocument idDocument, IAsymmetricKey signatureKey)
    {
        var publicKey = _serializer.Serialize(signatureKey);
        return new DidDocumentVerificationMethod
        {
            Id = $"{idDocument.Id}#{publicKey}",
            PublicKeyMultibase = publicKey
        };
    }
}
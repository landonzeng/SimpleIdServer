﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SimpleIdServer.Did.Jwt.Crypto
{
    public class ES256KSignatureKey : ISignatureKey
    {
        private ECPublicKeyParameters _publicKeyParameters;
        private readonly ECPrivateKeyParameters _privateKeyParameters;
        private readonly ECDomainParameters _domainParameters;
        private readonly X9ECParameters _secp256k1;

        public ES256KSignatureKey(byte[] publicKey)
        {
            _secp256k1 = SecNamedCurves.GetByName("secp256k1");
            _domainParameters = new ECDomainParameters(_secp256k1.Curve, _secp256k1.G, _secp256k1.N, _secp256k1.H);
            if(publicKey != null)
            {
                var q = _secp256k1.Curve.DecodePoint(publicKey);
                _publicKeyParameters = new ECPublicKeyParameters("EC", q, _domainParameters);
            }
        }

        public ES256KSignatureKey(byte[] publicKey, byte[] privateKey) : this(publicKey)
        {
            _privateKeyParameters = new ECPrivateKeyParameters(new Org.BouncyCastle.Math.BigInteger(1, privateKey), _domainParameters);
        }

        public ECPublicKeyParameters PublicKey
        {
            get
            {
                if(_publicKeyParameters == null)
                {
                    var q = _secp256k1.G.Multiply(_privateKeyParameters.D);
                    _publicKeyParameters = new ECPublicKeyParameters("EC", q, _domainParameters);
                }

                return _publicKeyParameters;
            }
        }

        public bool Check(string content, string signature)
        {
            var sig = ExtractSignature(signature);
            var signer = new ECDsaSigner();
            var hash = Hash(content);
            signer.Init(false, PublicKey);
            return signer.VerifySignature(hash, sig.R, sig.S);
        }

        public string Sign(string content)
        {
            if (_privateKeyParameters == null) throw new InvalidOperationException("There is no private key");
            var hash = Hash(content);
            var signer = new DeterministicECDSA();
            signer.SetPrivateKey(_privateKeyParameters);
            var sig = ECDSASignature.FromDER(signer.SignHash(hash));
            var lst = new List<byte>();
            lst.AddRange(sig.R.ToByteArrayUnsigned());
            lst.AddRange(sig.S.ToByteArrayUnsigned());
            return Base64UrlEncoder.Encode(lst.ToArray());
        }

        private static byte[] Hash(string content)
        {
            byte[] result = null;
            var payload = Encoding.UTF8.GetBytes(content);
            using (var sha256 = SHA256.Create())
                result = sha256.ComputeHash(payload);

            return result;
        }

        private static ECDSASignature ExtractSignature(string signature)
        {
            var payload = Base64UrlEncoder.DecodeBytes(signature);
            byte? v = null;
            if(payload.Length > 64)
            {
                v = payload[64];
                if (v == 0 || v == 1)
                    v = (byte)(v + 27);
            }

            var r = new byte[32];
            Array.Copy(payload, r, 32);
            var s = new byte[32];
            Array.Copy(payload, 32, s, 0, 32);
            var result = new ECDSASignature(new BigInteger(1, r), new BigInteger(1, s));
            if (v != null) result.V = new byte[] { v.Value };
            return result;
        }
    }
}

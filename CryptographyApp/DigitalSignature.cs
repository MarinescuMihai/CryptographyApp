﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CryptographyApp
{
    public class DigitalSignature
    {
        private RSAParameters _publicKey;
        private RSAParameters _privateKey;

        public void AssignNewKey()
        {
            using var rsa = new RSACryptoServiceProvider(2048);
            _publicKey = rsa.ExportParameters(false);
            _privateKey = rsa.ExportParameters(true);
        }

        public byte[] SignData(byte[] hashOfDataToSign)
        {
            using var rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(_privateKey);

            var rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
            rsaFormatter.SetHashAlgorithm("SHA256");

            return rsaFormatter.CreateSignature(hashOfDataToSign);
        }

        public bool VerifySignature(byte[] hashOfDataToSign, byte[] signature)
        {
            using var rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(_publicKey);

            var rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
            rsaDeformatter.SetHashAlgorithm("SHA256");

            return rsaDeformatter.VerifySignature(hashOfDataToSign, signature);
        }
    }
}

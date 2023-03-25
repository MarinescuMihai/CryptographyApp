using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CryptographyApp
{
    public static class HybridEncryption
    {
        public static EncryptedPacket EncryptData(byte[] original, RsaEncryption rsaParams,
            DigitalSignature digitalSignature)
        {
            var sessionKey = KeyGenerator.GenerateRandomNumber(32);

            var encryptedPacket = new EncryptedPacket { Iv = KeyGenerator.GenerateRandomNumber(16) };

            encryptedPacket.EncryptedData = AesEncryption.Encrypt(original, sessionKey, encryptedPacket.Iv);

            encryptedPacket.EncryptedSessionKey = rsaParams.EncryptData(sessionKey);

            using var hmac = new HMACSHA256(sessionKey);
            encryptedPacket.Hmac = hmac.ComputeHash(Combine(encryptedPacket.EncryptedData, encryptedPacket.Iv));

            encryptedPacket.Signature = digitalSignature.SignData(encryptedPacket.Hmac);

            return encryptedPacket;
        }

        public static string DecryptData(EncryptedPacket encryptedPacket, RsaEncryption rsaParams,
            DigitalSignature digitalSignature)
        {
            var decryptedSessionKey = rsaParams.DecryptData(encryptedPacket.EncryptedSessionKey);

            using var hmac = new HMACSHA256(decryptedSessionKey);
            var hmacToCheck = hmac.ComputeHash(Combine(encryptedPacket.EncryptedData, encryptedPacket.Iv));

            if (!Compare(encryptedPacket.Hmac, hmacToCheck))
            {
                throw new CryptographicException("HMAC for decryption does not match encrypted packet.");
            }

            if (!digitalSignature.VerifySignature(encryptedPacket.Hmac, encryptedPacket.Signature))
            {
                throw new CryptographicException("Digital Signature can not be verified.");
            }

            var decryptedData = AesEncryption.Decrypt(encryptedPacket.EncryptedData, decryptedSessionKey,
                encryptedPacket.Iv);

            return decryptedData;
        }

        private static byte[] Combine(byte[] first, byte[] second)
        {
            var ret = new byte[first.Length + second.Length];

            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);

            return ret;
        }

        private static bool Compare(byte[] array1, byte[] array2)
        {
            var result = array1.Length == array2.Length;

            for (var i = 0; i < array1.Length && i < array2.Length; ++i)
            {
                result &= array1[i] == array2[i];
            }

            return result;
        }
    }
}

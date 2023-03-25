using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptographyApp
{
    public static class AesEncryption
    {
        public static byte[] Encrypt(byte[] dataToEncrypt, byte[] key, byte[] iv)
        {
            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                aes.Key = key;
                aes.IV = iv;

                using (var memoryStream = new MemoryStream())
                {
                    var cryptoSteam = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);

                    cryptoSteam.Write(dataToEncrypt, 0, dataToEncrypt.Length);
                    cryptoSteam.FlushFinalBlock();

                    return memoryStream.ToArray();
                }
            }
        }

        public static string Decrypt(byte[] dataToDecrypt, byte[] key, byte[] iv)
        {
            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                aes.Key = key;
                aes.IV = iv;

                using (var memoryStream = new MemoryStream())
                {
                    var cryptoSteam = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);

                    cryptoSteam.Write(dataToDecrypt, 0, dataToDecrypt.Length);
                    cryptoSteam.FlushFinalBlock();

                    return Encoding.UTF8.GetString(memoryStream.ToArray());
                }
            }
        }
    }
}

using System.Security.Cryptography;

namespace CryptographyApp
{
    public static class KeyGenerator
    {
        public static byte[] GenerateRandomNumber(int lenght)
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[lenght];
                randomNumberGenerator.GetBytes(randomNumber);

                return randomNumber;
            }
        }
    }
}

using System;
using System.Security.Cryptography;
using System.Text;

namespace TinyUrlService.Utilities
{
    public class GeneratorAlgo
    {
        private const string Characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // For Base 62 encoded conversion. Can extend as well.
        private const int ShortUrlLength = 8;

        public static string Generate(string url)
        {
            long hash = BitConverter.ToInt64(GetHash(url), 0);
             
            return ConvertToBaseXX(hash);
        }

        private static int Base()
        {
            return Characters.Length;
        }

        private static byte[] GetHash(string input)
        {
            // Compute the MD5 hash of the original URL
            using (MD5 md5 = MD5.Create())
            {
                return md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }

        private static string ConvertToBaseXX(long num)
        {
            // Convert the MD5 hash value to the Base 62 encoded string in this case 
            string shortUrl = "";
            int BASE = Base();

            if (num < 0)
            {
                num = Math.Abs(num);
            }

            while (num > 0)
            {
                int idx = (int)(num % BASE);
                shortUrl += Characters[idx];
                num /= BASE;
            }

            while (shortUrl.Length < ShortUrlLength)
            {
                shortUrl = Characters[0] + shortUrl;
            }

            return shortUrl.Substring(0,ShortUrlLength);
        }
    }
}

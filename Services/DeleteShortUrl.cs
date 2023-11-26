using System;
using TinyUrlService.Entities;

namespace TinyUrlService.Services
{
    public class DeleteShortUrl
    {
        public static void Delete()
        {
            Console.WriteLine("Please Enter short URL to delete. Enter full url incuding domain.:");
            string shortUrl = Console.ReadLine().Trim();

            if (String.IsNullOrEmpty(shortUrl))
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine("Invalid. Short URL not provided.");
                Console.WriteLine("*************************************************");
                return;
            }

            string shortUrlKey;
            try
            {
                shortUrlKey = shortUrl.Split('/')[1];
            }
            catch (Exception ex)
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine("Incorrect Short URl");
                Console.WriteLine("*************************************************");
                return;
            }

            if (UrlStorage.UrlMappings.ContainsKey(shortUrlKey))
            {
                UrlStorage.UrlMappings.Remove(shortUrlKey);
                Console.WriteLine("*************************************************");
                Console.WriteLine($"Short URL {shortUrl} Deleted.");
                Console.WriteLine("*************************************************");
            }
            else
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine($"Provided Short URL {shortUrl} not found.");
                Console.WriteLine("*************************************************");
            }
        }
    }
}

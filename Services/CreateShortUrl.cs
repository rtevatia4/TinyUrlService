using System;
using TinyUrlService.Entities;
using TinyUrlService.Utilities;

namespace TinyUrlService.Services
{
    public class CreateShortUrl
    {
        public static void Create()
        {
            Console.WriteLine("Enter long URl:");
            string longUrl = Console.ReadLine().Trim();

            if (String.IsNullOrEmpty(longUrl))
            {
                Console.WriteLine("Invalid. Long URL not provided.");
                return;
            }
            

            Console.WriteLine("Do you want to enter a custom short URL? (y/n): ");
            string choice = Console.ReadLine().ToLower();

            if (String.IsNullOrEmpty(choice) || (choice != "y" && choice != "n"))
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            string shortUrl;

            if (choice == "y")
            {
                Console.WriteLine("To create custom Short URL. Only Provide Alphanumeric characters.:");
                shortUrl = Console.ReadLine().Trim();

                if (String.IsNullOrEmpty(shortUrl))
                {
                    Console.WriteLine("*************************************************");
                    Console.WriteLine("Invalid. Short URL not provided.");
                    Console.WriteLine("*************************************************");
                    return;
                }

                if (UrlStorage.UrlMappings.ContainsKey(shortUrl))
                {
                    Console.WriteLine("*************************************************");
                    Console.WriteLine($"Custom short URL {Constants.ShortUrlPrefix + shortUrl} is already in use. Try Again.");
                    Console.WriteLine("*************************************************");
                    return;
                }
            }
            else
            {
                shortUrl = GenerateShortUrl(longUrl);
            }

            UrlStorage.UrlMappings[shortUrl] = new UrlDetails { LongUrl = longUrl, ClickCount = 0};
            Console.WriteLine("*******************************************************");
            Console.WriteLine($"Short URL created and stored: {Constants.ShortUrlPrefix + shortUrl}");
            Console.WriteLine("*******************************************************");
        }

        private static string GenerateShortUrl(string longUrl)
        {
            return GeneratorAlgo.Generate(longUrl);
        }
    }
}

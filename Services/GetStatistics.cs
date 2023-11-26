using System;
using TinyUrlService.Entities;

namespace TinyUrlService.Services
{
    public class GetStatistics
    {
        public static void Get()
        {
            Console.WriteLine("Enter Short URL. Enter full url incuding domain.: ");

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

            if (UrlStorage.UrlMappings.TryGetValue(shortUrlKey, out UrlDetails? value))
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine("Short URL Found.");
                Console.WriteLine($"Click Count for {shortUrl} is: {value.ClickCount} clicks");
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

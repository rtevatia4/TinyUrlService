using System;
using TinyUrlService.Entities;
using TinyUrlService.Services;

namespace TinyUrlService
{
    public class TinyUrlService
    {
        public TinyUrlService() { }
        public static void Run()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("-- Welcome to URL Shortner Service --");
            Console.WriteLine("--------------------------------------");

            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Create Short URL");
                Console.WriteLine("2. Delete Short URL");
                Console.WriteLine("3. Get Long URL");
                Console.WriteLine("4. Get Click Statistics");
                Console.WriteLine("5. Exit");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Please select an option to continue: ");
                Console.WriteLine("--------------------------------------");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        CreateShortUrl.Create();
                        break;
                    case "2":
                        DeleteShortUrl.Delete();
                        break;
                    case "3":
                        GetLongUrl.Get();
                        break;
                    case "4":
                        GetStatistics.Get();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default: 
                        Console.WriteLine("Wrong option. Please choose the correct option.");
                        break;
                }
                Console.WriteLine();

            }
        }
    }
}

using System;

namespace TinyUrlService.Entities
{
    public class UrlStorage
    {
        public static Dictionary<string, UrlDetails> UrlMappings { get; } = new Dictionary<string, UrlDetails>();
    }
}

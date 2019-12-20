using System;

namespace ActivityMonitor.GitHubInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static Stream GetStream()
        {
            return File.OpenRead("gitAuth.json");
        }
    }
}

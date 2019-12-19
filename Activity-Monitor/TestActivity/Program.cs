using System;
using System.Threading.Tasks;
using ActivityMonitor.PMT;

namespace TestActivity
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new PMT("e.snegireva", "novgorodskii98", new Uri("https://ai.nsu.ru"));
            var proj = await client.GetProjects();

            Console.WriteLine("Hello World!");
        }
    }
}

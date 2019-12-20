using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ActivityMonitor
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            using (StreamReader r = new StreamReader(args[0]))
            {
                string json = r.ReadToEnd();
                var config = JsonConvert.DeserializeObject<Configuration>(json);

            }
        }
    }
}

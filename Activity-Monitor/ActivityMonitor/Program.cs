using System;
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
        }
    }
}

using System;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
             if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }
        }
    }
}

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
			
			int UserId;
            Int32.TryParse(args[0], out UserId);
            ActivityContext context = new ActivityContext();
        }
    }
}

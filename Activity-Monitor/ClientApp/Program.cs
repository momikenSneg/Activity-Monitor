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
			
			if (args[1] == "-task")
            {
                switch (args[2])
                {
                    case "All":
                        await GetClient.GetAllTasks(membership.ElementAt(0).Id, context);
                        break;
                    
                }
            }
        }
    }
	
	class GetClient
    {
        public static async Task GetAllTasks(int UserId, ActivityContext context)
        {
			var prj = await context.Issues.Where(e => e.MembershipId == UserId).ToListAsync();

            Console.Write($"{UserId} has {prj.Count} tasks");
        }

        
    }
}

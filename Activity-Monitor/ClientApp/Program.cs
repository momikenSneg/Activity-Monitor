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
					case "InTest":
                        await GetClient.GetTestTasks(membership.ElementAt(0).Id, context);
                        break;
                    case "InProgress":
                        await GetClient.GetInProgressTasks(membership.ElementAt(0).Id, context);
                        break;
					case "FromTest":
                        await GetClient.GetFromTestTasks(membership.ElementAt(0).Id, context);
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

		public static async Task GetTestTasks(int UserId, ActivityContext context)
        {
            var prj = await context.Issues.Join(context.Journals,
                i => i.Id,
                j => j.IssueId,
                (i, j) => new { OldVal = j.OldValue, NewVal = j.NewValue, Member = i.MembershipId }).Where(e => e.OldVal == "2" && e.NewVal == "3" && e.Member == UserId).ToListAsync();

            Console.Write($"{UserId} translate {prj.Count} tasks into tests");
        }
		
		public static async Task GetInProgressTasks(int UserId, ActivityContext context)
        {
            var prj = await context.Issues.Join(context.Journals,
                i => i.Id,
                j => j.IssueId,
                (i, j) => new { OldVal = j.OldValue, NewVal = j.NewValue, Member = i.MembershipId }).Where(e => e.OldVal == "1" && e.NewVal == "2" && e.Member == UserId).ToListAsync();

            Console.Write($"{UserId} translate {prj.Count} tasks into progress");
        }
		
		public static async Task GetFromTestTasks(int UserId, ActivityContext context)
        {
            
        }
        
    }
}

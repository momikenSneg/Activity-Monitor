﻿using System;
using System.Threading.Tasks;
using ActivityMonitor.Database;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ActivityMonitor.Database.Models;
using System.Collections.Generic;

namespace ClientApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args == null || args.Length < 3)
                return;

            int UserId;
            Int32.TryParse(args[0], out UserId);
            ActivityContext context = new ActivityContext();

            List<Membership> membership = await context.Memberships.Where(e => e.Name == args[0]).ToListAsync();

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
                    case "TasksTime":
                        await GetClient.GetTasksTime(membership.ElementAt(0).Id, context);
                        break;
                    case "BeforeDate":
                        await GetClient.BeforeDate(membership.ElementAt(0).Id, context, args[3]);
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
            var prj = await context.Issues.Join(context.Journals,
                i => i.Id,
                j => j.IssueId,
                (i, j) => new { OldVal = j.OldValue, NewVal = j.NewValue, Member = i.MembershipId }).Where(e => e.OldVal == "3" && e.NewVal == "2" && e.Member == UserId).ToListAsync();

            Console.Write($"{UserId} translate {prj.Count} returned from test");
        }

        public static async Task GetTasksTime(int UserId, ActivityContext context)
        {
            var prj = await context.Issues.Where(e => e.MembershipId == UserId).ToListAsync();

            foreach (Issue iss in prj){

                var time = iss.DueDate.Subtract(iss.StartDate);

                Console.Write($"{iss.Id} task time: {time.ToString("%d")} days\n");
            }
        }

        public static async Task BeforeDate(int UserId, ActivityContext context, string date)
        {
            DateTime tim = Convert.ToDateTime(date);

            var prj = await context.Issues.Where(e => e.MembershipId == UserId && DateTime.Compare(e.DueDate, tim) <= 0).ToListAsync();

            foreach (Issue iss in prj)
            {

                Console.Write($"{iss.Id} task time: {iss.DueDate.ToString("MM/dd/yyyy HH:mm:ss")} days\n");
            }
        }
    }
}

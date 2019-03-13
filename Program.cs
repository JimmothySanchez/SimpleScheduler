using System;
using Hangfire;
using Hangfire.Common;

namespace SimpleScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = args[0].ToString();
            RecurringJob.AddOrUpdate(
                () => System.Diagnostics.Process.Start(path),
                Cron.Daily);
            //Console.WriteLine("Hello World!");
        }
    }
}

using System;

namespace Hangfire.Service
{
    public class TestJob
    {
        public static void TestEnqueueJob()
        {
            BackgroundJob.Enqueue(() => Console.WriteLine("Fire-and-forget!"));
        }

        public static void TestScheduleJob()
        {
            BackgroundJob.Schedule(() => Console.WriteLine("Delayed!"), new TimeSpan(0, 0, 30));
        }

        public static void TestRecurringJob()
        {
            RecurringJob.AddOrUpdate(() => Console.WriteLine("Recurring!"), Cron.Minutely);
        }
    }
}

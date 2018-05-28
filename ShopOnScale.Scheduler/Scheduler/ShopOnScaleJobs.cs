using FluentScheduler;
using Invoices.Consumer.Infrastucture;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;

namespace ShopOnScale.Scheduler.Scheduler
{
    public static class ShopOnScaleJobs
    {
        public static void StartJobs(this IApplicationBuilder applicationBuilder)
        {
            using (var scope = applicationBuilder.ApplicationServices.CreateScope())
            {
               var consumerJob =  scope.ServiceProvider.GetService<CosumerJob>();

                JobManager.AddJob(consumerJob, (p) => p.ToRunNow().AndEvery(5).Seconds());
                // etc
                //JobManager.AddJob(consumerJob, (p) => p.ToRunNow().AndEvery(5).Seconds());
                //JobManager.AddJob(consumerJob, (p) => p.ToRunNow().AndEvery(5).Seconds());
            }

        }

        public static void NLogerTest(this ILoggerFactory loggerFactory)
        {
            var logger = loggerFactory.CreateLogger("SchedulerLogger");
            logger.LogCritical("Fail Log");
            logger.LogInformation("Log success");
        }
    }
}

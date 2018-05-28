using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentScheduler;
using Invoices.Consumer.Infrastucture;
using Invoices.Consumer.Infrastucture.DI;
using Invoices.Consumer.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ShopOnScale.Scheduler.Scheduler;

namespace ShopOnScale.Scheduler
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public CancellationToken CancellationToken { get; set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<InvoicesConsumerSettings>(Configuration.GetSection("InvoicesConsumerSettings"));
            services.AddInvoicesConsumer();

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApplicationLifetime lifetime, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.StartJobs();

            //To tylko taki przykładowy test, nie powinno się tak tego robić ;)
            loggerFactory.NLogerTest();
        }

    }
}

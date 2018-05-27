using FluentScheduler;
using Invoices.Consumer.Infrastucture.Interface;
using Invoices.Consumer.Infrastucture.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoices.Consumer.Infrastucture.DI
{
    public static class ConsumerServices
    {
        public static void AddInvoicesConsumer(this IServiceCollection services)
        {
            services.AddScoped<IConsumerRepository, ConsumerRepositry>();
            services.AddScoped<CosumerJob>();
        }

    }
}

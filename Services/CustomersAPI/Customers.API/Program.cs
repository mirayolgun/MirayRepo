using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesodev.Webservices.Business.DependencyResolvers;

namespace Customers.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
               .UseServiceProviderFactory(new AutofacServiceProviderFactory())
               .ConfigureContainer<ContainerBuilder>(builder =>
               {
                   builder.RegisterModule(new AutofacBusinessModule());
               })
               .ConfigureWebHostDefaults(webBuilder =>
               {
                   webBuilder.UseStartup<Startup>();
               });
        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseUrls("http://localhost:7002/");
        //            webBuilder.UseStartup<Startup>();
        //        });
    }
}

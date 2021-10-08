using API.Infrastructure;
using API.Infrastructure.Entities;
using API.Infrastructure.EntityFramework;
using API.Infrastructure.Utilities.Result;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesodev.Webservices.Business.Abstract;
using Tesodev.Webservices.Business.Concrete;
using Tesodev.Webservices.Data.Abstract;
using Tesodev.Webservices.Data.Concrete;

namespace Orders.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IResult, Result>();
            services.AddTransient(typeof(IEntityRepository<>), typeof(EfEntityRepositoryBase<,>));
            services.AddTransient<IOrderService, OrdersManager>();
            services.AddTransient<IEntity, Product>();
            services.AddTransient<IEntity, Order>();
            services.AddTransient<IEntity, Addess>();
            services.AddTransient<IEntity, Customer>();

            //services.AddTransient(typeof(IEntityRepository<>), ICustomersDal );
            services.AddTransient<IOrdersDal, EfOrdersDal>();
            services.AddTransient(typeof(IDataResult<>), typeof(DataResult<>));
            //services.AddTransient<ICustomerService, CustomersManager>();
            //services.AddTransient<ICustomerDal, EfProductDal>();
            //services.AddTransient<IBasketItemDal, EfBasketItemDal>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

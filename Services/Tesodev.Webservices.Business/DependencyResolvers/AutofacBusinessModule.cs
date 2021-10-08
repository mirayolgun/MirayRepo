using Microsoft.AspNetCore.Http;
using System;
using Autofac;
using System.Collections.Generic;
using System.Text;
using Tesodev.Webservices.Business.Abstract;
using Tesodev.Webservices.Business.Concrete;
using Tesodev.Webservices.Data.Abstract;
using Tesodev.Webservices.Data.Concrete;

namespace Tesodev.Webservices.Business.DependencyResolvers
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfCustomersDal>().As<ICustomersDal>().SingleInstance();
            builder.RegisterType<EfOrdersDal>().As<IOrdersDal>().SingleInstance();

            builder.RegisterType<CustomersManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<OrdersManager>().As<IOrderService>().SingleInstance();

            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();
        }
    }
}

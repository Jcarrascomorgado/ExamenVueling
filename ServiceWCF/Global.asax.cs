using Autofac;
using Autofac.Integration.Wcf;
using Domain;
using Domain.Tickets;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ServiceWCF
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<ServiceTicket>().As<IServiceTicket>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<RepositoryTicket>().As<IRepositoryTicket>();
            builder.RegisterType<UserContext>().As<IDbContext>().As<IUnitOfWork>().InstancePerLifetimeScope();

            // Set the dependency resolver.
            var container = builder.Build();
            AutofacHostFactory.Container = container;

        }

    }
}
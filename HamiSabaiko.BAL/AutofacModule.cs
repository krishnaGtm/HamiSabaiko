using Autofac;
using HamiSabaiko.BAL.Interfaces;
using HamiSabaiko.BAL.Services;
using HamiSabaiko.DAL.Interfaces;
using HamiSabaiko.DAL.Interfaces.Base;
using HamiSabaiko.DAL.Databases;
using HamiSabaiko.DAL.Repositiories;
using System;

namespace HamiSabaiko.BAL
{
    public class AutofacModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Database
            //builder.RegisterType<UserContext>().As<IUserContext>().InstancePerLifetimeScope();
           
            builder.RegisterType<SqlDatabase>().As<IDatabase>().WithParameter("nameOrConnectionString", "ConnectionString").InstancePerRequest();

            //Repositories
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().InstancePerRequest();

            //Services
            builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerRequest();
        }
        
    }
}

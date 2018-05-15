using Autofac;
using Enza.UTM.DataAccess.Databases;
using HamiSabaiko.BAL.Interfaces;
using HamiSabaiko.BAL.Services;
using HamiSabaiko.DAL.Interfaces;
using HamiSabaiko.DAL.Interfaces.Base;
using HamiSabaiko.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamiSabaiko.BAL
{
    public class AutofacModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Database
            //builder.RegisterType<UserContext>().As<IUserContext>().InstancePerLifetimeScope();
            builder.RegisterType<SqlDatabase>().As<IDatabase>().WithParameter("nameOrConnectionString", "ConnectionString").InstancePerLifetimeScope();

            //Repositories
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().InstancePerLifetimeScope();

            //Services
            builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerLifetimeScope();
        }
    }
}

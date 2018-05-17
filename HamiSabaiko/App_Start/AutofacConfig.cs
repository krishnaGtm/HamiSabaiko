using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;
using Autofac;
using HamiSabaiko.BAL;
using Autofac.Integration.Mvc;
using HamiSabaiko.Controllers;

namespace HamiSabaiko
{
    public static class AutofacConfig
    {
        //public static void Configure(HttpConfiguration config, Action<ContainerBuilder> registration, Action<ILifetimeScope> callback)
        //{
        //    var builder = new ContainerBuilder();
        //    builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

        //    //register other types
        //    builder.RegisterModule<AutofacModule>();

        //    //register jobs
        //    registration(builder);

        //    //register scheduler
        //    builder.Register(context =>
        //    {
        //        var ctx = context.Resolve<IComponentContext>();
        //        var scheduler = AsyncHelper.RunSync(async () =>
        //        {
        //            var service = await StdSchedulerFactory.GetDefaultScheduler();
        //            service.JobFactory = new CronJobSchedulerFactory(ctx);
        //            return service;
        //        });
        //        return scheduler;
        //    }).As<IScheduler>().SingleInstance();

        //    builder.Register(context =>
        //    {
        //        var scheduler = context.Resolve<IScheduler>();
        //        return new CronJobScheduler(scheduler);
        //    }).As<ICronJobScheduler>().InstancePerLifetimeScope();

        //    var container = builder.Build();
        //    using (var scope = container.BeginLifetimeScope())
        //    {
        //        callback(scope);
        //    }
        //    config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        //}
        internal static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //register other types
            builder.RegisterModule<AutofacModule>();
            builder.RegisterType<HomeController>().InstancePerRequest();
            var container = builder.Build();
            DependencyResolver.SetResolver((new AutofacDependencyResolver(container)));
            //config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

        }
    }
}

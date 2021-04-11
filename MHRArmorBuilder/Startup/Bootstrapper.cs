using Autofac;
using System.Reflection;
using MHRArmorBuilder.Interfaces;
using MHRArmorBuilder.Services;
using Prism.Events;

namespace MHRArmorBuilder.Startup
{
    class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly());

            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            
            builder.RegisterType<ArmorRepository>().As<IStartable>().As<IArmorRepository>().SingleInstance();
            builder.RegisterType<ArmorRepositoryPath>().As<IArmorRepositoryPath>().SingleInstance();
            
            builder.RegisterType<ArmorBuilder>().As<IArmorBuilder>();

            return builder.Build();
        }
    }
}

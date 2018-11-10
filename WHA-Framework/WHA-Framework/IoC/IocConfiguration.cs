using System.Reflection;
using Autofac;
using EntityDatabase.Common;
using WpfApplication.DataMappings;
using WpfApplication.Services;

namespace WpfApplication.IoC
{
    public static class IocConfiguration
    {
        public static IContainer Initialize()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<BankingService>().As<IBankingService>();
            containerBuilder.RegisterType<DataMapper>().As<IDataMapper>();
            containerBuilder.RegisterType<TransactionService>().As<ITransactionService>();
            containerBuilder.RegisterType<UpdateDbTables>().As<IUpdateDbTables>();


            containerBuilder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(IocConfiguration)));

            return containerBuilder.Build();
        }


    }
}

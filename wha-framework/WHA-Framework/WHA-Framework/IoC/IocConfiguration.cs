using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using WHA.Framework.Database.Common;
using WHA_Framework.DataMappings;
using WHA_Framework.Services;
using WHA_Framework.Utilities;

namespace WHA_Framework.IoC
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

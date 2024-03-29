﻿using Autofac;
using TradeProject.Data;
using TradeProject.Model;
using TradeProject.Repository;
using TradeProject.Repository.Interface;

namespace TradeProject.Setting
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<StoreProductRepo>().As<IRepoProducts<StoreProduct>>();
            builder.RegisterType<MonthlyProductRepo>().As<IRepoMonthly<Monthly>>();
            builder.RegisterType<DBContext<StoreProduct>>();
            builder.RegisterType<StoreProduct>();
            return builder.Build();
        }
    }
}

using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            builder.RegisterType<StoreProductRepo>().As<IRepo<StoreProduct>>();
            builder.RegisterType<StorageProductRepo>().As<IRepo<StorageProduct>>();
            builder.RegisterType<DBContext<StorageProduct>>();
            builder.RegisterType<DBContext<StoreProduct>>();
            return builder.Build();
        }
    }
}

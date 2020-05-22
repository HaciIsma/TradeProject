using Autofac;
using TradeProject.Data;
using TradeProject.Model;
using TradeProject.Repository;
using TradeProject.Repository.Interface;
using TradeProject.View.Pages;
using TradeProject.View.Pages.Store;

namespace TradeProject.Setting
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            #region Models
            builder.RegisterType<StoreProductRepo>().As<IRepoProducts<StoreProduct>>();
            builder.RegisterType<StorageProductRepo>().As<IRepoProducts<StorageProduct>>();
            builder.RegisterType<MonthlyProductRepo>().As<IRepoMonthly<Monthly>>();
            builder.RegisterType<DBContext<StorageProduct>>();
            builder.RegisterType<DBContext<StoreProduct>>();
            #endregion

            #region Views
            builder.RegisterType<StoreAdd>();
            builder.RegisterType<StoreDelete>();
            builder.RegisterType<StoreHome>();
            builder.RegisterType<Choose>();
            #endregion

            return builder.Build();
        }
    }
}

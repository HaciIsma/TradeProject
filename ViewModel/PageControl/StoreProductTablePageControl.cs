using Autofac;
using System.Collections.Generic;
using TradeProject.Model;
using TradeProject.Repository.Interface;
using TradeProject.Setting;
using TradeProject.ViewModel.PageControl.Interface;

namespace TradeProject.ViewModel.PageControl
{
    public class StoreProductTablePageControl : IGetDatabaseProductList<StoreProduct>
    {
        public List<StoreProduct> Products { get; private set; }
        public StoreProductTablePageControl()
        {
            Products = ContainerConfig.Configure().Resolve<IRepo<StoreProduct>>().GetAll();
        }
    }
}

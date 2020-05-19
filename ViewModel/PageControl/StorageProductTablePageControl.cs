using System;
using Autofac;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeProject.Model;
using TradeProject.Setting;
using TradeProject.ViewModel.PageControl.Interface;
using TradeProject.Repository.Interface;

namespace TradeProject.ViewModel.PageControl
{
    public class StorageProductTablePageControl : IGetDatabaseProductList<StorageProduct>
    {
        public List<StorageProduct> Products { get; private set; }
        public StorageProductTablePageControl()
        {
            Products = ContainerConfig.Configure().Resolve<IRepo<StorageProduct>>().GetAll();
        }
    }
}

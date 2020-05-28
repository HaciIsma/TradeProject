using Autofac;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;
using TradeProject.Command;
using TradeProject.Model;
using TradeProject.Repository;
using TradeProject.Repository.Interface;
using TradeProject.Setting;

namespace TradeProject.ViewModel.PageControl
{
    public class StoreAddPageControl
    {
        public string Code { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Count { get; set; }
        public ICommand AddCommand { get; set; }
        public StoreAddPageControl()
        {
            AddCommand = new RelayCommand(AddCommandExecute);
        }
        private void AddCommandExecute(object param)
        {
            StoreProduct product = ContainerConfig.Configure().Resolve<IRepoProducts<StoreProduct>>().Get(u => u.Code == Code);
            if (product == null)
            {
                product = new StoreProduct
                {
                    Code = this.Code,
                    PurchasePrice = this.PurchasePrice,
                    SalePrice = this.SalePrice,
                    StoreCount = this.Count
                };
                ContainerConfig.Configure().Resolve<IRepoProducts<StoreProduct>>().Add(product);
            }
            else
            {
                product.StoreCount += Count;
                ContainerConfig.Configure().Resolve<IRepoProducts<StoreProduct>>().Update(product);
            }
        }
    }
}

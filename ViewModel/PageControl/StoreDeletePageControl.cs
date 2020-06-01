using Autofac;
using PropertyChanged;
using System.Collections.Generic;
using System.Windows.Input;
using TradeProject.Command;
using TradeProject.Model;
using TradeProject.Repository.Interface;
using TradeProject.Setting;

namespace TradeProject.ViewModel.PageControl
{
    [AddINotifyPropertyChangedInterface]
    public class StoreDeletePageControl
    {
        public List<StoreProduct> Products { get; set; }
        public ICommand DeleteCommand { get; set; }
        public StoreDeletePageControl()
        {
            Load();
            DeleteCommand = new RelayCommand(DeleteCommandExecute);
        }
        private void DeleteCommandExecute(object param)
        {
            foreach (var item in Products)
            {
                if (item.IsSelected)
                {
                    ContainerConfig.Configure().Resolve<IRepoProducts<StoreProduct>>().Remove(item);
                }
            }
            Load();
        }
        private void Load()
        {
            Products = ContainerConfig.Configure().Resolve<IRepoProducts<StoreProduct>>().GetAll();
        }
    }
}

using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using TradeProject.Command;
using TradeProject.View.Pages;

namespace TradeProject.ViewModel.PageControl
{
    [AddINotifyPropertyChangedInterface]
    public class StoreHomeControl
    {
        public string PagePath { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand HistoryCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand CreatNewPage { get; set; }
        public StoreHomeControl(Page pages)
        {
            AddCommand = new RelayCommand(AddCommandExecute);
            RemoveCommand = new RelayCommand(RemoveCommandExecute);
            HistoryCommand = new RelayCommand(HistoryCommandExecute);
            UpdateCommand = new RelayCommand(UpdateCommandExecute);

            CreatNewPage = new RelayCommand(e =>
            {
                pages.NavigationService.Navigate(new StoreProductTablePage());
            });

           // PagePath = "/View/Pages/Store/StoreProductTablePage.xaml";
        }

        private void AddCommandExecute(object param)
        {
            //PagePath = "Pages/Store/StoreAdd.xaml";
        }
        private void RemoveCommandExecute(object param)
        {
           // PagePath = "Pages/Store/StoreDelete.xaml";
        }
        private void HistoryCommandExecute(object param)
        {
        }
        private void UpdateCommandExecute(object param)
        {
        }
    }
}

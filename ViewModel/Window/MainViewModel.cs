using Autofac;
using PropertyChanged;
using System.Configuration;
using System.Windows.Input;
using TradeProject.Command;
using TradeProject.Model;
using TradeProject.Repository.Interface;
using TradeProject.Setting;

namespace TradeProject.ViewModel.Window
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel
    {
        public string LoginPagePath { get; set; }
        public string PagePath { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand HistoryCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand SellCommand { get; set; }
        public MainViewModel()
        {
            AddCommand = new RelayCommand(AddCommandExecute);
            RemoveCommand = new RelayCommand(RemoveCommandExecute);
            HistoryCommand = new RelayCommand(HistoryCommandExecute);
            UpdateCommand = new RelayCommand(UpdateCommandExecute);
            SellCommand = new RelayCommand(SellCommandExecute);

            LoginPagePath = "Pages/Login.xaml";
            PagePath = "Pages/Store/StoreAdd.xaml";
        }

        private void AddCommandExecute(object param)
        {
            PagePath = "Pages/Store/StoreAdd.xaml";
        }
        private void RemoveCommandExecute(object param)
        {
            PagePath = "Pages/Store/StoreDelete.xaml";
        }
        private void HistoryCommandExecute(object param)
        {
            PagePath = "Pages/Store/StoreHistory.xaml";
        }
        private void UpdateCommandExecute(object param)
        {
            PagePath = "Pages/Store/StoreUpdate.xaml";
        }
        private void SellCommandExecute(object param)
        {
            PagePath = "Pages/Store/StoreSell.xaml";
        }
    }
}

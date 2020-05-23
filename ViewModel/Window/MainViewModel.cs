using PropertyChanged;
using System.Windows.Input;
using TradeProject.Command;

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

        public MainViewModel()
        {
            //PagePath = "Pages/Store/StoreHome.xaml";
            AddCommand = new RelayCommand(AddCommandExecute);
            RemoveCommand = new RelayCommand(RemoveCommandExecute);
            HistoryCommand = new RelayCommand(HistoryCommandExecute);
            UpdateCommand = new RelayCommand(UpdateCommandExecute);

            LoginPagePath = "Pages/Login.xaml";
            PagePath = "Pages/Store/StoreAdd.xaml";
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

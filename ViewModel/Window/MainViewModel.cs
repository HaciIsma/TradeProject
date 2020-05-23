using PropertyChanged;

namespace TradeProject.ViewModel.Window
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel
    {
        public string PagePath { get; set; }
        public string LoginPagePath { get; set; }
        public MainViewModel()
        {
            LoginPagePath = "Pages/Login.xaml";
            PagePath = "Pages/Store/StoreHome.xaml";
        }
    }
}

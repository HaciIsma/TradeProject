using PropertyChanged;
using System.Configuration;
using System.Windows.Input;
using TradeProject.Command;

namespace TradeProject.ViewModel.PageControl
{
    [AddINotifyPropertyChangedInterface]
    public class LoginPageControl
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string LoginPageVisibility { get; set; }
        public ICommand LoginCommand { get; set; }
        public LoginPageControl()
        {
            LoginPageVisibility = "Visible";
            LoginCommand = new RelayCommand(LoginCommandExecute);
        }
        private void LoginCommandExecute(object param)
        {
            if (Username == ConfigurationManager.AppSettings["Username"] && Password == ConfigurationManager.AppSettings["Password"])
            {
                LoginPageVisibility = "Hidden";
            }
        }
    }
}

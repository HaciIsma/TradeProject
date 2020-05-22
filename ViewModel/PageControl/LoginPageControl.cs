using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TradeProject.Command;

namespace TradeProject.ViewModel.PageControl
{
    [AddINotifyPropertyChangedInterface]
    public class LoginPageControl
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string V { get; set; } = "Visible";
        public ICommand LoginCommand { get; set; }
        public LoginPageControl()
        {
            LoginCommand = new RelayCommand(LoginCommandExecute);
        }

        private void LoginCommandExecute(object param)
        {
            if (Username == ConfigurationManager.AppSettings["Username"] && Password == ConfigurationManager.AppSettings["Password"])
            {
                V = "Hidden";
            }
        }
    }
}

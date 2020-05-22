using Autofac;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using TradeProject.View.Pages;
using TradeProject.ViewModel.PageControl;

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

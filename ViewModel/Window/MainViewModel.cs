using Autofac;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeProject.View.Pages;

namespace TradeProject.ViewModel.Window
{
    public class MainViewModel
    {
        public string PagePath { get; set; }
        private List<String> _path;
        public string A { get; set; }

        public MainViewModel()
        {
            _path = new List<string>
           {
               "Pages/Login.xaml"

           };

            A = _path[0];
            PagePath = "Pages/Choose.xaml";



           // PagePath = _path[0];
        }
    }
}

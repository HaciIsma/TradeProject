using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TradeProject.Command;

namespace TradeProject.ViewModel.PageControl
{
    public class StoreSellPageControl
    {
        public string Code { get; set; }
        public int Count { get; set; }
        public ICommand SellCommand { get; set; }
        public StoreSellPageControl()
        {
            SellCommand = new RelayCommand(SellCommandExecute);
        }
        public void SellCommandExecute(object param)
        {
            MessageBox.Show("Selled");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TradeProject.Command;

namespace TradeProject.ViewModel.PageControl
{
    public class StoreUpdatePageControl
    {
        public string Code { get; set; }
        public ICommand UpdateCommand { get; set; }
        public string UCode { get; set; }

        public StoreUpdatePageControl()
        {
            UpdateCommand = new RelayCommand(UpdateCommandExecute);
        }
        private void UpdateCommandExecute(object param)
        {

        }

    }
}

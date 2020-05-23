using System.Windows;
using System.Windows.Input;
using TradeProject.Command;

namespace TradeProject.ViewModel.PageControl
{
    public class StoreAddPageControl
    {
        public string Code { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Count { get; set; }
        public ICommand AddCommand { get; set; }
        public StoreAddPageControl()
        {
            AddCommand = new RelayCommand(AddCommandExecute);
        }
        private void AddCommandExecute(object param)
        {
            MessageBox.Show("Added");
        }
    }
}

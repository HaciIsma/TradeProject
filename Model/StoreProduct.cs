using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeProject.Model
{
    public class StoreProduct
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public decimal SalePrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Sell { get; set; }
        public int StoreCount { get; set; }
        public int ComingStore { get; set; }
        public int LeaveStore { get; set; }
        public decimal MonthlyProfit { get; set; }
    }
}

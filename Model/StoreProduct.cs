namespace TradeProject.Model
{
    public class StoreProduct
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public decimal SalePrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Sell { get; set; } = default;
        public int StoreCount { get; set; }
        public decimal Profit { get; set; } = default;

        public bool IsSelected { get; set; }

    }
}

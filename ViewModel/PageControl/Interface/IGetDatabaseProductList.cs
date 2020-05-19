using System.Collections.Generic;

namespace TradeProject.ViewModel.PageControl.Interface
{
    public interface IGetDatabaseProductList<T>
    {
        List<T> Products { get; }
    }
}

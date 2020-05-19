using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeProject.ViewModel.PageControl.Interface
{
    public interface IGetDatabaseProductList<T>
    {
        List<T> Products { get; }
    }
}

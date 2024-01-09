using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___Events
{

    public enum Currency
    {
        MDL,
        EUR,
        USD
    }
    public class Price
    { 

        private static Dictionary<Currency, decimal> ExchangeRate = new Dictionary<Currency, decimal>();
        private Currency currency { get; set; }
        private decimal Value { get; set; }

    }


}
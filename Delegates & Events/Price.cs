using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___Events
{
    public class Price
    {

        private static Dictionary<Currency, decimal> ExchangeRate { get; set; }
        private Currency currency {  get; set; }
        private decimal Value { get; set; }

        enum Currency
        {
            MDL,
            EUR,
            USD
        }
    }
}

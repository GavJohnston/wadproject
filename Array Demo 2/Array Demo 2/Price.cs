using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Demo_2
{
    class Price
    {
        public double Amount { get; set; }
        public string Currency { get; set; }

        public Price(double amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;

        }

        public string Show()
        {
            return " " + Currency + " " + Amount; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Kantor
{
    class Currency
    {
        public string Name { get; set; }
        public decimal Buy { get; set; }
        public decimal Sell { get; set; }

        public Currency()
        {
            Name = "Unknown";
            Buy = Sell = 0;
        }

        public Currency(string name, decimal buy = 0, decimal sell = 0)
        {
            Name = name;
            Buy = buy;
            Sell = sell;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

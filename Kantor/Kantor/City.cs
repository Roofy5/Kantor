using System;
using System.Collections.Generic;
using System.Text;

namespace Kantor
{
    class City
    {
        public string Name { get; private set; }
        public List<CurrencyExchange> CurrencyExhanges { get; private set; }

        public City()
        {
            Name = "Unknown";
            CurrencyExhanges = new List<CurrencyExchange>();
        }

        public City(string name, CurrencyExchange currencyExchanges)
        {
            Name = name;
            CurrencyExhanges = currencyExchanges;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

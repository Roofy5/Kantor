using System;
using System.Collections.Generic;
using System.Text;

namespace Kantor
{
    class CurrencyExchange
    {
        public string Name { get; private set; }
        public string WebPage { get; private set; }
        public string Address { get; private set; }
        public AdditionalInformation Informations { get; private set; }
        public List<Currency> Currencies { get; private set; }

        public CurrencyExchange()
        {
            Name = "Unknown";
            WebPage = "Unknown";
            Address = "Unknown";
            Informations = new AdditionalInformation();
            Currencies = new List<Currency>();
        }

        public CurrencyExchange(string name, string webPage, string address, AdditionalInformation informations, List<Currency> currencies)
        {
            Name = name;
            WebPage = webPage;
            Address = address;
            Informations = informations;
            Currencies = currencies;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Kantor.Data
{
    abstract class DownloadData
    {
        protected WebDownloader webDownloader;
        protected HTMLParser htmlParser;

        public CurrencyExchange GetCurrencyExchange()
        {
            string pageContent = webDownloader.GetPageContent();
            htmlParser.PageContent = pageContent;

            string ceName = htmlParser.GetName();
            string ceAddress = htmlParser.GetAddress();
            string ceEmail = htmlParser.GetEmail();
            string ceOpenHours = htmlParser.GetOpenHours();
            string ceInformations = htmlParser.GetOtherInformations();
            string cePhoneNumber = htmlParser.GetPhoneNumber();
            List<Currency> ceCurrencies = htmlParser.GetCurrencies();

            return new CurrencyExchange();
        }   
    }
}

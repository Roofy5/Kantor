using System;
using System.Collections.Generic;
using System.Text;

namespace Kantor.Data
{
    abstract class HTMLParser
    {
        public virtual string PageContent { private get; set; }

        public virtual string GetName()
        {
            return "Nieznana nazwa";
        }
        public virtual string GetAddress()
        {
            return "Nieznany adres";
        }
        public virtual string GetOpenHours()
        {
            return "Nieznane";
        }
        public virtual string GetEmail()
        {
            return "Nieznany email";
        }
        public virtual string GetPhoneNumber()
        {
            return "Nieznany numer telefonu";
        }
        public virtual string GetOtherInformations()
        {
            return "";
        }
        public abstract List<Currency> GetCurrencies();
    }
}

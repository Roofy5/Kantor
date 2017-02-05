using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Kantor.Data
{
    abstract class WebDownloader
    {
        protected string webPageAddress;

        public string GetPageContent()
        {
            var page = new WebClient();
            return page.DownloadString(webPageAddress);
        }
    }
}

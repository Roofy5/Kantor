using System;
using System.Collections.Generic;
using System.Text;

namespace Kantor
{
    class AdditionalInformation
    {
        public string OpenHours { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string OtherInformations { get; set; }


        public AdditionalInformation()
        {
            OpenHours = "Unknown";
            Email = "Unknown";
            PhoneNumber = "Unknown";
            OtherInformations = "Unknown";
        }
    }
}

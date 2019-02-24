using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Backend.Domain
{
    public class Objects
    {
        [XmlRootAttribute("LoginData", Namespace = "http://www.cpandl.com",
        IsNullable = false)]
        public class CheckCcPinNumber
        {
            public string CcNumber { get; set; }
            public string PinNumber { get; set; }
        }
        [XmlRootAttribute("BalanceData", Namespace = "http://www.cpandl.com",
        IsNullable = false)]
        public class CheckBalance
        {
            public string AccountNumber { get; set; }
        }
    }
}

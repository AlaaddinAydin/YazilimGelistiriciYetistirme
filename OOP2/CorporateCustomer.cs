using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //miras İnheritence
    internal class CorporateCustomer:Customer
    {
        
        public string CompanyName { get; set; }
        public string VergiNo { get; set; }
    }
}

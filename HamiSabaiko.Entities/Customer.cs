using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamiSabaiko.Entities
{
    public class Customer
    {
        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int LoanAmount { get; set; }
    }
}

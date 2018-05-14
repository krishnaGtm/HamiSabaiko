using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HamiSabaiko.Models
{
    public class Customer
    {
        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public double LoanAmount { get; set; }

    }
}
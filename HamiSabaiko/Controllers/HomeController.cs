using HamiSabaiko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HamiSabaiko.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    SerialNumber = 1,
                    Name = "test1",
                    Amount = 200,
                    LoanAmount =150
                },
                new Customer
                {
                    SerialNumber = 2,
                    Name = "test2",
                    Amount = 300,
                    LoanAmount = 130
                }
            };
            return View(customers);
        }
    }
}
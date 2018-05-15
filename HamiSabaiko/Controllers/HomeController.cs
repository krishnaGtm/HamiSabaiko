using HamiSabaiko.BAL.Interfaces;
using HamiSabaiko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HamiSabaiko.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerService _service;
        public HomeController(ICustomerService service)
        {
            _service = service;
        }
        // GET: Home
        public async Task<ActionResult> Index()
        {
            var data = await _service.GetAllCustomerAsync(1);
            //var customers = new List<Customer>
            //{
            //    new Customer
            //    {
            //        SerialNumber = 1,
            //        Name = "test1",
            //        Amount = 200,
            //        LoanAmount =150
            //    },
            //    new Customer
            //    {
            //        SerialNumber = 2,
            //        Name = "test2",
            //        Amount = 300,
            //        LoanAmount = 130
            //    }
            //};
            return View(data);
        }
    }
}
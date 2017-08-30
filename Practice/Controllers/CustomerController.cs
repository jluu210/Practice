using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer/index
        //[Route("customer/index")]
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Detail(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);

        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Mark Smith"},
                new Customer {Id = 2, Name = "John Daniels"},
                new Customer {Id = 3, Name = "Martha Lyster"}
            };

        }
    }

    
}
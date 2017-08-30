using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Practice.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: customer/index
        public ActionResult Index()
        {
            //var customers = GetCustomers();
            var customers = _context.Customers.Include(c =>c.MembershipType).ToList();
            return View(customers);
        }


        //GET: customer/detail/id
        public ActionResult Detail(int id)
        {
            //var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);


            if (customer == null)
                return HttpNotFound();

            return View(customer);

        }


        //hard coded test customers
        /*private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Mark Smith"},
                new Customer {Id = 2, Name = "John Daniels"},
                new Customer {Id = 3, Name = "Martha Lyster"}
            };

        }*/
    }

    
}
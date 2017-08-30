using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;
using Practice.ViewModels;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hello. This is my first ASP.Net Project";

            return View();
        }

        /*public ActionResult Customers()
        {
            Widget widget = new Widget
            {
                Name = "widget 1"
            };

            var customers = new List<Customer>
            {
                new Customer { Name = "Mark Smith"},
                new Customer { Name = "John Daniels"},
                new Customer { Name = "Martha Lyster"}
            };

            var viewModel = new RandomWidgetViewModel
            {
                Widget = widget,
                Customers = customers
            };


            return View(viewModel);
        }*/

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
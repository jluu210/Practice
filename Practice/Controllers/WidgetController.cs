using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;
using Practice.ViewModels;

namespace Practice.Controllers
{
    public class WidgetController : Controller
    {
        // GET: Widget/Random
        [Route("widgets/random/")]
        public ActionResult Random()
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
        }

        [Route("widgets/index/")]
        public ActionResult Index (int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex, sortBy));
        }

        [Route("widgets/byPrice/")]
        public ActionResult WidgetsByPrice(float amount)
        {
            return HttpNotFound();
        }
    }
}
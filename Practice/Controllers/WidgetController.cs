using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;
using System.Data.Entity;
using Practice.ViewModels;

namespace Practice.Controllers
{
    public class WidgetController : Controller
    {
        private ApplicationDbContext _context;

        public WidgetController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Widget/Random
        [Route("widgets/random/")]
        public ActionResult Random()
        {
            return HttpNotFound();
        }

        [Route("widget/index/")]
        public ActionResult Index ()
        {
            var widgets = _context.Widgets.Include(w => w.WidgetType).ToList();
            return View(widgets);
        }

        public ActionResult Detail(int id)
        {
            var widget = _context.Widgets.Include(w => w.WidgetType).SingleOrDefault(w => w.Id == id);


            if (widget == null)
                return HttpNotFound();

            return View(widget);
        }

        [Route("widgets/byPrice/")]
        public ActionResult WidgetsByPrice(float amount)
        {
            return HttpNotFound();
        }
    }
}
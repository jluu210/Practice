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
        [Route("widget/random/")]
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

            var viewModel = new WidgetFormViewModel
            {
                Widget = widget,
                WidgetTypes = _context.WidgetTypes.ToList()
            };


            return View("WidgetForm",viewModel);
        }

        //[Route("widget/new/")]
        public ActionResult New()
        {
            var widgetTypes = _context.WidgetTypes.ToList();
            var viewModel = new WidgetFormViewModel
            {
                WidgetTypes = widgetTypes
            };
            return View("WidgetForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Widget widget)
        {
            if(widget.Id == 0)
            {
                _context.Widgets.Add(widget);
            }
            else
            {
                var widgetInDb = _context.Widgets.Single(w => w.Id == widget.Id);
                widgetInDb.Name = widget.Name;
                widgetInDb.NumberInStock = widget.NumberInStock;
                widgetInDb.WidgetTypeId = widget.WidgetTypeId;
            }
            _context.SaveChanges();

            return RedirectToAction("Index","Widget");
        }



        [Route("widget/byPrice/")]
        public ActionResult WidgetsByPrice(float amount)
        {
            return HttpNotFound();
        }
    }
}
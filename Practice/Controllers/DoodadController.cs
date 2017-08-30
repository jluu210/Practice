using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;

namespace Practice.Controllers
{
    public class DoodadController : Controller
    {
        // GET: Doodad/Random
        public ActionResult Random()
        {
            Doodad doodad = new Doodad() { Name = "Doodad1"};
            return View();
        }
    }
}
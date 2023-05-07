using EasyTripMVC.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTripMVC.Controllers
{
    public class AboutController : Controller
    {
        Context c= new Context();
        public ActionResult About()
        {
            var values = c.Abouts.ToList();
            return View(values);
        }
    }
}
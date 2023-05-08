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

        public ActionResult Index()
        {
            var values= c.Abouts.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var values = c.Abouts.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            var x = c.Abouts.Find(p.AboutID);
            x.ImageURL= p.ImageURL;
            x.Description= p.Description;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
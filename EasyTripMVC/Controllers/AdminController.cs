using EasyTripMVC.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTripMVC.Controllers
{
    public class AdminController : Controller
    {
      Context c= new Context();
        public ActionResult BlogIndex()
        {
            var values= c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddBlog() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("BlogIndex");   
        }
    }
}
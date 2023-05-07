using EasyTripMVC.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTripMVC.Controllers
{
    public class HomeController : Controller
    {
        Context c= new Context();
        public ActionResult Index()
        {
            var values= c.Blogs.ToList();
            return View(values);
        }

        public PartialViewResult PartialFeature()
        {
            var value= c.Blogs.OrderByDescending(x=>x.BlogID).Take(3).ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialTop10()
        {
            var value = c.Blogs.OrderByDescending(x => x.BlogID).Take(10).ToList();
            return PartialView(value);
        }
        BlogComment bc = new BlogComment();
        public PartialViewResult PartialPlaces()
        {
            bc.blogs = c.Blogs.OrderBy(x=>x.BlogID).Take(3).ToList();
            bc.blogs2 = c.Blogs.OrderByDescending(x=>x.BlogID).Take(3).ToList();
            return PartialView(bc);
        }


    }
}
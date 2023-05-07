using EasyTripMVC.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTripMVC.Controllers
{
    public class BlogController : Controller
    {
        Context c= new Context();
       
        public ActionResult Index()
        {
            //var values= c.Blogs.ToList();
            bc.blogs=c.Blogs.ToList();
            bc.blogs2 = c.Blogs.OrderByDescending(x => x.BlogID).Take(3).ToList();
            bc.comments=c.Comments.OrderByDescending(x => x.CommentID).Take(3).ToList();
            return View(bc);
        }

        BlogComment bc=new BlogComment();
        public ActionResult BlogDetails(int id)   
        {
            //var values = c.Blogs.Where(x=>x.BlogID==id).ToList();
           
            bc.blogs=c.Blogs.Where(x=>x.BlogID==id).ToList();   
            bc.comments=c.Comments.Where(x=>x.BlogID==id).ToList();
            return View(bc);
        }
        [HttpGet]
        public PartialViewResult MakeComment(int id)
        {
            ViewBag.id=id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult MakeComment(Comment p) 
        {
            c.Comments.Add(p);
            c.SaveChanges();
            return PartialView();
        }
    }
}
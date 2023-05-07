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
        [Authorize]
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

        public ActionResult DeleteBlog(int id)
        {
            var values = c.Blogs.Find(id);
            c.Blogs.Remove(values);
            c.SaveChanges();
            return RedirectToAction("BlogIndex");
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var values=c.Blogs.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateBlog(Blog p)
        {
            var x = c.Blogs.Find(p.BlogID);
            x.Title = p.Title;
            x.Description=p.Description;
            x.BlogImage= p.BlogImage;
            x.Date = p.Date;
            c.SaveChanges();
            return RedirectToAction("BlogIndex");
        }

        public ActionResult Comments()
        {
            var values = c.Comments.ToList();
            return View(values);
        }

        public ActionResult DeleteComment(int id)
        {
            var values = c.Comments.Find(id);
            c.Comments.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Comments");
        }

        [HttpGet]
        public ActionResult UpdateComment(int id)
        {
            var values = c.Comments.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateComment(Comment p)
        {
            var x = c.Comments.Find(p.CommentID);
            x.Name = p.Name;
            x.Mail  = p.Mail;
            x.Comments = p.Comments;
            x.Blog.Title = p.Blog.Title;
            c.SaveChanges();
            return RedirectToAction("Comments");
        }
    }
}
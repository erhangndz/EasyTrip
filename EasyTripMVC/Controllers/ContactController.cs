using EasyTripMVC.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyTripMVC.Controllers
{
    public class ContactController : Controller
    {
       Context c= new Context();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact p)
        {
           c.Contacts.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index","Home");
        }

        public ActionResult Contacts() 
        {
        var values= c.Contacts.ToList();
            return View(values);    
        }

        public ActionResult DeleteMessage(int id)
        {
            var values = c.Contacts.Find(id);
            c.Contacts.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Contacts");    
        }
    }
}
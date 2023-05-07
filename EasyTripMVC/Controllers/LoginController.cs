using EasyTripMVC.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EasyTripMVC.Controllers
{
    public class LoginController : Controller
    {
       Context c= new Context();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin p)
        {
            var values= c.Admins.FirstOrDefault(x=>x.Username==p.Username && x.Password==p.Password);
            if (values!=null)
            {
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["Username"] = values.Username.ToString();
                return RedirectToAction("BlogIndex", "Admin");
            }
            else 
            {
                
                return View(); 
            }
           
            
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}
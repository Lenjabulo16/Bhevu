using registrationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using registrationSystem.data;

namespace registrationSystem.Controllers
{
    public class HomeController : Controller
    {
        [HandleError]
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to Bhevu High School";
            return View();
        }
       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
       
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        public ActionResult login()
        {
            return View();
        }
       // [HttpPost]
        //public ActionResult login(LoginModel login)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        if (user.FirstOrDefault() != null)
        //        {
        //            Session["UserName"] = user.FirstOrDefault().UserName;
        //            Session["UserID"] = user.FirstOrDefault().UserID;
        //            return Redirect("/home/welcomepage");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Invalid login credentials.");
        //        }
        //    }
        //    return View(login);
        //}
        //}
        
    }
}
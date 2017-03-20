using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace registrationSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HandleError]
        public ActionResult Index()
        {
            return View();
        }
      
    }
}
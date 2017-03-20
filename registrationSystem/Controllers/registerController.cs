using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace registrationSystem.Controllers
{
    public class registerController : Controller
    {
        // GET: register
        public ActionResult Index()
        {
            return View();
        }
    }
}
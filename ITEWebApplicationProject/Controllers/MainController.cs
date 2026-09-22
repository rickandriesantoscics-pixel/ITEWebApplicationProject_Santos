using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITEWebApplicationProject.Controllers
{
    public class MainController : Controller
    {
        public ActionResult LoginPage()
        {
            return View();
        }

        public ActionResult RegistrationPage()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutPage()
        {
            return View();
        }

        public ActionResult ContactPage()
        {
            return View();
        }

        // Sends data from the C# Controller to the View (consumed by AngularJS $http)
        public JsonResult GetWelcomeMessage()
        {
            return Json("Welcome to ThreadLine Clothing Store!", JsonRequestBehavior.AllowGet);
        }
    }
}

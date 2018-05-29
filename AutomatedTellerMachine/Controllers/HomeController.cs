using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HomeScreen()
        {
            return View();
        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.TheMessage = "Contact us for help navigating this site.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.Message = "Your message has been received.";

            return View();
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETBONE";
            if (letterCase=="lower")
            {
                return Content(serial.ToLower());
            }
            return Content(serial);
        }
    }
}
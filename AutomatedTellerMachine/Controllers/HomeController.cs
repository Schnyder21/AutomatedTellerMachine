using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using AutomatedTellerMachine.Models;


namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult HomeScreen()
        {
            return View();
        }
        
        [Authorize]
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var checkingAcccountId = db.CheckingAccounts.Where(c => c.ApplicationUserId == userId).First().Id;
            ViewBag.CheckingAccountId = checkingAcccountId;
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
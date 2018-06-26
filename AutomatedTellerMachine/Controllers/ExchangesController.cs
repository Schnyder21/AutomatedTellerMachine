using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutomatedTellerMachine.Models;

namespace AutomatedTellerMachine.Controllers
{
    [Authorize]
    public class ExchangesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Exchanges/deposite 
        public ActionResult Deposites(int checkingAccountId)
        {
            return View();
        }


        //store information into exchange database
        [HttpPost]
        public ActionResult Deposites(Exchanges exchanges)
        {
            if (ModelState.IsValid)
            {
                db.Exchanges.Add(exchanges);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }





    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutomatedTellerMachine.Models;

namespace AutomatedTellerMachine.Controllers
{
    public class WithdrawController : Controller
    {
        // GET: Withdraw
        public ActionResult Index()
        {
            return View();
        }

        // GET: Withdraw/Details/5
        public ActionResult Details()
        {
            var withdraw = new Withdraw { WhichAccount = "Checking", CurrentBalance = 25, RequestedAmount = 5 };
            return View(withdraw);
            
        }

        // GET: Withdraw/Create
        public ActionResult Create()
        {
            var withdraw = new Withdraw
            {
                CurrentBalance = 25
            };
            return View(withdraw);
        }

        // POST: Withdraw/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
      
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Withdraw/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Withdraw/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Withdraw/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Withdraw/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutomatedTellerMachine.Models;

namespace AutomatedTellerMachine.Services
{
    
    public class CheckingAccountService
    {
        private ApplicationDbContext db;

        public CheckingAccountService(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void CreateCheckingAccount(string firstname, string lastname, string userId, decimal initialbalance)
        {
            CheckingAccount check = new CheckingAccount();
            var accountNumber = (5150804 + db.CheckingAccounts.Count()).ToString().PadLeft(9, '0');
            var checkingAccount = new CheckingAccount
            {
                FirstName = firstname,
                LastName = lastname,
                AccountNumber =
               accountNumber,
                Balance=initialbalance,
                ApplicationUserId = userId
            };
            db.CheckingAccounts.Add(checkingAccount);
            db.SaveChanges();
        }
    }
}
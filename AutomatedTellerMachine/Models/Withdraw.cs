using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AutomatedTellerMachine.Models
{
    public class Withdraw
    {

        [DataType(DataType.Currency)]
        public decimal CurrentBalance { get; set; }



        public string WhichAccount { get; set; }

        [DataType(DataType.Currency)]
        public decimal RequestedAmount { get; set; }

        [DataType(DataType.Currency)]
        public decimal NewBalance
        {
            get
            {
                return CurrentBalance - RequestedAmount;
            }
        }

    }
}
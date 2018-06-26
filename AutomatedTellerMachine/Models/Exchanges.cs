using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AutomatedTellerMachine.Models
{
    // Set the properties for exchanges 
    public class Exchanges
    {

        public int Id { get; set;}

        [Required]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }


        [Required]
        public int CheckingAcountId { get; set; }
        public virtual CheckingAccount CheckingAccount { get; set; }
    }




    
}
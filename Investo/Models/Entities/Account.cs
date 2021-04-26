using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Investo.Models.Entities
{
    public class Account : BaseEntity
    {

        public Investor Investor { get; set; }

        public int AccountStatus { get; set; }

        public double AccountBalance { get; set; }

        //public double AmountInvested { get; set; }

        [ForeignKey("Invest Id")]
        // [Display(Name = "Investor OwnerId")]
        public int InvestorId { get; set; }

        public string InvestorAccountNumber { get; set; }




    }
}

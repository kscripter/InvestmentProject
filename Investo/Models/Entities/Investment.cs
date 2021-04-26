using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Investo.Models.Enum;

namespace Investo.Models.Entities
{
    public class Investment : BaseEntity
    {
        public InvestmentType InvestmentType { get; set; }

        // public int TotalInvestments { get; set; }

        // public double AmountInvested { get; set; }

        // public int PendingReturns { get; set; }

        // public int AmountReceived { get; set; }

        //public string DepositType { get; set; }

        public DateTime InvestmentDate { get; set; }

        // public DateTime InvestmentDueDate { get; set; }

        [ForeignKey("Invest Id")]
        //[Display(Name = "InvestorId Investments")]
        public int InvestorId { get; set; }

        // [ForeignKey("InvestorId")]
        public Investor Investor { get; set; }

        public Account Account { get; set; }

        public int AccountId { get; set; }

        public Manager Manager { get; set; }

        public int ManagerId { get; set; }


        //public ICollection<Investor> Investors { get; set; }

    }
}

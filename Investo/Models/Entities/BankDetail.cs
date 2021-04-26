using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Investo.Models.Entities
{
    public class BankDetail : BaseEntity
    {


        public Investor Investor { get; set; }

        public string AccountNumber { get; set; }

        public string AccountName { get; set; }

        public string BankName { get; set; }

        public int BankDetailId { get; set; }

        //[ForeignKey(name: "Investor BankDetails")]
        public int InvestorId { get; set; }

        //public virtual ICollection<Investor> Investors { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Investo.Models.Entities
{
    public class Investor : Details
    {





        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        public string ReferralCode { get; set; }

        public int InvestmentDuration { get; set; }

        public string InvestmentType { get; set; }

        public Account Account { get; set; }

        public BankDetail BankDetails { get; set; }

        public string Photo { get; set; }

        public IList<Investment> Investments { get; set; }




        //[DisplayName(DateTi)]
        //public DateTime GetDate { get; set; }


        // public Investment Investment { get; set; }

        // IList<History> History { get; set; }

        //  public IList<BankDetail> BankDetails { get; set; }

        //public Investor()
        //{
        //    Investments = new List<Investment>();
        //    // BankDetails = new List<BankDetail>();
        //    //History = new List<History>();

        //}


    }
}

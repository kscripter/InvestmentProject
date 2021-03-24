using System;
using System.Collections.Generic;

namespace Investo.Models.Entities
{
    public class Investor : Details
    {

        public Investor()
        {
            InvestmentTypes = new List<InvestmentType>();
        }


        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }


        public string ReferralCode { get; set; }

        public int InvestmentDuration { get; set; }

        public IList<InvestmentType> InvestmentTypes { get; set; }

        public Account Account { get; set; }


    }
}

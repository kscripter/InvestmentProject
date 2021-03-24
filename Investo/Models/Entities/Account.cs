using System;
namespace Investo.Models.Entities
{
    public class Account
    {

        public Investor Investor { get; set; }

        public int AccountStatus { get; set; }

        public int InvestorId { get; set; }

        public string AccountNumber { get; set; }


    }
}

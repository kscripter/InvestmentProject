using System;
namespace Investo.Models.Entities
{
    public class TransactionHistory : BaseEntity
    {


        public int TotalInvestment { get; set; }

        public int AmountInvested { get; set; }

        public int PendingReturns { get; set; }

        public int AmountReturned { get; set; }

        public string HistoryText { get; set; }

        public DateTime TransactionDate { get; set; }

        public int InvestorId { get; set; }



    }
}

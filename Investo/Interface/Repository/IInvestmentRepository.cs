using System;
using Investo.Models.Entities;

namespace Investo.Interface.Repository
{
    public interface IInvestmentRepository
    {



        public Investment CreateInvestments(Investment investment);
        public Investment AddTotalInvestments(Investment investment);
        public Investment FindTotalInvestmentsById(Investment investment);

        public Investment CreateAmountInvested(Investment investment);
        public Investment AddAmountInvested(Investment investment);

        public Investment CreatePendingReturns(Investment investment);
        public Investment AddPendingReturns(Investment investment);

        public Investment CreateAmountReceived(Investment investment);
        public Investment AddAmountRecieved(Investment investment);

        public Investment CreateDepositType(Investment investment);
        public Investment AddDepositType(Investment investment);





    }
}

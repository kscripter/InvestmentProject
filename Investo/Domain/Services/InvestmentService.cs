using System;
using Investo.Interface.Repository;
using Investo.Interface.Services;
using Investo.Models.Entities;

namespace Investo.Domain.Services
{
    public class InvestmentService : IInvestmentService
    {

        private readonly IInvestmentRepository _investmentRepository;

        public InvestmentService(IInvestmentRepository investmentRepository)
        {
            _investmentRepository = investmentRepository;
        }



        public Investment AddAmountInvested(Investment investment)
        {
            Investment invest = _investmentRepository.AddAmountInvested(investment);

            return invest;
        }

        public Investment AddAmountRecieved(Investment investment)
        {
            Investment invest = _investmentRepository.AddAmountRecieved(investment);

            return invest;
        }

        public Investment AddDepositType(Investment investment)
        {
            Investment invest = _investmentRepository.AddDepositType(investment);
            return invest;
        }



        public Investment AddPendingReturns(Investment investment)
        {
            Investment invest = _investmentRepository.AddPendingReturns(investment);
            return invest;
        }

        public Investment AddTotalInvestments(Investment investment)
        {
            Investment invest = _investmentRepository.AddTotalInvestments(investment);
            return invest;
        }

        public Investment CreateAmountInvested(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment CreatePendingReturns(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment CreateTotalInvestments(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment GetAmountRecieved(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment GetDepositType(Investment investment)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using Investo.Interface.Repository;
using Investo.Models.ApplicationContext;
using Investo.Models.Entities;

namespace Investo.Domain.Repository
{
    public class InvestmentRepository : IInvestmentRepository
    {

        private readonly InvestorDBContext _context;

        public InvestmentRepository(InvestorDBContext context)
        {
            _context = context;
        }




        public Investment AddAmountInvested(Investment investment)
        {
            _context.Investments.Add(investment);
            _context.SaveChanges();
            return investment;
        }

        public Investment AddAmountRecieved(Investment investment)
        {
            _context.Investments.Add(investment);
            _context.SaveChanges();
            return investment;
        }

        public Investment AddDepositType(Investment investment)
        {
            _context.Investments.Add(investment);
            _context.SaveChanges();
            return investment;
        }

        public Investment AddInvestmentDate(Investment investment)
        {
            _context.Investments.Add(investment);
            _context.SaveChanges();
            return investment;
        }

        public Investment AddInvestmentDueDate(Investment investment)
        {
            _context.Investments.Add(investment);
            _context.SaveChanges();
            return investment;
        }

        public Investment AddPendingReturns(Investment investment)
        {
            _context.Investments.Add(investment);
            _context.SaveChanges();
            return investment;
        }

        public Investment AddTotalInvestments(Investment investment)
        {
            _context.Investments.Add(investment);
            _context.SaveChanges();
            return investment;
        }

        public Investment CreateAmountInvested(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment CreateAmountReceived(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment CreateDepositType(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment CreateInvestmentDate(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment CreateInvestmentDueDate(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment CreateInvestments(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment CreatePendingReturns(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment FindTotalInvestmentsById(Investment investment)
        {
            throw new NotImplementedException();
        }
    }
}

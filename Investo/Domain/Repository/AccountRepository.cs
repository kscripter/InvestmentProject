using System;
using System.Collections.Generic;
using System.Linq;
using Investo.Interface.Repository;
using Investo.Models.ApplicationContext;
using Investo.Models.Entities;

namespace Investo.Domain.Repository
{
    public class AccountRepository : IAccountRepository
    {

        private readonly InvestorDBContext _context;

        public AccountRepository(InvestorDBContext context)
        {
            _context = context;

        }

        public bool Create(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
            return true;
        }


        public Account FindByAccountNumber(string investorAccountNumber)
        {
            return _context.Accounts.FirstOrDefault(ac => ac.InvestorAccountNumber == investorAccountNumber);
        }


    }
}

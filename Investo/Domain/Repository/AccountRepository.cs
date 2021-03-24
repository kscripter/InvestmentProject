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

        public Account FindByAccountNumber(string accountNumber)
        {
            return _context.Accounts.FirstOrDefault(ac => ac.AccountNumber == accountNumber);
        }

        public Account FindById(int id)
        {
            return _context.Accounts.FirstOrDefault(a => a.InvestorId == id);
        }

        public Account Update(Account account)
        {
            _context.Accounts.Update(account);
            _context.SaveChanges();
            return account;
        }

        public bool UpdateMultiple(List<Account> accounts)
        {
            _context.Accounts.UpdateRange(accounts);
            _context.SaveChanges();
            return true;
        }

    }
}

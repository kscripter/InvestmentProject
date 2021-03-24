using System;
using System.Collections.Generic;
using Investo.Interface.Repository;
using Investo.Interface.Services;
using Investo.Models.Entities;

namespace Investo.Domain.Services
{
    public class InvestorService : IInvestorService
    {

        private readonly IInvestorRepository _investorRepository;
        private readonly IAccountRepository _accountRepository;


        public InvestorService(IInvestorRepository investorRepository, IAccountRepository accountRepository)
        {
            _investorRepository = investorRepository;
            _accountRepository = accountRepository;
        }



        public Investor AddInvestor(Investor investor)
        {
            throw new NotImplementedException();
        }

        public bool CreateInvestor(string firstName, string middleName, string lastName, DateTime DateOfBirth, string email, string phoneNumber, string address, string password, string checkPassword)
        {
            throw new NotImplementedException();
        }

        public void DeleteInvestor(int id)
        {
            throw new NotImplementedException();
        }

        public Account FindByAccountNumber(string acccountNumber)
        {
            throw new NotImplementedException();
        }

        public List<Investor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Investor GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Investor GetInvestor(int id)
        {
            throw new NotImplementedException();
        }

        public Investor Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Account UpdateAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public Investor UpdateInvestor(Investor investor)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMultiple(List<Account> accounts)
        {
            throw new NotImplementedException();
        }
    }
}

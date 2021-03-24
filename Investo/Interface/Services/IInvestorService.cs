using System;
using System.Collections.Generic;
using Investo.Models.Entities;

namespace Investo.Interface.Services
{
    public interface IInvestorService
    {

        public bool CreateInvestor(string firstName, string middleName, string lastName, DateTime DateOfBirth, string email, string phoneNumber, string address, string password, string checkPassword);

        public Investor AddInvestor(Investor investor);

        public Investor GetInvestor(int id);

        public void DeleteInvestor(int id);

        public List<Investor> GetAll();

        public Investor UpdateInvestor(Investor investor);

        public Investor GetDetails(int id);

        public Investor Login(string username, string password);

        public Account UpdateAccount(Account account);

        public bool UpdateMultiple(List<Account> accounts);

        public Account FindByAccountNumber(string acccountNumber);




    }
}

using System;
using System.Collections.Generic;
using Investo.Models.Entities;

namespace Investo.Interface.Repository
{
    public interface IAccountRepository
    {


        public bool Create(Account account);

        public Account FindById(int id);


        public Account Update(Account account);


        public bool UpdateMultiple(List<Account> accounts);


        public Account FindByAccountNumber(string accountNumber);


    }
}

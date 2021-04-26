using System;
using System.Collections.Generic;
using Investo.Models.Entities;

namespace Investo.Interface.Repository
{
    public interface IAccountRepository
    {


        public bool Create(Account account);




        public Account FindByAccountNumber(string investorAccountNumber);


    }
}

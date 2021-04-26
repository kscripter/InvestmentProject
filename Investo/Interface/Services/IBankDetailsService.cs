using System;
using System.Collections.Generic;
using Investo.Models.Entities;

namespace Investo.Interface.Services
{
    public interface IBankDetailsService
    {

        public BankDetail GetBankDetails(Investor investor);


    }
}

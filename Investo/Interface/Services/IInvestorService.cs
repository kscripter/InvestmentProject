using System;
using System.Collections.Generic;
using Investo.Models.Entities;

namespace Investo.Interface.Services
{
    public interface IInvestorService
    {

        public Investor AddInvestor(Investor investor);


        public Investor GetInvestor(int id);


        public void DeleteInvestor(int id);


        public List<Investor> GetAll();


        public Investor UpdateInvestor(Investor investor);

        public Investor Login(string username, string password);

        public Investor GetDetails(int id);




    }
}

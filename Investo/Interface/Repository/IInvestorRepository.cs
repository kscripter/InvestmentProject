using System;
using System.Collections.Generic;
using Investo.Models.Entities;

namespace Investo.Interface.Repository
{
    public interface IInvestorRepository
    {

        public int CreateInvestor(Investor investor);



        public Investor FindByEmail(string email);

        public Investor GetDetails(int id);

        public Investor GetInvestor(int id);

        public Investor FindById(int id);
        public Investor AddInvestor(Investor investor);


        public List<Investor> GetAll();

        public void DeleteInvestor(int id);

        public Investor UpdateInvestor(Investor investor);




    }
}

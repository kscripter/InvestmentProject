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


        public InvestorService(IInvestorRepository investorRepository)
        {
            _investorRepository = investorRepository;
        }



        protected string GenerateInvestorAccountNumber()
        {
            Random random = new Random();

            string firstFive = random.Next(1, 10000).ToString("00000");
            string secondFive = random.Next(1, 10000).ToString("00000");

            string generatedNumber = $"{firstFive}{secondFive}";

            return generatedNumber;
        }


        protected string GenerateInvestorReferralCode()
        {
            Random random = new Random();

            string firstFive = random.Next(1, 10000).ToString("00000");
            string secondFive = random.Next(1, 10000).ToString("00000");

            string generatedCode = $"{firstFive}{secondFive}";

            return generatedCode;
        }



        public Investor GetInvestor(int id)
        {
            return _investorRepository.GetInvestor(id);
        }



        public Investor GetDetails(int id)
        {
            return _investorRepository.GetDetails(id);
        }


        public void DeleteInvestor(int id)
        {
            _investorRepository.DeleteInvestor(id);
        }


        public List<Investor> GetAll()
        {
            return _investorRepository.GetAll();
        }


        public Investor UpdateInvestor(Investor investor)
        {
            return _investorRepository.UpdateInvestor(investor);
        }



        public Investor AddInvestor(Investor investor)
        {
            Investor invest = _investorRepository.AddInvestor(investor);

            return invest;
        }


        public Investor Login(string username, string password)
        {
            var investor = _investorRepository.FindByEmail(username);
            if (investor == null || investor.Password != password)
            {
                return null;
            }

            return investor;
        }

    }
}

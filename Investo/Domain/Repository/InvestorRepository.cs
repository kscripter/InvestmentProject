using System;
using System.Collections.Generic;
using System.Linq;
using Investo.Interface.Repository;
using Investo.Models.ApplicationContext;
using Investo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Investo.Domain.Repository
{
    public class InvestorRepository : IInvestorRepository
    {

        private readonly InvestorDBContext _context;

        public InvestorRepository(InvestorDBContext context)
        {
            _context = context;
        }


        public Investor UpdateInvestor(Investor investor)
        {
            _context.Investors.Update(investor);
            _context.SaveChanges();
            return investor;
        }


        public List<Investor> GetAll()
        {
            return _context.Investors.ToList();
        }




        public int CreateInvestor(Investor investor)
        {
            try
            {
                _context.Investors.Add(investor);
                _context.SaveChanges();
                return investor.Id;
            }
            catch (Exception ea)
            {
                Console.WriteLine($"err2: {ea.Message}");
            }

            return 0;

        }


        public Investor FindByEmail(string email)
        {
            var investor = _context.Investors
            .Where(inv => inv.Email == email)
            .Include(inv => inv.Account).FirstOrDefault();
            return investor;
        }



        public Investor FindById(int id)
        {
            return _context.Investors.FirstOrDefault(i => i.Id == id);

        }

        public Investor Update(Investor investor)
        {
            _context.Investors.Update(investor);
            _context.SaveChanges();
            return investor;
        }

        public Investor GetDetails(int id)
        {
            var investor = _context.Investors
                .Where(inv => inv.Id == id)
                //.Include(h => h.History)
                .Include(inv => inv.Account).FirstOrDefault();
            return investor;
        }


        public void DeleteInvestor(int id)
        {
            var investor = _context.Investors.Find(id);
            _context.Remove(investor);
            _context.SaveChanges();
        }

        public Investor GetInvestor(int id)
        {
            return _context.Investors.Find(id);

        }

        public Investor AddInvestor(Investor investor)
        {
            throw new NotImplementedException();
        }

        //public Investor FindByHistory(int id)
        //{
        //    var accountHolder = _context.Investors
        //     .Where(inv => inv.Id == id)
        //        .Include(inv => inv.History).FirstOrDefault();
        //    return accountHolder;
        //}


    }


}

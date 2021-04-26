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



        public void DeleteInvestor(int id)
        {
            var investor = _context.Investors.Find(id);
            _context.Remove(investor);
            _context.SaveChanges();
        }



        public Investor AddInvestor(Investor investor)
        {
            _context.Investors.Add(investor);
            _context.SaveChanges();
            return investor;
        }

        public Investor FindByEmail(string email)
        {
            return _context.Investors.FirstOrDefault(e => e.Email == email);
        }

        public Investor FindById(int id)
        {
            return _context.Investors.FirstOrDefault(i => i.Id == id);
        }

        public List<Investor> GetAll()
        {
            return _context.Investors.ToList();
        }

        public Investor GetDetails(int id)
        {
            var investor = _context.Investors
                .Where(ach => ach.Id == id)
                .Include(ach => ach.Account).FirstOrDefault();
            return investor;
        }

        public Investor GetInvestor(int id)
        {
            return _context.Investors.Find(id);
        }



        public Investor UpdateInvestor(Investor investor)
        {
            _context.Investors.Update(investor);
            _context.SaveChanges();
            return investor;
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
                Console.WriteLine($"error: {ea.Message}");
            }
            return 0;
        }
    }


}

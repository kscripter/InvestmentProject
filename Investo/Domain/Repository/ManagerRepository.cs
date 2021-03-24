using System;
using System.Collections.Generic;
using Investo.Interface.Repository;
using Investo.Models.ApplicationContext;
using Investo.Models.Entities;

namespace Investo.Domain.Repository
{
    public class ManagerRepository : IManagerRepository
    {

        private readonly InvestorDBContext _context;


        public ManagerRepository(InvestorDBContext context)
        {
            _context = context;
        }



        public Manager AddAccountManager(Manager manager)
        {
            throw new NotImplementedException();
        }

        public int CreateManager(Manager manager)
        {
            throw new NotImplementedException();
        }

        public void DeleteManager(int id)
        {
            throw new NotImplementedException();
        }

        public Manager FindByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Manager FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Manager> GetAll()
        {
            throw new NotImplementedException();
        }

        public Manager GetManager(int id)
        {
            throw new NotImplementedException();
        }

        public Manager Update(Manager manager)
        {
            throw new NotImplementedException();
        }

        public Manager UpdateManager(Manager manager)
        {
            throw new NotImplementedException();
        }
    }
}

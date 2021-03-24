using System;
using System.Collections.Generic;
using Investo.Interface.Repository;
using Investo.Interface.Services;
using Investo.Models.Entities;

namespace Investo.Domain.Services
{
    public class ManagerService : IManagerService
    {


        private readonly IManagerRepository _managerRepository;


        public ManagerService(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }



        public Manager AddManager(IManagerService manager)
        {
            throw new NotImplementedException();
        }

        public bool CreateManager(string firstName, string middleName, string lastName, string email, string password, string checkPassword)
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

        public Manager UpdateManager(Manager manager)
        {
            throw new NotImplementedException();
        }
    }
}

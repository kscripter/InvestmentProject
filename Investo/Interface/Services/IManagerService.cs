using System;
using System.Collections.Generic;
using Investo.Models.Entities;

namespace Investo.Interface.Services
{
    public interface IManagerService
    {

        public bool CreateManager(string firstName, string middleName, string lastName, string email, string password, string checkPassword);

        public Manager AddManager(IManagerService manager);

        public Manager GetManager(int id);

        public List<Manager> GetAll();

        public Manager UpdateManager(Manager manager);

    }
}

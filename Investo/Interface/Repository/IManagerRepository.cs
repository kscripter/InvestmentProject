using System;
using System.Collections.Generic;
using Investo.Models.Entities;

namespace Investo.Interface.Repository
{
    public interface IManagerRepository
    {

        public int CreateManager(Manager manager);

        public Manager AddAccountManager(Manager manager);

        public Manager FindByEmail(string email);

        public Manager FindById(int id);

        public Manager Update(Manager manager);

        public Manager GetManager(int id);

        public List<Manager> GetAll();

        public void DeleteManager(int id);

        public Manager UpdateManager(Manager manager);


    }
}

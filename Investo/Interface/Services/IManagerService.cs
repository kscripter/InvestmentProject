using System;
using System.Collections.Generic;
using Investo.Models.Entities;

namespace Investo.Interface.Services
{
    public interface IManagerService
    {


        public Manager AddManager(Manager manager);

        public Manager Update(Manager manager);

        public Manager Login(string username, string password);

        public List<Manager> GetAll();

        public void DeleteManager(int id);

        public Manager GetManager(int id);



    }
}

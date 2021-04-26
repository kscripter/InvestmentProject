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


        public Manager AddManager(Manager manager)
        {
            Manager manage = _managerRepository.AddManager(manager);
            return manage;
        }

        public void DeleteManager(int id)
        {
            _managerRepository.DeleteManager(id);
        }

        public List<Manager> GetAll()
        {
            return _managerRepository.GetAll();
        }

        public Manager GetManager(int id)
        {
            return _managerRepository.GetManager(id);
        }

        public Manager Login(string username, string password)
        {
            var manager = _managerRepository.FindByEmail(username);
            if (manager == null || manager.Password != password)
            {
                return null;
            }

            return manager;
        }

        public Manager Update(Manager manager)
        {
            return _managerRepository.Update(manager);
        }





    }
}

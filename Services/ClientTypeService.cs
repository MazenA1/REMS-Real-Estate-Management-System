using Interfaces;
using Models;
using System.Collections.Generic;

namespace Services
{
    public class ClientTypeService
    {
        private readonly IClientTypeRepository _repo;

        public ClientTypeService(IClientTypeRepository repo)
        {
            _repo = repo;
        }

        public List<ClientType> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
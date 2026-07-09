using Interfaces;
using Models;
using System.Collections.Generic;

namespace Services
{
    public class ManagementCommissionTypeService : IManagementCommissionTypeService
    {
        private readonly IManagementCommissionTypeRepository _repository;

        public ManagementCommissionTypeService(
            IManagementCommissionTypeRepository repository)
        {
            _repository = repository;
        }

        public List<ManagementCommissionType> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
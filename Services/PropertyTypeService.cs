using Interfaces;
using Models;
using System.Collections.Generic;

namespace Services
{
    public class PropertyTypeService : IPropertyTypeService
    {
        private readonly IPropertyTypeRepository _propertyTypeRepository;

        public PropertyTypeService(IPropertyTypeRepository propertyTypeRepository)
        {
            _propertyTypeRepository = propertyTypeRepository;
        }

        public List<PropertyType> GetAll()
        {
            return _propertyTypeRepository.GetAll();
        }
    }
}
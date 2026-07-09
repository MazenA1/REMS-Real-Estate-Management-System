using Interfaces;
using Models;
using System;
using System.Collections.Generic;

namespace Services
{
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository _propertyRepository;

        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        private bool _AddProperty(Property property)
        {
            int propertyID = _propertyRepository.Add(property);

            if (propertyID != -1)
            {
                property.PropertyID = propertyID;
                property.Mode = Property.enMode.Update;
                return true;
            }

            return false;
        }

        private bool _UpdateProperty(Property property)
        {
            return _propertyRepository.Update(property);
        }

        public bool Save(Property property)
        {
            if (property == null)
                return false;

            switch (property.Mode)
            {
                case Property.enMode.AddNew:
                    return _AddProperty(property);

                case Property.enMode.Update:
                    return _UpdateProperty(property);
            }

            return false;
        }

        public bool Delete(int propertyID)
        {
            return _propertyRepository.Delete(propertyID);
        }

        public Property GetByID(int propertyID)
        {
            return _propertyRepository.GetByID(propertyID);
        }

        public Property GetByCode(Guid propertyCode)
        {
            return _propertyRepository.GetByCode(propertyCode);
        }

        public List<Property> GetAll()
        {
            return _propertyRepository.GetAll();
        }

        public bool Exists(int propertyID)
        {
            return _propertyRepository.Exists(propertyID);
        }
    }
}
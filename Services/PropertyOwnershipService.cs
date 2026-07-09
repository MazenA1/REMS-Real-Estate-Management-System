using Interfaces;
using Models;
using System.Collections.Generic;

namespace Services
{
    public class PropertyOwnershipService : IPropertyOwnershipService
    {
        private readonly IPropertyOwnershipRepository _repository;

        public PropertyOwnershipService(IPropertyOwnershipRepository repository)
        {
            _repository = repository;
        }

        private bool _Add(PropertyOwnership ownership)
        {
            int id = _repository.Add(ownership);

            if (id != -1)
            {
                ownership.PropertyOwnershipID = id;
                ownership.Mode = PropertyOwnership.enMode.Update;
                return true;
            }

            return false;
        }

        private bool _Update(PropertyOwnership ownership)
        {
            return _repository.Update(ownership);
        }

        public bool Save(PropertyOwnership ownership)
        {
            if (ownership == null)
                return false;

            switch (ownership.Mode)
            {
                case PropertyOwnership.enMode.AddNew:
                    return _Add(ownership);

                case PropertyOwnership.enMode.Update:
                    return _Update(ownership);
            }

            return false;
        }

        public bool Delete(int propertyOwnershipID)
        {
            return _repository.Delete(propertyOwnershipID);
        }

        public PropertyOwnership GetByID(int propertyOwnershipID)
        {
            return _repository.GetByID(propertyOwnershipID);
        }

        public List<PropertyOwnership> GetByPropertyID(int propertyID)
        {
            return _repository.GetByPropertyID(propertyID);
        }

        public List<PropertyOwnership> GetByOwnerID(int ownerID)
        {
            return _repository.GetByOwnerID(ownerID);
        }

        public List<PropertyOwnership> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Exists(int propertyOwnershipID)
        {
            return _repository.Exists(propertyOwnershipID);
        }
    }
}
using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IPropertyOwnershipRepository
    {
        int Add(PropertyOwnership ownership);
        bool Update(PropertyOwnership ownership);
        bool Delete(int propertyOwnershipID);

        PropertyOwnership GetByID(int propertyOwnershipID);
        List<PropertyOwnership> GetByPropertyID(int propertyID);
        List<PropertyOwnership> GetByOwnerID(int ownerID);
        List<PropertyOwnership> GetAll();

        bool Exists(int propertyOwnershipID);
    }
}
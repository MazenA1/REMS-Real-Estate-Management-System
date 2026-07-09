using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IPropertyRepository
    {
        int Add(Property property);
        bool Update(Property property);
        bool Delete(int propertyID);

        Property GetByID(int propertyID);
        Property GetByCode(System.Guid propertyCode);

        List<Property> GetAll();

        bool Exists(int propertyID);
    }
}
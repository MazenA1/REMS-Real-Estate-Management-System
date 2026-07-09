using Models;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IPropertyService
    {
        bool Save(Property property);
        bool Delete(int propertyID);

        Property GetByID(int propertyID);
        Property GetByCode(Guid propertyCode);

        List<Property> GetAll();

        bool Exists(int propertyID);
    }
}
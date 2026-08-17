using Models;
using Models.DTOs;
using System.Collections.Generic;
using System.ComponentModel;

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
        BindingList<InvestorPreferredPropertyTypeDTO> GetPropertyTypesWithPropertiesCount();

        bool Exists(int propertyID);
    }
}
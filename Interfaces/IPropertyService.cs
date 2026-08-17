using Models;
using Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Interfaces
{
    public interface IPropertyService
    {
        bool Save(Property property);
        bool Delete(int propertyID);

        Property GetByID(int propertyID);
        Property GetByCode(Guid propertyCode);

        List<Property> GetAll();
        BindingList<InvestorPreferredPropertyTypeDTO> GetPropertyTypesWithPropertiesCount();

        bool Exists(int propertyID);
    }
}
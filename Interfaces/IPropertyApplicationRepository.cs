using Models;
using Models.FormData;
using System.Collections.Generic;
using System.Data;

namespace Interfaces
{
    public interface IPropertyApplicationRepository
    {
        int Add(PropertyRegistrationData propertyInfo);

    }
} 

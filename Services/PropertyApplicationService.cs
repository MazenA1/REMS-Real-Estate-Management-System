using Interfaces;
using Models;
using Models.FormData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PropertyApplicationService : IPropertyApplicationService
    {
        private readonly IPropertyApplicationRepository _propertyApplicationRepository;
        public PropertyApplicationService(IPropertyApplicationRepository propertyApplicationRepository)
        {
            this._propertyApplicationRepository = propertyApplicationRepository;
        }

        public int Add(PropertyRegistrationData PropertyInfo)
        {
            return _propertyApplicationRepository.Add(PropertyInfo);
        }
        public bool Save()
        {
            return false;
        }
        

    }
}

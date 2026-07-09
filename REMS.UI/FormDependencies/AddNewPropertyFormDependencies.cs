using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMS.UI.FormDependencies
{
    public class AddNewPropertyFormDependencies
    {
        public IPropertyTypeService PropertyTypeService { get; set; }
        public ICityService CityService { get; set; }
        public IDistrictService DistrictService { get; set; }
        public IManagementCommissionTypeService ManagementCommissionTypeService { get; set; }
        public IPropertyApplicationService PropertyApplicationService { get; set; }

        public AddEditClientFormDependencies ClientFormDeps { get; set; }
    }
}

using REMS.UI.Form_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITenantRegistrationRepository
    {
        int Add(TenantRegistrationData data); 
    }
}

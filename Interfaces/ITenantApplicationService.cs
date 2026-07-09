using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REMS.UI.Form_Models;

namespace Interfaces
{
    public interface ITenantApplicationService
    {
        bool RegisterTenant(TenantFormData data);
    }
}

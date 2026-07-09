using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REMS.UI.Form_Models;

namespace Services
{
    public class TenantApplicationService : ITenantApplicationService
    {
        private readonly IClientRoleService _clientRoleService;
        private readonly ITenantService _tenantService;

        public TenantApplicationService(
            IClientRoleService clientRoleService,
            ITenantService tenantService)
        {
            _clientRoleService = clientRoleService;
            _tenantService = tenantService;
        }
        public bool RegisterTenant(TenantFormData data)
        {
            if (data == null || data.ClientRole == null || data.Tenant == null)
                return false;

            if (!_clientRoleService.Save(data.ClientRole))
                return false;

            data.Tenant.ClientRoleID = data.ClientRole.ClientRoleID;

            return _tenantService.Save(data.Tenant);
        }
    }
}

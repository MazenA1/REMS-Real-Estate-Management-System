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
        private readonly ITenantRegistrationRepository _repository;

        public event Action<Tenant> TenantRegistered;

        public TenantApplicationService(
            ITenantRegistrationRepository repository)
        {
            _repository = repository;
        }

        public bool Register(TenantRegistrationData data)
        {
            if (data == null)
                return false;

            if (data.ClientRole == null)
                return false;

            if (data.Tenant == null)
                return false;

            int clientRoleID = _repository.Add(data);

            if (clientRoleID <= 0)
                return false;

            data.Tenant.ClientRoleID = clientRoleID;

            TenantRegistered?.Invoke(data.Tenant);

            return true;
        }
    }
}

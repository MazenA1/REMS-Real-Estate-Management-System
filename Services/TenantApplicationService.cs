using Interfaces;
using Models;
using Models.DTOs;
using Models.Events;
using REMS.UI.Form_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TenantApplicationService : ITenantApplicationService
    {
        private readonly ITenantRegistrationRepository _repository;

        public event EventHandler<TenantRegisteredEventArgs> TenantRegistered;

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

            if (clientRoleID >= 0)
            {
                TenantRegistered?.Invoke(this, new TenantRegisteredEventArgs(GetClientListItemByClientRoleID(clientRoleID)));
                 
                return true;
            }

            return false ;
        }

        public TenantListDTO GetClientListItemByClientRoleID(int ClientRoleID)
        {
            return this._repository.GetClientListItemByClientRoleID(ClientRoleID); 
        }
        
    }
}

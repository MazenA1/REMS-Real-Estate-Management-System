using Interfaces;
using Models;
using Models.FormData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OwnerApplicationServics : IOwnerApplicationService
    {
        private readonly IClientRoleService _clientRoleService;
        private readonly IOwnerService _ownerService; 

        public OwnerApplicationServics(IClientRoleService clientRoleService, IOwnerService ownerService)
        {
            this._clientRoleService = clientRoleService;
            this._ownerService = ownerService;
        }
        public bool RegisterOwner(OwnerFormData data)
        {
            if (data == null || data.ClientRole == null || data.Owner == null)
                return false;

            if (!_clientRoleService.Save(data.ClientRole))
                return false;

            data.Owner.ClientRoleID = data.ClientRole.ClientRoleID;

            return _ownerService.Save(data.Owner);
        }
    }
}

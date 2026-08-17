using Interfaces;
using Models;
using Models.DTOs;
using Models.Events;
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
        private readonly IOwnerRegistrationRepository _repository; 


        public event EventHandler<OwnerRegisteredEventArgs> OwnerRegistered;

        public OwnerApplicationServics(IOwnerRegistrationRepository _repository)
        {
            this._repository = _repository;
        }
        public bool RegisterOwner(OwnerFormData data)
        {
            if (data == null)
                return false;

            if (data.ClientRole == null)
                return false;

            if (data.Owner == null)
                return false;

            if (_repository.Add(data))
            {

                OwnerRegistered?.Invoke(this, new OwnerRegisteredEventArgs(GetClientListItemByClientRoleID(data.ClientRole.ClientRoleID)));

                return true;
            }

            return false;
        }

        public OwnersListDTO GetClientListItemByClientRoleID(int ClientRoleID)
        {
            return this._repository.GetClientListItemByClientRoleID(ClientRoleID); 
        }


    }
}

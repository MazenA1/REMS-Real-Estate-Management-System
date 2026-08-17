using Models.DTOs;
using Models.Events;
using Models.FormData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IOwnerApplicationService
    {
        event EventHandler<OwnerRegisteredEventArgs> OwnerRegistered; 
        bool RegisterOwner(OwnerFormData Data);
        OwnersListDTO GetClientListItemByClientRoleID(int ClientRoleID);

    }
}

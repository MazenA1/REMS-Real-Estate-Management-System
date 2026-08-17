using Models.DTOs;
using Models.Events;
using REMS.UI.Form_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITenantApplicationService
    {
        event EventHandler<TenantRegisteredEventArgs> TenantRegistered;

        TenantListDTO GetClientListItemByClientRoleID(int ClientRoleID);

        bool Register(TenantRegistrationData data);
    }
}

using Models.DTOs;
using Models.FormData;
using REMS.UI.Form_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IOwnerRegistrationRepository 
    {
        bool Add(OwnerFormData data);
        OwnersListDTO GetClientListItemByClientRoleID(int ClientRoleID); 
    }
}

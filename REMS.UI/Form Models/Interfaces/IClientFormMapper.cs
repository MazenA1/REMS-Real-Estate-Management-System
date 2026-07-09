using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMS.UI.Form_Models.Interfaces
{
    public interface IClientFormMapper
    {
        Models.Client MapToClient(ClientFormData data, Models.Client Client = null);  

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REMS.UI.Form_Models.Interfaces;

namespace REMS.UI.Form_Models.Services
{
    public class ClientFormMapper : IClientFormMapper
    {
        public Models.Client MapToClient(ClientFormData Data, Models.Client client = null)
        {
            if (Data == null)
                return null;

            if (client == null)
                client = new Models.Client();

            client.Mode = Data.ClientInfo.Mode;
            client.ClientID = Data.ClientInfo.ClientID;
            client.PersonID = Data.ClientInfo.PersonID;
            client.ClientTypeID = Data.ClientInfo.ClientTypeID;
            client.CreatedByUserID = Data.ClientInfo.CreatedByUserID;
            client.CreatedDate = Data.ClientInfo.CreatedDate;
            client.IsActive = Data.ClientInfo.IsActive;
            client.Notes = Data.ClientInfo.Notes;

            return client;
        }
    } 
}

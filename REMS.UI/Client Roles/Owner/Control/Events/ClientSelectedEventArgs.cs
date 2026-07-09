using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMS.UI.Client_Roles.Owner.Control.Events
{
    public class ClientSelectedEventArgs
    {
        public Client clientInfo {  get; set; }

        public ClientSelectedEventArgs(Client client)
        {
            this.clientInfo = client;
        }
    }
}

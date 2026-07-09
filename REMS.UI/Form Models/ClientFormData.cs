using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMS.UI.Form_Models
{
    public class ClientFormData
    {
        public Client ClientInfo { get; set; }

        public ClientFormData()
        {
            ClientInfo = new Client();
        }
    }
}

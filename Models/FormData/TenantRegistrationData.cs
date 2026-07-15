using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMS.UI.Form_Models
{
    public class TenantRegistrationData
    {

        public ClientRole ClientRole { get; set; }
        public Tenant Tenant { get; set; }

        public TenantRegistrationData()
        {
            ClientRole = new ClientRole();
            Tenant = new Tenant();
        }
    }
}
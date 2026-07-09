using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMS.UI.Form_Models
{
    public class TenantFormData
    {

        public ClientRole ClientRole { get; set; }
        public Tenant Tenant { get; set; }

        public TenantFormData()
        {
            ClientRole = new ClientRole();
            Tenant = new Tenant();
        }
    }
}
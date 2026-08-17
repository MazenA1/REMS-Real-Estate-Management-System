using Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Events
{
    public class TenantRegisteredEventArgs : EventArgs
    {
        public TenantListDTO Tenant { get; }

        public TenantRegisteredEventArgs(TenantListDTO tenant)
        {
            this.Tenant = tenant;
        }
    }
}

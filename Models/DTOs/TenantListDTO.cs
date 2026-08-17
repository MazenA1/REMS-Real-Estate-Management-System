using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class TenantListDTO 
    {
        public string TenantFullName { get; set; }
        public string TenantPhoneNumber { get; set; }
        public string TenantNationalNo { get; set; }
        public decimal TenantOpeningBalance { get; set; }
    }
}

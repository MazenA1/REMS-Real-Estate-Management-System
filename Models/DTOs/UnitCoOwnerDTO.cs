using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class UnitCoOwnerDTO 
    {
        public int PersonID { get; set; }
        public int ClientID { get; set; }
        public string FullName { get; set; }
        public string NationalNo { get; set; }
        public string PhoneNumber { get; set; }
        public string DeedNumber { get; set; }
        public decimal OwnershipPercentage { get; set; }
    }
}

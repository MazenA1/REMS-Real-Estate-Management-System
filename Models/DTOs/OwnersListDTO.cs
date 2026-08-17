using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class OwnersListDTO
    {
        public string OwnerFullName { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public string OwnerNationalNo { get; set; }
        public decimal OwnerOpeningBalance { get; set; } 
    }
}

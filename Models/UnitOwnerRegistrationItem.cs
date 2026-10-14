using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UnitOwnerRegistrationItem
    {
        public int PersonID { get; set; }
        public Person PersonInfo { get; set; }
        public int ClientID { get; set; }
        public decimal OwnershipPercentage { get; set; }

        public bool IsPrimaryOwner { get; set; }

        public string DeedNumber { get; set; }

        public DateTime? DeedDate { get; set; }

        public string Notes { get; set; }
    }
}

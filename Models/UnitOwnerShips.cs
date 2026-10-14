using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UnitOwnership
    {
        public int UnitOwnershipID { get; set; }

        public int UnitID { get; set; }

        public int UnitOwnerID { get; set; }

        public decimal OwnershipPercentage { get; set; }

        public string DeedNumber { get; set; }

        public DateTime? DeedDate { get; set; }

        public DateTime OwnershipStartDate { get; set; }

        public DateTime? OwnershipEndDate { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedByUserID { get; set; }

        public string Notes { get; set; }
    }
}

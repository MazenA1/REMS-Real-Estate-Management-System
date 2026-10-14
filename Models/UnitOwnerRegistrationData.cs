using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UnitOwnerRegistrationData
    {
        public int UnitID { get; set; }

        public DateTime OwnershipStartDate { get; set; }

        public int CreatedByUserID { get; set; }

        public List<UnitOwnerRegistrationItem> Owners { get; set; }
            = new List<UnitOwnerRegistrationItem>();
    }
}

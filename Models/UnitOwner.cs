using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UnitOwner
    {
        public int UnitOwnerID { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedByUserID { get; set; }

        public bool IsActive { get; set; }

        public string Notes { get; set; }
    }
}

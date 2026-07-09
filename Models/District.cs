using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class District
    {
        public int DistrictID { get; set; }

        public int CityID { get; set; }

        public string DistrictNameTurkish { get; set; }

        public bool IsActive { get; set; }
    }
}

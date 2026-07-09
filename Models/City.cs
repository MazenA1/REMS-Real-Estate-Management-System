using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class City
    {
        public int CityID { get; set; }
        public string CityNameArabic { get; set; }
        public string CityNameTurkish { get; set; }
        public int PlateCode { get; set; }
        public bool IsActive { get; set; }
    }
}

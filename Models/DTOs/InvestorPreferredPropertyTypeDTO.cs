using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class InvestorPreferredPropertyTypeDTO 
    {
        public short PropertyTypeID { get; set; } 

        public string PropertyTypeName { get; set; }

        public int PropertiesCount { get; set; }

        public bool Selected { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class UnitSelectionDTO
    {
        public int UnitID { get; set; }

        public string UnitNumber { get; set; }

        public byte UnitTypeID { get; set; }

        public string UnitTypeName { get; set; }

        public int BuildingID { get; set; }

        public string BuildingNumber { get; set; }

        public string BuildingName { get; set; }

        public short? FloorNumber { get; set; }

        public decimal? Area { get; set; }

        public bool IsActive { get; set; }
    }
}

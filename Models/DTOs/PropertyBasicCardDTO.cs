using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class PropertyBasicInfoDTO
    {
        public int PropertyID { get; set; }

        public Guid PropertyCode { get; set; }

        public string PropertyName { get; set; }

        public short? BuildingYear { get; set; }

        public decimal? Area { get; set; }

        public string CityName { get; set; }

        public string DistrictName { get; set; }

        public string ManagementCommissionTypeName { get; set; }

        public decimal? ManagementCommissionValue { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedByUserName { get; set; }

        public string TaxTypeName { get; set; }

        public bool IsSubjectToVAT { get; set; }

        public bool IsActive { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}

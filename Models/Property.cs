using System;

namespace Models
{
    public class Property
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode { get; set; } = enMode.AddNew;

        public int PropertyID { get; set; }
        public Guid PropertyCode { get; set; }

        public string PropertyName { get; set; }
        public int PropertyTypeID { get; set; }

        public string Address { get; set; }
        public int CityID { get; set; }
        public int DistrictID { get; set; }

        public decimal? Area { get; set; }
        public short? BuildingYear { get; set; }
        public string Description { get; set; }

        public decimal? ManagementCommissionValue { get; set; }
        public int ManagementCommissionTypeID { get; set; }
        public bool IsSubjectToVAT { get; set; }

        public DateTime CreatedDate { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
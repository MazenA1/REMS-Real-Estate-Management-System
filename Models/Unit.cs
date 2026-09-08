using System;

namespace Models.Entities
{
    public class Unit
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        public enMode Mode { get; set; } = enMode.AddNew;

        public int UnitID { get; set; }

        public int BuildingID { get; set; }

        public Guid UnitCode { get; set; }

        public string UnitNumber { get; set; }

        public byte UnitTypeID { get; set; }

        public short? FloorNumber { get; set; }

        public decimal? Area { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedByUserID { get; set; }

        public string Notes { get; set; }
    }
}
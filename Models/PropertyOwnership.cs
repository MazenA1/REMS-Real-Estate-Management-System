using System;

namespace Models
{
    public class PropertyOwnership
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode { get; set; } = enMode.AddNew;

        public int PropertyOwnershipID { get; set; }

        public int PropertyID { get; set; }
        public int OwnerID { get; set; }

        public string DeedNumber { get; set; }
        public DateTime? DeedDate { get; set; }

        public string LandNumber { get; set; }

        public int? OwnershipStatusID { get; set; }

        public string DeedImagePath { get; set; }

        public decimal OwnershipPercentage { get; set; } = 100;

        public DateTime CreatedDate { get; set; }

        public int CreatedByUserID { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsPrimaryOwner { get; set; }
    }
}
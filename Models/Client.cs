using System;

namespace Models
{
    public class Client
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode { get; set; } = enMode.AddNew;
        public int ClientID { get; set; }
        public int PersonID { get; set; }
        public int ClientTypeID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByUserID { get; set; }
        public byte IsActive { get; set; }
        public string Notes { get; set; }
    }
}
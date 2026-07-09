using System;

namespace Models
{
    public class ClientRole
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode { get; set; } = enMode.AddNew;

        public int ClientRoleID { get; set; }
        public int ClientID { get; set; }
        public byte ClientRoleTypeID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByUserID { get; set; }
        public byte IsActive { get; set; }
        public string Notes { get; set; }
    }
}
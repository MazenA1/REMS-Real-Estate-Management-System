using System;

namespace Models
{
    public class Tenant
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enum enBalanceType
        {
            Debtor = 0,
            Creditor = 1
        }
        public enMode Mode { get; set; } = enMode.AddNew;

        public int TenantID { get; set; }

        public string RepresentativeName { get; set; }
        public string RepresentativeNationalID { get; set; }
        public DateTime? RepresentativeDate { get; set; }

        public string AgencyNumber { get; set; }
        public DateTime? AgencyDate { get; set; }

        public int? NationalityID { get; set; }

        public int ClientRoleID { get; set; }

        public string NameOfConductor { get; set; }

        public decimal? OpeningBalance { get; set; }

        public DateTime CreationDate { get; set; }
        public enBalanceType MovementType { get; set; } 

        public byte TenantEvaluation { get; set; }
    }
}
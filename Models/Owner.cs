using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Owner
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode { get; set; } = enMode.AddNew;
        public enum enBalanceType
        {
            Debtor = 0,
            Creditor = 1
        }
        public int OwnerID { get; set; }
        public int ClientRoleID { get; set; }

        public string RepresentativeName { get; set; }
        public string RepresentativeNationalID { get; set; }
        public string RepresentativePhone { get; set; }
        public DateTime? RepresentativeDateOfBirth { get; set; }

        public string AgencyNumber { get; set; }
        public DateTime? AgencyDate { get; set; }

        public int? NationalityID { get; set; }

        public string NameOfConductor { get; set; }

        public decimal? OpeningBalance { get; set; }

        public DateTime CreationDate { get; set; }

        public enBalanceType MovementType { get; set; } 

        public int CreatedByUserID { get; set; }
    }
}

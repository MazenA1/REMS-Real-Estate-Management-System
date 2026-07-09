using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class OwnerCardDTO
    {
        public int OwnerID { get; set; }
        public int ClientRoleID { get; set; }
        public int ClientID { get; set; }
        public int PersonID { get; set; }

        public string OwnerName { get; set; }
        public string OwnerNationalNo { get; set; }
        public string OwnerPhone { get; set; }

        public string RepresentativeName { get; set; }
        public string RepresentativeNationalID { get; set; }
        public string RepresentativePhone { get; set; }
        public DateTime? RepresentativeDateOfBirth { get; set; }
        public DateTime CreationDate {  get; set; }
        public string AgencyNumber { get; set; }
        public DateTime? AgencyDate { get; set; }

        public int? NationalityID { get; set; }
        public string NameOfConductor { get; set; }

        public decimal? OpeningBalance { get; set; }
        public Owner.enBalanceType MovementType { get; set; }

        public int CreatedByUserID { get; set; }
    }
}

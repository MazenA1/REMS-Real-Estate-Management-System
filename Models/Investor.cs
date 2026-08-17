using System;

namespace Models.Entities
{
    public class Investor
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        public enMode Mode { get; set; } = enMode.AddNew;

        public int InvestorID { get; set; }

        public int ClientRoleID { get; set; }

        public decimal? MinimumBudget { get; set; }

        public decimal? MaximumBudget { get; set; }

        public byte PaymentMethodID { get; set; }

        public byte InvestmentPurposeID { get; set; }

        public byte InterestLevelID { get; set; }

        public decimal? OpeningBalance { get; set; }

        public bool ReadyToInvest { get; set; }

        public string RepresentativeName { get; set; }

        public string RepresentativeNationalID { get; set; }

        public string AgencyNumber { get; set; }

        public DateTime? AgencyDate { get; set; }

        public DateTime CreationDate { get; set; }

        public int CreatedByUserID { get; set; }

        public string Notes { get; set; }
    }
}
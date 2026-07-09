using System;

namespace Models
{
    public class PropertyEvaluation
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode { get; set; } = enMode.AddNew;

        public int PropertyEvaluationID { get; set; }
        public int PropertyID { get; set; }

        public byte? Rating { get; set; }
        public decimal? EvaluationAmount { get; set; }
        public decimal? PurchasePrice { get; set; }

        public DateTime? EvaluationDate { get; set; }
        public string EvaluatedBy { get; set; }

        public DateTime CreatedDate { get; set; }
        public int CreatedByUserID { get; set; }
    }
}
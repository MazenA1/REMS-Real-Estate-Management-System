public class InvestmentPurpose
{
    public enum enMode
    {
        AddNew = 0,
        Update = 1
    }

    public enMode Mode { get; set; } = enMode.AddNew;

    public byte InvestmentPurposeID { get; set; }

    public string PurposeNameArabic { get; set; }

    public string PurposeNameEnglish { get; set; }

    public string Description { get; set; }

    public bool IsActive { get; set; }

    public byte DisplayOrder { get; set; }
}
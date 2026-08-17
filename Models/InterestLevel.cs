public class InterestLevel
{
    public enum enMode
    {
        AddNew = 0,
        Update = 1
    }

    public enMode Mode { get; set; } = enMode.AddNew;

    public byte InterestLevelID { get; set; }

    public string InterestLevelNameArabic { get; set; }

    public string InterestLevelNameEnglish { get; set; }

    public string Description { get; set; }

    public bool IsActive { get; set; }

    public byte DisplayOrder { get; set; }
}
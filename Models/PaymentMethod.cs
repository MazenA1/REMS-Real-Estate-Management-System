public class PaymentMethod
{
    public enum enMode
    {
        AddNew = 0,
        Update = 1
    }

    public enMode Mode { get; set; } = enMode.AddNew;

    public byte PaymentMethodID { get; set; }

    public string PaymentMethodNameArabic { get; set; }

    public string PaymentMethodNameEnglish { get; set; }

    public bool IsActive { get; set; }

    public byte DisplayOrder { get; set; }
}
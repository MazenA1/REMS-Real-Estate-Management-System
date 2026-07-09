namespace Models
{
    public class Client
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode { get; set; } = enMode.AddNew;
        public int ClientID { get; set; }
        public string FullName { get; set; }
        public string NationalNo { get; set; }
        public string PhoneNumber { get; set; }
        public string TaxNumber { get; set; }
        public string AnotherPhone { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gendor {  get; set; }
        public string NameEnglish { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public string IdPhotoPath { get; set; }

    }
}

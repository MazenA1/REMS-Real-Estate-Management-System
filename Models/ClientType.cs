namespace Models
{
    public class ClientType
    {
        public int ClientTypeID { get; set; }
        public string TypeNameAr { get; set; }
        public string TypeNameEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public bool IsActive { get; set; }
    }
}
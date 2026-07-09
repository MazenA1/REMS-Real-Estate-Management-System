public class User
{
    public enum enMode { AddNew = 0, Update = 1 }

    public enMode Mode { get; set; } = enMode.AddNew;

    public int UserID { get; set; }
    public int PersonID { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }
    public int Permissions { get; set; }
}
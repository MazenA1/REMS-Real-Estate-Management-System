using System.Configuration;

namespace DataAccessLayer
{
    public class clsDataAccessSettings
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
    }

}


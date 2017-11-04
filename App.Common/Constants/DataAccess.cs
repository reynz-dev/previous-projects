using System.Configuration;

namespace App.Common.Constants
{
    public static class DataAccess
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ACS"].ConnectionString;
    }
}

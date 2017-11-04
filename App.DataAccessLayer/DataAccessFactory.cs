using System.Data.SqlClient;

namespace App.DataAccessLayer
{
    public class DataAccessFactory
    {
        public static SqlConnection GetOpenConnection(string connectionString)
        {
            var sqlConnection = new SqlConnection { ConnectionString = connectionString };
            sqlConnection.Open();

            return sqlConnection;
        }
    }
}
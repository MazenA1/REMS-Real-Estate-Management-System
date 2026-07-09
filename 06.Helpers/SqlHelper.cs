using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Helpers
{
    public class SqlHelper
    {
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        public static object ExecuteScalar(string spName, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand(spName, Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        if (parameters != null)
                            Command.Parameters.AddRange(parameters);

                        Connection.Open();

                        return Command.ExecuteScalar();
                    }
                }
            }

            catch (Exception ex)
            {
                throw;
            }
        }

        public static int ExecuteNoneQuery(string spName, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand(spName, Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        if (parameters != null)
                            Command.Parameters.AddRange(parameters);

                        Connection.Open();

                        return Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataTable ExecuteDataTable(string spName, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand(spName, Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        if (parameters != null)
                            Command.Parameters.AddRange(parameters);

                        Connection.Open();

                        SqlDataReader reader = Command.ExecuteReader();

                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return dt;
        }

        public static SqlDataReader ExecuteReader(string spName, params SqlParameter[] parameters)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(spName, connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;

                        if (parameters != null)
                            command.Parameters.AddRange(parameters);

                        connection.Open();

                        return command.ExecuteReader();

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static object ToDbValue(object value)
        {
            return value ?? DBNull.Value;   
        }

    }
}

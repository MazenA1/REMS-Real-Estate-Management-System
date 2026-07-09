using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Helpers
{
    public static class SqlHelper
    {
        private static readonly string ConnectionString =
            ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        public static object ExecuteScalar(string spName, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteScalar();
                }
            }

            catch (Exception ex)
            {
                throw;
            }
        }

        public static int ExecuteNonQuery(string spName, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteNonQuery();
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
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }

                return dt;

            }

            catch(Exception ex)
            {
                throw;
            }
        }

        public static SqlDataReader ExecuteReader(string spName, params SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            try
            {
                SqlCommand command = new SqlCommand(spName, connection);
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                connection.Open();

                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                connection.Dispose();
                throw;
            }
        }

        public static object ToDbValue(object value)
        {
            return value ?? DBNull.Value;
        }
    }
}
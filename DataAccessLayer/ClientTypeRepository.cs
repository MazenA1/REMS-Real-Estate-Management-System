using Helpers;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ClientTypeRepository : IClientTypeRepository
    {
        public List<ClientType> GetAll()
        {
            List<ClientType> list = new List<ClientType>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllClientTypes"))
                {
                    while (reader.Read())
                    {
                        list.Add(new ClientType
                        {
                            ClientTypeID = (int)reader["ClientTypeID"],
                            TypeNameAr = reader["TypeNameAr"].ToString(),
                            TypeNameEn = reader["TypeNameEn"].ToString(),
                            DescriptionAr = reader["DescriptionAr"] == DBNull.Value ? "" : reader["DescriptionAr"].ToString(),
                            DescriptionEn = reader["DescriptionEn"] == DBNull.Value ? "" : reader["DescriptionEn"].ToString(),
                            IsActive = (bool)reader["IsActive"]
                        });
                    }
                }

                return list;
            }
            catch
            {
                return null;
            }
        }
    }
}
using Helpers;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ManagementCommissionTypeRepository : IManagementCommissionTypeRepository
    {
        private readonly IAppLogger _logger;

        public ManagementCommissionTypeRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        public List<ManagementCommissionType> GetAll()
        {
            List<ManagementCommissionType> list = new List<ManagementCommissionType>();

            try
            {
                using (SqlDataReader reader =
                    SqlHelper.ExecuteReader("SP_GetAllManagementCommissionTypes"))
                {
                    while (reader.Read())
                    {
                        list.Add(new ManagementCommissionType
                        {
                            ManagementCommissionTypeID =
                                Convert.ToInt32(reader["ManagementCommissionTypeID"]),

                            ArabicName =
                                reader["ArabicName"] == DBNull.Value
                                    ? ""
                                    : reader["ArabicName"].ToString(),

                            EnglishName =
                                reader["EnglishName"] == DBNull.Value
                                    ? ""
                                    : reader["EnglishName"].ToString(),

                            IsActive =
                                Convert.ToBoolean(reader["IsActive"])
                        });
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"Layer: DataAccess | Class: ManagementCommissionTypeRepository | Method: GetAll | Exception: {ex}");

                return null;
            }
        }
    }
}
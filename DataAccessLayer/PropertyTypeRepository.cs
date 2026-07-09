using Helpers;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class PropertyTypeRepository : IPropertyTypeRepository
    {
        private readonly IAppLogger _logger;

        public PropertyTypeRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        public List<PropertyType> GetAll()
        {
            List<PropertyType> list = new List<PropertyType>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllPropertyTypes"))
                {
                    while (reader.Read())
                    {
                        list.Add(new PropertyType
                        {
                            PropertyTypeID = Convert.ToInt32(reader["PropertyTypeID"]),
                            ArabicName = reader["ArabicName"].ToString(),
                            EnglishName = reader["EnglishName"].ToString(),
                            IsActive = Convert.ToBoolean(reader["IsActive"]),
                            CreatedDate = Convert.ToDateTime(reader["CreatedDate"])
                        });
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyTypeRepository | Method: GetAll | Exception: {ex}");
                return null;
            }
        }
    }
}
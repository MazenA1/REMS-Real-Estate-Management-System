using Helpers;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class CityRepository : ICityRepository
    {
        private readonly IAppLogger _logger;

        public CityRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        public List<City> GetAll()
        {
            List<City> list = new List<City>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllCities"))
                {
                    while (reader.Read())
                    {
                        list.Add(new City
                        {
                            CityID = Convert.ToInt32(reader["CityID"]),
                            CityNameArabic = reader["CityNameArabic"] == DBNull.Value ? "" : reader["CityNameArabic"].ToString(),
                            CityNameTurkish = reader["CityNameTurkish"] == DBNull.Value ? "" : reader["CityNameTurkish"].ToString(),
                            PlateCode = Convert.ToInt32(reader["PlateCode"]),
                            IsActive = Convert.ToBoolean(reader["IsActive"])
                        });
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: CityRepository | Method: GetAll | Exception: {ex}");
                return null;
            }
        }
    }
}
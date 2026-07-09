using Helpers;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DistrictRepository : IDistrictRepository
    {
        private readonly IAppLogger _logger;

        public DistrictRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        public List<District> GetAll()
        {
            List<District> districts = new List<District>();

            try
            {
                using (SqlDataReader reader =
                    SqlHelper.ExecuteReader("SP_GetAllDistricts"))
                {
                    while (reader.Read())
                    {
                        districts.Add(_MapDistrict(reader));
                    }
                }

                return districts;
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"Layer: DataAccess | Class: DistrictRepository | Method: GetAll | Exception: {ex}");

                return null;
            }
        }

        public List<District> GetByCityID(int cityID)
        {
            List<District> districts = new List<District>();

            try
            {
                using (SqlDataReader reader =
                    SqlHelper.ExecuteReader(
                        "SP_GetDistrictsByCityID",
                        new SqlParameter("@CityID", cityID)))
                {
                    while (reader.Read())
                    {
                        districts.Add(_MapDistrict(reader));
                    }
                }

                return districts;
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"Layer: DataAccess | Class: DistrictRepository | Method: GetByCityID | CityID:{cityID} | Exception:{ex}");

                return null;
            }
        }

        private District _MapDistrict(SqlDataReader reader)
        {
            return new District
            {
                DistrictID =
                    Convert.ToInt32(reader["DistrictID"]),

                CityID =
                    Convert.ToInt32(reader["CityID"]),

                DistrictNameTurkish =
                    reader["DistrictNameTurkish"] == DBNull.Value
                    ? string.Empty
                    : reader["DistrictNameTurkish"].ToString(),

                IsActive =
                    Convert.ToBoolean(reader["IsActive"])
            };
        }
    }
}
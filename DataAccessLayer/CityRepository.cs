using Helpers;
using Interfaces;
using Models;
using Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public BindingList<InvestorPreferredCitieSelectionDTO> GetAllCities()
        {
            BindingList<InvestorPreferredCitieSelectionDTO> citieSelectionDTOs = new BindingList<InvestorPreferredCitieSelectionDTO>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllCities"))
                {
                    while(reader.Read())
                    {
                        citieSelectionDTOs.Add(new InvestorPreferredCitieSelectionDTO()
                        {
                            CitieId = Convert.ToInt16(reader["CityID"]),
                            CitieName = reader["CityNameTurkish"].ToString(),
                            PlateCode = Convert.ToInt16(reader["PlateCode"])
                        });
                    }
                }

                return citieSelectionDTOs;
            }

            catch(Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: CityRepository | Method: GetAllCities | Exception: {ex}"); 
                return null;
            }
        }
        
    }
}
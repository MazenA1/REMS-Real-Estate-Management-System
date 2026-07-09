using Helpers;
using Interfaces;
using System.Data.SqlClient;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CountryRepository : ICountryRepository
    {
        private readonly IAppLogger _loggerService;
        public CountryRepository(IAppLogger appLogger)
        {
            this._loggerService = appLogger;
        }
        public Country FindByID(int ID)
        {
            Country country = null;

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_FindCountryByID", new SqlParameter("@CountryID", ID)))
                {
                    if (reader.Read())
                    {
                        country = new Country
                        {
                            Id = (int)reader["CountryID"],
                            CountryName = reader["CountryName"].ToString()
                        };
                    }

                }

                return country;
            }
            catch (Exception ex)
            {
                _loggerService.LogError("Layer: DataAccess | Class: CountryRepository | Method: FindByID ", ex);

                return null;
            }
        }

        public Country FindByName(string Name)
        {
            Country country = null;
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_FindCountryByName", new SqlParameter("@CountryName", Name)))
                {
                    if (reader.Read())
                    {
                        country = new Country
                        {
                            Id = (int)reader["CountryID"],
                            CountryName = reader["CountryName"].ToString()
                        };
                    }

                }

                return country;
            }

            catch (Exception ex)
            {
                _loggerService.LogError("Layer: DataAccess | Class: CountryRepository | Method: FindByName ", ex); 

                return null;
            }

        }

        public List<Country> GetAll()
        {
            List<Country> countries = new List<Country>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllCountries"))
                {
                    while (reader.Read())
                    {
                        countries.Add(new Country
                        {
                            Id = (int)reader["CountryID"],
                            CountryName = reader["CountryName"].ToString()
                        });

                    }
                }

                return countries;
            }
            catch (Exception ex)
            {
                _loggerService.LogError("Layer: DataAccess | Class: CountryRepository | Method: GetAll ", ex); 

                return null;
            }

        }
    }
}

using Helpers;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly IAppLogger _logger;

        public PropertyRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        public int Add(Property property)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_AddNewProperty",
                    new SqlParameter("@PropertyName", property.PropertyName),
                    new SqlParameter("@PropertyTypeID", property.PropertyTypeID),
                    new SqlParameter("@Address", property.Address),
                    new SqlParameter("@CityID", property.CityID),
                    new SqlParameter("@DistrictID", property.DistrictID),
                    new SqlParameter("@Area", SqlHelper.ToDbValue(property.Area)),
                    new SqlParameter("@BuildingYear", SqlHelper.ToDbValue(property.BuildingYear)),
                    new SqlParameter("@Description", SqlHelper.ToDbValue(property.Description)),
                    new SqlParameter("@ManagementCommissionValue", SqlHelper.ToDbValue(property.ManagementCommissionValue)),
                    new SqlParameter("@ManagementCommissionTypeID", property.ManagementCommissionTypeID),
                    new SqlParameter("@IsSubjectToVAT", property.IsSubjectToVAT),
                    new SqlParameter("@CreatedByUserID", property.CreatedByUserID)
                );

                return result != null && int.TryParse(result.ToString(), out int propertyID)
                    ? propertyID
                    : -1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyRepository | Method: Add | Exception: {ex}");
                return -1;
            }
        }

        public bool Update(Property property)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_UpdateProperty",
                    new SqlParameter("@PropertyID", property.PropertyID),
                    new SqlParameter("@PropertyName", property.PropertyName),
                    new SqlParameter("@PropertyTypeID", property.PropertyTypeID),
                    new SqlParameter("@Address", property.Address),
                    new SqlParameter("@CityID", property.CityID),
                    new SqlParameter("@DistrictID", property.DistrictID),
                    new SqlParameter("@Area", SqlHelper.ToDbValue(property.Area)),
                    new SqlParameter("@BuildingYear", SqlHelper.ToDbValue(property.BuildingYear)),
                    new SqlParameter("@Description", SqlHelper.ToDbValue(property.Description)),
                    new SqlParameter("@ManagementCommissionValue", SqlHelper.ToDbValue(property.ManagementCommissionValue)),
                    new SqlParameter("@ManagementCommissionTypeID", property.ManagementCommissionTypeID),
                    new SqlParameter("@IsSubjectToVAT", property.IsSubjectToVAT),
                    new SqlParameter("@CreatedDate", property.CreatedDate),
                    new SqlParameter("@CreatedByUserID", property.CreatedByUserID),
                    new SqlParameter("@IsActive", property.IsActive)
                );

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyRepository | Method: Update | PropertyID: {property?.PropertyID} | Exception: {ex}");
                return false;
            }
        }

        public bool Delete(int propertyID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_DeleteProperty",
                    new SqlParameter("@PropertyID", propertyID)
                );

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyRepository | Method: Delete | PropertyID: {propertyID} | Exception: {ex}");
                return false;
            }
        }

        public Property GetByID(int propertyID)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetPropertyByID",
                    new SqlParameter("@PropertyID", propertyID)))
                {
                    if (reader.Read())
                        return _MapReaderToProperty(reader);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyRepository | Method: GetByID | PropertyID: {propertyID} | Exception: {ex}");
                return null;
            }
        }

        public Property GetByCode(Guid propertyCode)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetPropertyByCode",
                    new SqlParameter("@PropertyCode", propertyCode)))
                {
                    if (reader.Read())
                        return _MapReaderToProperty(reader);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyRepository | Method: GetByCode | PropertyCode: {propertyCode} | Exception: {ex}");
                return null;
            }
        }

        public List<Property> GetAll()
        {
            List<Property> properties = new List<Property>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllProperties"))
                {
                    while (reader.Read())
                    {
                        properties.Add(_MapReaderToProperty(reader));
                    }
                }

                return properties;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyRepository | Method: GetAll | Exception: {ex}");
                return null;
            }
        }

        public bool Exists(int propertyID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_IsPropertyExist",
                    new SqlParameter("@PropertyID", propertyID)
                );

                return result != null && Convert.ToInt32(result) == 1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyRepository | Method: Exists | PropertyID: {propertyID} | Exception: {ex}");
                return false;
            }
        }

        private Property _MapReaderToProperty(SqlDataReader reader)
        {
            return new Property
            {
                PropertyID = Convert.ToInt32(reader["PropertyID"]),
                PropertyCode = (Guid)reader["PropertyCode"],

                PropertyName = reader["PropertyName"].ToString(),
                PropertyTypeID = Convert.ToInt32(reader["PropertyTypeID"]),

                Address = reader["Address"].ToString(),
                CityID = Convert.ToInt32(reader["CityID"]),
                DistrictID = Convert.ToInt32(reader["DistrictID"]),

                Area = reader["Area"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(reader["Area"]),
                BuildingYear = reader["BuildingYear"] == DBNull.Value ? (short?)null : Convert.ToInt16(reader["BuildingYear"]),
                Description = reader["Description"] == DBNull.Value ? "" : reader["Description"].ToString(),

                ManagementCommissionValue =
                    reader["ManagementCommissionValue"] == DBNull.Value
                        ? (decimal?)null
                        : Convert.ToDecimal(reader["ManagementCommissionValue"]),

                ManagementCommissionTypeID = Convert.ToInt32(reader["ManagementCommissionTypeID"]),
                IsSubjectToVAT = Convert.ToBoolean(reader["IsSubjectToVAT"]),

                CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                IsActive = Convert.ToBoolean(reader["IsActive"]),

                Mode = Property.enMode.Update
            };
        }
    }
}
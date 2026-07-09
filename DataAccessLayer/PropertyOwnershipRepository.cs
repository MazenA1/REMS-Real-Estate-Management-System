using Helpers;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class PropertyOwnershipRepository : IPropertyOwnershipRepository
    {
        private readonly IAppLogger _logger;

        public PropertyOwnershipRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        public int Add(PropertyOwnership ownership)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_AddNewPropertyOwnership",
                    new SqlParameter("@PropertyID", ownership.PropertyID),
                    new SqlParameter("@OwnerID", ownership.OwnerID),
                    new SqlParameter("@DeedNumber", SqlHelper.ToDbValue(ownership.DeedNumber)),
                    new SqlParameter("@DeedDate", SqlHelper.ToDbValue(ownership.DeedDate)),
                    new SqlParameter("@LandNumber", SqlHelper.ToDbValue(ownership.LandNumber)),
                    new SqlParameter("@OwnershipStatusID", SqlHelper.ToDbValue(ownership.OwnershipStatusID)),
                    new SqlParameter("@DeedImagePath", SqlHelper.ToDbValue(ownership.DeedImagePath)),
                    new SqlParameter("@OwnershipPercentage", ownership.OwnershipPercentage),
                    new SqlParameter("@CreatedByUserID", ownership.CreatedByUserID),
                    new SqlParameter("@IsActive", ownership.IsActive)
                );

                return result != null && int.TryParse(result.ToString(), out int id)
                    ? id
                    : -1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyOwnershipRepository | Method: Add | Exception: {ex}");
                return -1;
            }
        }

        public bool Update(PropertyOwnership ownership)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_UpdatePropertyOwnership",
                    new SqlParameter("@PropertyOwnershipID", ownership.PropertyOwnershipID),
                    new SqlParameter("@PropertyID", ownership.PropertyID),
                    new SqlParameter("@OwnerID", ownership.OwnerID),
                    new SqlParameter("@DeedNumber", SqlHelper.ToDbValue(ownership.DeedNumber)),
                    new SqlParameter("@DeedDate", SqlHelper.ToDbValue(ownership.DeedDate)),
                    new SqlParameter("@LandNumber", SqlHelper.ToDbValue(ownership.LandNumber)),
                    new SqlParameter("@OwnershipStatusID", SqlHelper.ToDbValue(ownership.OwnershipStatusID)),
                    new SqlParameter("@DeedImagePath", SqlHelper.ToDbValue(ownership.DeedImagePath)),
                    new SqlParameter("@OwnershipPercentage", ownership.OwnershipPercentage),
                    new SqlParameter("@CreatedDate", ownership.CreatedDate),
                    new SqlParameter("@CreatedByUserID", ownership.CreatedByUserID),
                    new SqlParameter("@IsActive", ownership.IsActive)
                );

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyOwnershipRepository | Method: Update | ID: {ownership?.PropertyOwnershipID} | Exception: {ex}");
                return false;
            }
        }

        public bool Delete(int propertyOwnershipID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_DeletePropertyOwnership",
                    new SqlParameter("@PropertyOwnershipID", propertyOwnershipID));

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyOwnershipRepository | Method: Delete | ID: {propertyOwnershipID} | Exception: {ex}");
                return false;
            }
        }

        public PropertyOwnership GetByID(int propertyOwnershipID)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetPropertyOwnershipByID",
                    new SqlParameter("@PropertyOwnershipID", propertyOwnershipID)))
                {
                    if (reader.Read())
                        return _MapReaderToPropertyOwnership(reader);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyOwnershipRepository | Method: GetByID | ID: {propertyOwnershipID} | Exception: {ex}");
                return null;
            }
        }

        public List<PropertyOwnership> GetByPropertyID(int propertyID)
        {
            List<PropertyOwnership> list = new List<PropertyOwnership>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetPropertyOwnershipsByPropertyID",
                    new SqlParameter("@PropertyID", propertyID)))
                {
                    while (reader.Read())
                        list.Add(_MapReaderToPropertyOwnership(reader));
                }

                return list;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyOwnershipRepository | Method: GetByPropertyID | PropertyID: {propertyID} | Exception: {ex}");
                return null;
            }
        }

        public List<PropertyOwnership> GetByOwnerID(int ownerID)
        {
            List<PropertyOwnership> list = new List<PropertyOwnership>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetPropertyOwnershipsByOwnerID",
                    new SqlParameter("@OwnerID", ownerID)))
                {
                    while (reader.Read())
                        list.Add(_MapReaderToPropertyOwnership(reader));
                }

                return list;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyOwnershipRepository | Method: GetByOwnerID | OwnerID: {ownerID} | Exception: {ex}");
                return null;
            }
        }

        public List<PropertyOwnership> GetAll()
        {
            List<PropertyOwnership> list = new List<PropertyOwnership>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllPropertyOwnerships"))
                {
                    while (reader.Read())
                        list.Add(_MapReaderToPropertyOwnership(reader));
                }

                return list;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyOwnershipRepository | Method: GetAll | Exception: {ex}");
                return null;
            }
        }

        public bool Exists(int propertyOwnershipID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_IsPropertyOwnershipExist",
                    new SqlParameter("@PropertyOwnershipID", propertyOwnershipID));

                return result != null && Convert.ToInt32(result) == 1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyOwnershipRepository | Method: Exists | ID: {propertyOwnershipID} | Exception: {ex}");
                return false;
            }
        }

        private PropertyOwnership _MapReaderToPropertyOwnership(SqlDataReader reader)
        {
            return new PropertyOwnership
            {
                PropertyOwnershipID = Convert.ToInt32(reader["PropertyOwnershipID"]),
                PropertyID = Convert.ToInt32(reader["PropertyID"]),
                OwnerID = Convert.ToInt32(reader["OwnerID"]),

                DeedNumber = reader["DeedNumber"] == DBNull.Value ? "" : reader["DeedNumber"].ToString(),

                DeedDate = reader["DeedDate"] == DBNull.Value
                    ? (DateTime?)null
                    : Convert.ToDateTime(reader["DeedDate"]),

                LandNumber = reader["LandNumber"] == DBNull.Value ? "" : reader["LandNumber"].ToString(),

                OwnershipStatusID = reader["OwnershipStatusID"] == DBNull.Value
                    ? (int?)null
                    : Convert.ToInt32(reader["OwnershipStatusID"]),

                DeedImagePath = reader["DeedImagePath"] == DBNull.Value ? "" : reader["DeedImagePath"].ToString(),

                OwnershipPercentage = Convert.ToDecimal(reader["OwnershipPercentage"]),

                CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),
                IsActive = Convert.ToBoolean(reader["IsActive"]),

                Mode = PropertyOwnership.enMode.Update
            };
        }
    }
}
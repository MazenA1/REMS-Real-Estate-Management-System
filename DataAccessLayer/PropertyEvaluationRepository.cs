using Helpers;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class PropertyEvaluationRepository : IPropertyEvaluationRepository
    {
        private readonly IAppLogger _logger;

        public PropertyEvaluationRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        public int Add(PropertyEvaluation evaluation)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_AddNewPropertyEvaluation",
                    new SqlParameter("@PropertyID", evaluation.PropertyID),
                    new SqlParameter("@Rating", SqlHelper.ToDbValue(evaluation.Rating)),
                    new SqlParameter("@EvaluationAmount", SqlHelper.ToDbValue(evaluation.EvaluationAmount)),
                    new SqlParameter("@PurchasePrice", SqlHelper.ToDbValue(evaluation.PurchasePrice)),
                    new SqlParameter("@EvaluationDate", SqlHelper.ToDbValue(evaluation.EvaluationDate)),
                    new SqlParameter("@EvaluatedBy", SqlHelper.ToDbValue(evaluation.EvaluatedBy)),
                    new SqlParameter("@CreatedByUserID", evaluation.CreatedByUserID)
                );

                return result != null && int.TryParse(result.ToString(), out int id)
                    ? id
                    : -1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyEvaluationRepository | Method: Add | PropertyID: {evaluation?.PropertyID} | Exception: {ex}");
                return -1;
            }
        }

        public bool Update(PropertyEvaluation evaluation)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_UpdatePropertyEvaluation",
                    new SqlParameter("@PropertyEvaluationID", evaluation.PropertyEvaluationID),
                    new SqlParameter("@PropertyID", evaluation.PropertyID),
                    new SqlParameter("@Rating", SqlHelper.ToDbValue(evaluation.Rating)),
                    new SqlParameter("@EvaluationAmount", SqlHelper.ToDbValue(evaluation.EvaluationAmount)),
                    new SqlParameter("@PurchasePrice", SqlHelper.ToDbValue(evaluation.PurchasePrice)),
                    new SqlParameter("@EvaluationDate", SqlHelper.ToDbValue(evaluation.EvaluationDate)),
                    new SqlParameter("@EvaluatedBy", SqlHelper.ToDbValue(evaluation.EvaluatedBy)),
                    new SqlParameter("@CreatedDate", evaluation.CreatedDate),
                    new SqlParameter("@CreatedByUserID", evaluation.CreatedByUserID)
                );

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyEvaluationRepository | Method: Update | ID: {evaluation?.PropertyEvaluationID} | Exception: {ex}");
                return false;
            }
        }

        public bool Delete(int propertyEvaluationID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_DeletePropertyEvaluation",
                    new SqlParameter("@PropertyEvaluationID", propertyEvaluationID));

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyEvaluationRepository | Method: Delete | ID: {propertyEvaluationID} | Exception: {ex}");
                return false;
            }
        }

        public PropertyEvaluation GetByID(int propertyEvaluationID)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetPropertyEvaluationByID",
                    new SqlParameter("@PropertyEvaluationID", propertyEvaluationID)))
                {
                    if (reader.Read())
                        return _MapReaderToPropertyEvaluation(reader);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyEvaluationRepository | Method: GetByID | ID: {propertyEvaluationID} | Exception: {ex}");
                return null;
            }
        }

        public PropertyEvaluation GetLastByPropertyID(int propertyID)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetLastPropertyEvaluationByPropertyID",
                    new SqlParameter("@PropertyID", propertyID)))
                {
                    if (reader.Read())
                        return _MapReaderToPropertyEvaluation(reader);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyEvaluationRepository | Method: GetLastByPropertyID | PropertyID: {propertyID} | Exception: {ex}");
                return null;
            }
        }

        public List<PropertyEvaluation> GetByPropertyID(int propertyID)
        {
            List<PropertyEvaluation> list = new List<PropertyEvaluation>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetPropertyEvaluationsByPropertyID",
                    new SqlParameter("@PropertyID", propertyID)))
                {
                    while (reader.Read())
                        list.Add(_MapReaderToPropertyEvaluation(reader));
                }

                return list;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyEvaluationRepository | Method: GetByPropertyID | PropertyID: {propertyID} | Exception: {ex}");
                return null;
            }
        }

        public List<PropertyEvaluation> GetAll()
        {
            List<PropertyEvaluation> list = new List<PropertyEvaluation>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllPropertyEvaluations"))
                {
                    while (reader.Read())
                        list.Add(_MapReaderToPropertyEvaluation(reader));
                }

                return list;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyEvaluationRepository | Method: GetAll | Exception: {ex}");
                return null;
            }
        }

        public bool Exists(int propertyEvaluationID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_IsPropertyEvaluationExist",
                    new SqlParameter("@PropertyEvaluationID", propertyEvaluationID));

                return result != null && Convert.ToInt32(result) == 1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: PropertyEvaluationRepository | Method: Exists | ID: {propertyEvaluationID} | Exception: {ex}");
                return false;
            }
        }

        private PropertyEvaluation _MapReaderToPropertyEvaluation(SqlDataReader reader)
        {
            return new PropertyEvaluation
            {
                PropertyEvaluationID = Convert.ToInt32(reader["PropertyEvaluationID"]),
                PropertyID = Convert.ToInt32(reader["PropertyID"]),

                Rating = reader["Rating"] == DBNull.Value
                    ? (byte?)null
                    : Convert.ToByte(reader["Rating"]),

                EvaluationAmount = reader["EvaluationAmount"] == DBNull.Value
                    ? (decimal?)null
                    : Convert.ToDecimal(reader["EvaluationAmount"]),

                PurchasePrice = reader["PurchasePrice"] == DBNull.Value
                    ? (decimal?)null
                    : Convert.ToDecimal(reader["PurchasePrice"]),

                EvaluationDate = reader["EvaluationDate"] == DBNull.Value
                    ? (DateTime?)null
                    : Convert.ToDateTime(reader["EvaluationDate"]),

                EvaluatedBy = reader["EvaluatedBy"] == DBNull.Value
                    ? ""
                    : reader["EvaluatedBy"].ToString(),

                CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]),

                Mode = PropertyEvaluation.enMode.Update
            };
        }
    }
}
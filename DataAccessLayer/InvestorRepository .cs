using Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.Repositories
{
    public class InvestorRepository : IInvestorRepository
    {
        private readonly IAppLogger _logger;

        public InvestorRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        //=====================================================
        // Add
        //=====================================================

        public int Add(Investor investor)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@ClientRoleID",
                        investor.ClientRoleID),

                    new SqlParameter("@MinimumBudget",
                        (object)investor.MinimumBudget ?? DBNull.Value),

                    new SqlParameter("@MaximumBudget",
                        (object)investor.MaximumBudget ?? DBNull.Value),

                    new SqlParameter("@PaymentMethodID",
                        investor.PaymentMethodID),

                    new SqlParameter("@InvestmentPurposeID",
                        investor.InvestmentPurposeID),

                    new SqlParameter("@InterestLevelID",
                        investor.InterestLevelID),

                    new SqlParameter("@OpeningBalance",
                        (object)investor.OpeningBalance ?? DBNull.Value),

                    new SqlParameter("@ReadyToInvest",
                        investor.ReadyToInvest),

                    new SqlParameter("@RepresentativeName",
                        (object)investor.RepresentativeName ?? DBNull.Value),

                    new SqlParameter("@RepresentativeNationalID",
                        (object)investor.RepresentativeNationalID ?? DBNull.Value),

                    new SqlParameter("@AgencyNumber",
                        (object)investor.AgencyNumber ?? DBNull.Value),

                    new SqlParameter("@AgencyDate",
                        (object)investor.AgencyDate ?? DBNull.Value),

                    new SqlParameter("@CreatedByUserID",
                        investor.CreatedByUserID),

                    new SqlParameter("@Notes",
                        (object)investor.Notes ?? DBNull.Value)
                };

                object result = Helpers.SqlHelper.ExecuteScalar(
                    "SP_AddInvestor",
                    parameters);

                if (result != null &&
                    int.TryParse(result.ToString(), out int investorID))
                {
                    return investorID;
                }

                return -1;
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"Layer: DataAccess | Class: InvestorRepository | Method: Add | Exception: {ex}");

                return -1;
            }
        }

        //=====================================================
        // Update
        //=====================================================

        public bool Update(Investor investor)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@InvestorID",
                        investor.InvestorID),

                    new SqlParameter("@MinimumBudget",
                        (object)investor.MinimumBudget ?? DBNull.Value),

                    new SqlParameter("@MaximumBudget",
                        (object)investor.MaximumBudget ?? DBNull.Value),

                    new SqlParameter("@PaymentMethodID",
                        investor.PaymentMethodID),

                    new SqlParameter("@InvestmentPurposeID",
                        investor.InvestmentPurposeID),

                    new SqlParameter("@InterestLevelID",
                        investor.InterestLevelID),

                    new SqlParameter("@OpeningBalance",
                        (object)investor.OpeningBalance ?? DBNull.Value),

                    new SqlParameter("@ReadyToInvest",
                        investor.ReadyToInvest),

                    new SqlParameter("@RepresentativeName",
                        (object)investor.RepresentativeName ?? DBNull.Value),

                    new SqlParameter("@RepresentativeNationalID",
                        (object)investor.RepresentativeNationalID ?? DBNull.Value),

                    new SqlParameter("@AgencyNumber",
                        (object)investor.AgencyNumber ?? DBNull.Value),

                    new SqlParameter("@AgencyDate",
                        (object)investor.AgencyDate ?? DBNull.Value),

                    new SqlParameter("@Notes",
                        (object)investor.Notes ?? DBNull.Value)
                };

                object result = Helpers.SqlHelper.ExecuteScalar(
                    "SP_UpdateInvestor",
                    parameters);

                return result != null &&
                       Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"Layer: DataAccess | Class: InvestorRepository | Method: Update | Exception: {ex}");

                return false;
            }
        }

        //=====================================================
        // Delete
        //=====================================================

        public bool Delete(int investorID)
        {
            try
            {
                object result = Helpers.SqlHelper.ExecuteScalar(
                    "SP_DeleteInvestor",
                    new SqlParameter("@InvestorID", investorID));

                return result != null &&
                       Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"Layer: DataAccess | Class: InvestorRepository | Method: Delete | Exception: {ex}");

                return false;
            }
        }

        //=====================================================
        // Get By ID
        //=====================================================

        public Investor GetByID(int investorID)
        {
            try
            {
                using (SqlDataReader reader =
                    Helpers.SqlHelper.ExecuteReader(
                        "SP_GetInvestorByID",
                        new SqlParameter("@InvestorID", investorID)))
                {
                    if (reader.Read())
                        return _MapReaderToInvestor(reader);

                    return null;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"Layer: DataAccess | Class: InvestorRepository | Method: GetByID | Exception: {ex}");

                return null;
            }
        }

        //=====================================================
        // Get By ClientRoleID
        //=====================================================

        public Investor GetByClientRoleID(int clientRoleID)
        {
            try
            {
                using (SqlDataReader reader =
                    Helpers.SqlHelper.ExecuteReader(
                        "SP_GetInvestorByClientRoleID",
                        new SqlParameter("@ClientRoleID", clientRoleID)))
                {
                    if (reader.Read())
                        return _MapReaderToInvestor(reader);

                    return null;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"Layer: DataAccess | Class: InvestorRepository | Method: GetByClientRoleID | Exception: {ex}");

                return null;
            }
        }

        //=====================================================
        // Get All
        //=====================================================

        public List<Investor> GetAll()
        {
            List<Investor> investors = new List<Investor>();

            try
            {
                using (SqlDataReader reader =
                    Helpers.SqlHelper.ExecuteReader(
                        "SP_GetAllInvestors"))
                {
                    while (reader.Read())
                    {
                        investors.Add(
                            _MapReaderToInvestor(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"Layer: DataAccess | Class: InvestorRepository | Method: GetAll | Exception: {ex}");
            }

            return investors;
        }

        //=====================================================
        // Exists
        //=====================================================

        public bool Exists(int investorID)
        {
            try
            {
                object result =
                    Helpers.SqlHelper.ExecuteScalar(
                        "SP_IsInvestorExist",
                        new SqlParameter(
                            "@InvestorID",
                            investorID));

                return result != null &&
                       Convert.ToBoolean(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"Layer: DataAccess | Class: InvestorRepository | Method: Exists | Exception: {ex}");

                return false;
            }
        }

        //=====================================================
        // Mapper
        //=====================================================

        private Investor _MapReaderToInvestor(SqlDataReader reader)
        {
            return new Investor
            {
                InvestorID =
                    Convert.ToInt32(reader["InvestorID"]),

                ClientRoleID =
                    Convert.ToInt32(reader["ClientRoleID"]),

                MinimumBudget =
                    reader["MinimumBudget"] == DBNull.Value
                        ? (decimal?)null
                        : Convert.ToDecimal(reader["MinimumBudget"]),

                MaximumBudget =
                    reader["MaximumBudget"] == DBNull.Value
                        ? (decimal?)null
                        : Convert.ToDecimal(reader["MaximumBudget"]),

                PaymentMethodID =
                    Convert.ToByte(reader["PaymentMethodID"]),

                InvestmentPurposeID =
                    Convert.ToByte(reader["InvestmentPurposeID"]),

                InterestLevelID =
                    Convert.ToByte(reader["InterestLevelID"]),

                OpeningBalance =
                    reader["OpeningBalance"] == DBNull.Value
                        ? (decimal?)null
                        : Convert.ToDecimal(reader["OpeningBalance"]),

                ReadyToInvest =
                    Convert.ToBoolean(reader["ReadyToInvest"]),

                RepresentativeName =
                    reader["RepresentativeName"] == DBNull.Value
                        ? null
                        : reader["RepresentativeName"].ToString(),

                RepresentativeNationalID =
                    reader["RepresentativeNationalID"] == DBNull.Value
                        ? null
                        : reader["RepresentativeNationalID"].ToString(),

                AgencyNumber =
                    reader["AgencyNumber"] == DBNull.Value
                        ? null
                        : reader["AgencyNumber"].ToString(),

                AgencyDate =
                    reader["AgencyDate"] == DBNull.Value
                        ? (DateTime?)null
                        : Convert.ToDateTime(reader["AgencyDate"]),

                CreationDate =
                    Convert.ToDateTime(reader["CreationDate"]),

                CreatedByUserID =
                    Convert.ToInt32(reader["CreatedByUserID"]),

                Notes =
                    reader["Notes"] == DBNull.Value
                        ? null
                        : reader["Notes"].ToString(),

                Mode = Investor.enMode.Update
            };
        }
    }
}
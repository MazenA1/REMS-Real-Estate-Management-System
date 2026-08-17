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
    public class TenantRepository : ITenantRepository
    {
        private readonly IAppLogger _logger;

        public TenantRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        public int Add(Tenant tenant)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_AddNewTenant",
                    new SqlParameter("@RepresentativeName", SqlHelper.ToDbValue(tenant.RepresentativeName)),
                    new SqlParameter("@RepresentativeNationalID", SqlHelper.ToDbValue(tenant.RepresentativeNationalID)),
                    new SqlParameter("@RepresentativeDate", SqlHelper.ToDbValue(tenant.RepresentativeDate)),
                    new SqlParameter("@AgencyNumber", SqlHelper.ToDbValue(tenant.AgencyNumber)),
                    new SqlParameter("@AgencyDate", SqlHelper.ToDbValue(tenant.AgencyDate)),
                    new SqlParameter("@NationalityID", SqlHelper.ToDbValue(tenant.NationalityID)),
                    new SqlParameter("@ClientRoleID", tenant.ClientRoleID),
                    new SqlParameter("@NameOfConductor", tenant.NameOfConductor),
                    new SqlParameter("@OpeningBalance", SqlHelper.ToDbValue(tenant.OpeningBalance)),
                    new SqlParameter("@CreationDate", tenant.CreationDate),
                    new SqlParameter("@MovementType", tenant.MovementType),
                    new SqlParameter("@TenantEvaluation", tenant.TenantEvaluation)
                );

                return result != null && int.TryParse(result.ToString(), out int tenantID)
                    ? tenantID
                    : -1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: TenantRepository | Method: Add | ClientRoleID: {tenant?.ClientRoleID} | Exception: {ex}");
                return -1;
            }
        }

        public int GetTenantsCount()
        {
            try
            {
                object result = SqlHelper.ExecuteScalar("SP_GetTenantsCount");
                return result == null ? 0 : Convert.ToInt32(result);
            }

            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: TenantRepository | Method: GetTenantsCount | Exception: {ex}");
                return -1;
            }
        }

        public bool Update(Tenant tenant)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_UpdateTenant",
                    new SqlParameter("@TenantID", tenant.TenantID),
                    new SqlParameter("@RepresentativeName", SqlHelper.ToDbValue(tenant.RepresentativeName)),
                    new SqlParameter("@RepresentativeNationalID", SqlHelper.ToDbValue(tenant.RepresentativeNationalID)),
                    new SqlParameter("@RepresentativeDate", SqlHelper.ToDbValue(tenant.RepresentativeDate)),
                    new SqlParameter("@AgencyNumber", SqlHelper.ToDbValue(tenant.AgencyNumber)),
                    new SqlParameter("@AgencyDate", SqlHelper.ToDbValue(tenant.AgencyDate)),
                    new SqlParameter("@NationalityID", SqlHelper.ToDbValue(tenant.NationalityID)),
                    new SqlParameter("@ClientRoleID", tenant.ClientRoleID),
                    new SqlParameter("@NameOfConductor", tenant.NameOfConductor),
                    new SqlParameter("@OpeningBalance", SqlHelper.ToDbValue(tenant.OpeningBalance)),
                    new SqlParameter("@CreationDate", tenant.CreationDate),
                    new SqlParameter("@MovementType", tenant.MovementType),
                    new SqlParameter("@TenantEvaluation", tenant.TenantEvaluation)
                );

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: TenantRepository | Method: Update | TenantID: {tenant?.TenantID} | Exception: {ex}");
                return false;
            }
        }

        public bool Delete(int tenantID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_DeleteTenant",
                    new SqlParameter("@TenantID", tenantID)
                );

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: TenantRepository | Method: Delete | TenantID: {tenantID} | Exception: {ex}");
                return false;
            }
        }

        public Tenant GetByID(int tenantID)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetTenantByID",
                    new SqlParameter("@TenantID", tenantID)))
                {
                    if (reader.Read())
                        return _MapReaderToTenant(reader);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: TenantRepository | Method: GetByID | TenantID: {tenantID} | Exception: {ex}");
                return null;
            }
        }

        public Tenant GetByClientRoleID(int clientRoleID)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetTenantByClientRoleID",
                    new SqlParameter("@ClientRoleID", clientRoleID)))
                {
                    if (reader.Read())
                        return _MapReaderToTenant(reader);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: TenantRepository | Method: GetByClientRoleID | ClientRoleID: {clientRoleID} | Exception: {ex}");
                return null;
            }
        }

        public List<Tenant> GetAll()
        {
            List<Tenant> list = new List<Tenant>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllTenants"))
                {
                    while (reader.Read())
                        list.Add(_MapReaderToTenant(reader));
                }

                return list;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: TenantRepository | Method: GetAll | Exception: {ex}");
                return null;
            }
        }

        public BindingList<TenantListDTO> GetTenantList()
        {
            BindingList<TenantListDTO> List = new BindingList<TenantListDTO>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetTenantsList"))
                {
                    while(reader.Read())
                    {
                        List.Add(_MapReaderToTenantList(reader));
                    }

                }
                   
                return List;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: TenantRepository | Method: GetTenantList | Exception: {ex}");
                return null;
            }
        }
        public bool Exists(int tenantID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_IsTenantExist",
                    new SqlParameter("@TenantID", tenantID)
                );

                return result != null && Convert.ToInt32(result) == 1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: TenantRepository | Method: Exists | TenantID: {tenantID} | Exception: {ex}");
                return false;
            }
        }

        public bool ExistsByClientRoleID(int clientRoleID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_IsTenantExistByClientRoleID",
                    new SqlParameter("@ClientRoleID", clientRoleID)
                );

                return result != null && Convert.ToInt32(result) == 1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: TenantRepository | Method: ExistsByClientRoleID | ClientRoleID: {clientRoleID} | Exception: {ex}");
                return false;
            }
        }

        private TenantListDTO _MapReaderToTenantList(SqlDataReader reader)
        {
            return new TenantListDTO
            {
                TenantFullName = reader["FullName"].ToString(),
                TenantNationalNo = reader["NationalNo"].ToString(),
                TenantPhoneNumber = reader["PhoneNumber"].ToString(),
                TenantOpeningBalance = Convert.ToDecimal( reader["OpeningBalance"])
            };
        }
        private Tenant _MapReaderToTenant(SqlDataReader reader)
        {
            return new Tenant
            {
                TenantID = (int)reader["TenantID"],

                RepresentativeName = reader["RepresentativeName"] == DBNull.Value ? "" : reader["RepresentativeName"].ToString(),
                RepresentativeNationalID = reader["RepresentativeNationalID"] == DBNull.Value ? "" : reader["RepresentativeNationalID"].ToString(),
                RepresentativeDate = reader["RepresentativeDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["RepresentativeDate"]),

                AgencyNumber = reader["AgencyNumber"] == DBNull.Value ? "" : reader["AgencyNumber"].ToString(),
                AgencyDate = reader["AgencyDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["AgencyDate"]),

                NationalityID = reader["NationalityID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["NationalityID"]),

                ClientRoleID = (int)reader["ClientRoleID"],
                NameOfConductor = reader["NameOfConductor"].ToString(),

                OpeningBalance = reader["OpeningBalance"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(reader["OpeningBalance"]),

                CreationDate = Convert.ToDateTime(reader["CreationDate"]),
                MovementType =(Tenant.enBalanceType)reader["MovementType"],
                TenantEvaluation = Convert.ToByte(reader["TenantEvaluation"]),

                Mode = Tenant.enMode.Update
            };
        }

        public TenantListDTO GetClientListItemById(int ClientID) 
        {

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetClientListItemById",
                    new SqlParameter("@ClientID", ClientID)))
                {

                    if (reader.HasRows)
                        return new TenantListDTO
                        {
                            TenantFullName = reader["FullName"].ToString(),
                            TenantNationalNo = reader["NationalNo"].ToString(),
                            TenantPhoneNumber = reader["PhoneNumber"].ToString(),
                            TenantOpeningBalance = Convert.ToDecimal(reader["OpeningBalance"])
                        };
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: TenantRepository | Method: GetClientListItemById | Exception: {ex}");
                return null;
            }
        }
    }
}
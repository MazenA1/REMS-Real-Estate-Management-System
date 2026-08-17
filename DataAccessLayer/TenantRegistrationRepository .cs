using Helpers;
using Interfaces;
using Models;
using Models.DTOs;
using REMS.UI.Form_Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TenantRegistrationRepository : ITenantRegistrationRepository
    {
        private readonly IAppLogger _logger;

        public TenantRegistrationRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        public int Add(TenantRegistrationData data)
        {
            try
            {
                SqlParameter[] parameters =
                {
                new SqlParameter("@ClientID", data.ClientRole.ClientID),
                new SqlParameter("@ClientRoleTypeID", data.ClientRole.ClientRoleTypeID),
                new SqlParameter("@CreatedByUserID", data.ClientRole.CreatedByUserID),
                new SqlParameter("@Notes", (object)data.ClientRole.Notes ?? DBNull.Value),

                new SqlParameter("@RepresentativeName",
                    (object)data.Tenant.RepresentativeName ?? DBNull.Value),

                new SqlParameter("@RepresentativeNationalID",
                    (object)data.Tenant.RepresentativeNationalID ?? DBNull.Value),

                new SqlParameter("@RepresentativeDate",
                    (object)data.Tenant.RepresentativeDate ?? DBNull.Value),

                new SqlParameter("@AgencyNumber",
                    (object)data.Tenant.AgencyNumber ?? DBNull.Value),

                new SqlParameter("@AgencyDate",
                    (object)data.Tenant.AgencyDate ?? DBNull.Value),

                new SqlParameter("@NationalityID",
                    (object)data.Tenant.NationalityID ?? DBNull.Value),

                new SqlParameter("@NameOfConductor",
                    data.Tenant.NameOfConductor),

                new SqlParameter("@OpeningBalance",
                    (object)data.Tenant.OpeningBalance ?? DBNull.Value),

                new SqlParameter("@MovementType",
                    data.Tenant.MovementType),

                new SqlParameter("@TenantEvaluation",
                    data.Tenant.TenantEvaluation)
            };

                object result = Helpers.SqlHelper.ExecuteScalar(
                    "SP_RegisterTenant",
                    parameters);

                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("", ex);

                return -1;
            }
        }

        public TenantListDTO GetClientListItemByClientRoleID(int ClientRoleID)
        {

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetClientListItemByClientRoleID",
                    new SqlParameter("@ClientRoleID", ClientRoleID))) 
                {

                    if (reader.Read())
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
                _logger.LogError($"Layer: DataAccess | Class: TenantRegistrationRepository | Method: GetClientListItemByClientRoleID | Exception: {ex}"); 
                return null;
            }
        }
    }
}

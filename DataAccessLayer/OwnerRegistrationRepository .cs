using Helpers;
using Interfaces;
using Models.DTOs;
using Models.FormData;
using REMS.UI.Form_Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class OwnerRegistrationRepository : IOwnerRegistrationRepository 
    {
        private readonly IAppLogger _logger;

        public OwnerRegistrationRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        public bool Add(OwnerFormData data) 
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
                    (object)data.Owner.RepresentativeName ?? DBNull.Value),

                new SqlParameter("@RepresentativeNationalID",
                    (object)data.Owner.RepresentativeNationalID ?? DBNull.Value),

                new SqlParameter("@RepresentativeDateOfBirth",
                    (object)data.Owner.RepresentativeDateOfBirth ?? DBNull.Value),

                new SqlParameter("@AgencyNumber",
                    (object)data.Owner.AgencyNumber ?? DBNull.Value),

                new SqlParameter("@AgencyDate",
                    (object)data.Owner.AgencyDate ?? DBNull.Value),

                new SqlParameter("@NationalityID",
                    (object)data.Owner.NationalityID ?? DBNull.Value),

                new SqlParameter("@NameOfConductor",
                    data.Owner.NameOfConductor),

                new SqlParameter("@OpeningBalance",
                    (object)data.Owner.OpeningBalance ?? DBNull.Value),

                new SqlParameter("@MovementType",
                    data.Owner.MovementType),
 
            };

                DataTable dt = Helpers.SqlHelper.ExecuteDataTable( 
                    "SP_RegisterOwner",
                    parameters);

                if (dt.Rows.Count > 0)
                {

                    DataRow row = dt.Rows[0];

                    data.Owner.OwnerID =
                        Convert.ToInt32(row["OwnerID"]);

                    data.ClientRole.ClientRoleID =
                        Convert.ToInt32(row["ClientRoleID"]);

                    return true;
                }

                else
                    return false;

            }
            catch (Exception ex)
            {
                _logger.LogError("", ex);

                return false;
            }
        }

        public OwnersListDTO GetClientListItemByClientRoleID(int ClientRoleID)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetOwnerListItemByClientRoleID",
                    new SqlParameter("@ClientRoleID", ClientRoleID)))
                {

                    if (reader.Read())
                        return new OwnersListDTO
                        {
                            OwnerFullName = reader["FullName"].ToString(),
                            OwnerNationalNo = reader["NationalNo"].ToString(),
                            OwnerPhoneNumber = reader["PhoneNumber"].ToString(),
                            OwnerOpeningBalance = Convert.ToDecimal(reader["OpeningBalance"])
                        };
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: OwnerRegistrationRepository | Method: GetClientListItemByClientRoleID | Exception: {ex}"); 
                return null;
            }
        }
    }
}

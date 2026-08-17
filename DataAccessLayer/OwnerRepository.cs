using Helpers;
using Interfaces;
using Models;
using Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly IAppLogger _logger;

        public OwnerRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        public int Add(Owner owner)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_AddNewOwner",
                    new SqlParameter("@ClientRoleID", owner.ClientRoleID),
                    new SqlParameter("@RepresentativeName", SqlHelper.ToDbValue(owner.RepresentativeName)),
                    new SqlParameter("@RepresentativeNationalID", SqlHelper.ToDbValue(owner.RepresentativeNationalID)),
                    new SqlParameter("@RepresentativePhone", SqlHelper.ToDbValue(owner.RepresentativePhone)),
                    new SqlParameter("@RepresentativeDateOfBirth", SqlHelper.ToDbValue(owner.RepresentativeDateOfBirth)),
                    new SqlParameter("@AgencyNumber", SqlHelper.ToDbValue(owner.AgencyNumber)),
                    new SqlParameter("@AgencyDate", SqlHelper.ToDbValue(owner.AgencyDate)),
                    new SqlParameter("@NationalityID", SqlHelper.ToDbValue(owner.NationalityID)),
                    new SqlParameter("@NameOfConductor", owner.NameOfConductor),
                    new SqlParameter("@OpeningBalance", SqlHelper.ToDbValue(owner.OpeningBalance)),
                    new SqlParameter("@CreationDate", owner.CreationDate),
                    new SqlParameter("@MovementType", owner.MovementType),
                    new SqlParameter("@CreatedByUserID", owner.CreatedByUserID)
                );

                return result != null && int.TryParse(result.ToString(), out int ownerID)
                    ? ownerID
                    : -1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: OwnerRepository | Method: Add | ClientRoleID: {owner?.ClientRoleID} | Exception: {ex}");
                return -1;
            }
        }

        public bool Update(Owner owner)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_UpdateOwner",
                    new SqlParameter("@OwnerID", owner.OwnerID),
                    new SqlParameter("@ClientRoleID", owner.ClientRoleID),
                    new SqlParameter("@RepresentativeName", SqlHelper.ToDbValue(owner.RepresentativeName)),
                    new SqlParameter("@RepresentativeNationalID", SqlHelper.ToDbValue(owner.RepresentativeNationalID)),
                    new SqlParameter("@RepresentativePhone", SqlHelper.ToDbValue(owner.RepresentativePhone)),
                    new SqlParameter("@RepresentativeDateOfBirth", SqlHelper.ToDbValue(owner.RepresentativeDateOfBirth)),
                    new SqlParameter("@AgencyNumber", SqlHelper.ToDbValue(owner.AgencyNumber)),
                    new SqlParameter("@AgencyDate", SqlHelper.ToDbValue(owner.AgencyDate)),
                    new SqlParameter("@NationalityID", SqlHelper.ToDbValue(owner.NationalityID)),
                    new SqlParameter("@NameOfConductor", owner.NameOfConductor),
                    new SqlParameter("@OpeningBalance", SqlHelper.ToDbValue(owner.OpeningBalance)),
                    new SqlParameter("@CreationDate", owner.CreationDate),
                    new SqlParameter("@MovementType", owner.MovementType),
                    new SqlParameter("@CreatedByUserID", owner.CreatedByUserID)
                );

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: OwnerRepository | Method: Update | OwnerID: {owner?.OwnerID} | Exception: {ex}");
                return false;
            }
        }

        public bool Delete(int ownerID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_DeleteOwner",
                    new SqlParameter("@OwnerID", ownerID));

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: OwnerRepository | Method: Delete | OwnerID: {ownerID} | Exception: {ex}");
                return false;
            }
        }

        public Owner GetByID(int ownerID)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetOwnerByID",
                    new SqlParameter("@OwnerID", ownerID)))
                {
                    if (reader.Read())
                        return _MapReaderToOwner(reader);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: OwnerRepository | Method: GetByID | OwnerID: {ownerID} | Exception: {ex}");
                return null;
            }
        }

        public Owner GetByClientRoleID(int clientRoleID)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetOwnerByClientRoleID",
                    new SqlParameter("@ClientRoleID", clientRoleID)))
                {
                    if (reader.Read())
                        return _MapReaderToOwner(reader);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: OwnerRepository | Method: GetByClientRoleID | ClientRoleID: {clientRoleID} | Exception: {ex}");
                return null;
            }
        }

        public List<Owner> GetAll()
        {
            List<Owner> list = new List<Owner>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllOwners"))
                {
                    while (reader.Read())
                        list.Add(_MapReaderToOwner(reader));
                }

                return list;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: OwnerRepository | Method: GetAll | Exception: {ex}");
                return null;
            }
        }

        public bool Exists(int ownerID)
        {
            object result = SqlHelper.ExecuteScalar(
                "SP_IsOwnerExist",
                new SqlParameter("@OwnerID", ownerID));

            return result != null && Convert.ToInt32(result) == 1;
        }

        public bool ExistsByClientRoleID(int clientRoleID)
        {
            object result = SqlHelper.ExecuteScalar(
                "SP_IsOwnerExistByClientRoleID",
                new SqlParameter("@ClientRoleID", clientRoleID));

            return result != null && Convert.ToInt32(result) == 1;
        }

        private Owner _MapReaderToOwner(SqlDataReader reader)
        {
            return new Owner
            {
                OwnerID = (int)reader["OwnerID"],
                ClientRoleID = (int)reader["ClientRoleID"],

                RepresentativeName = reader["RepresentativeName"] == DBNull.Value ? "" : reader["RepresentativeName"].ToString(),
                RepresentativeNationalID = reader["RepresentativeNationalID"] == DBNull.Value ? "" : reader["RepresentativeNationalID"].ToString(),
                RepresentativePhone = reader["RepresentativePhone"] == DBNull.Value ? "" : reader["RepresentativePhone"].ToString(),
                RepresentativeDateOfBirth = reader["RepresentativeDateOfBirth"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["RepresentativeDateOfBirth"]),

                AgencyNumber = reader["AgencyNumber"] == DBNull.Value ? "" : reader["AgencyNumber"].ToString(),
                AgencyDate = reader["AgencyDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["AgencyDate"]),

                NationalityID = reader["NationalityID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["NationalityID"]),

                NameOfConductor = reader["NameOfConductor"].ToString(),
                OpeningBalance = reader["OpeningBalance"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(reader["OpeningBalance"]),

                CreationDate = Convert.ToDateTime(reader["CreationDate"]),
                MovementType = (Owner.enBalanceType)reader["MovementType"],
                CreatedByUserID = (int)reader["CreatedByUserID"],

                Mode = Owner.enMode.Update
            };
        }

        public int GetOwnersCount()
        {
            try
            {
                object result = SqlHelper.ExecuteScalar("SP_GetOwnersCount");
                return result == null ? 0 : Convert.ToInt32(result);
            }

            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: OwnerRepository | Method: GetOwnersCount | Exception: {ex}");
                return -1;
            }
        }
        public OwnerCardDTO GetOwnerCardByOwnerID(int ownerID)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetOwnerCardByOwnerID",
                    new SqlParameter("@OwnerID", ownerID)))
                {
                    if (reader.Read())
                        return _MapReaderToOwnerCardDTO(reader);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"Layer: DataAccess | Class: OwnerRepository | Method: GetOwnerCardByOwnerID | OwnerID: {ownerID} | Exception: {ex}");

                return null;
            }
        }
        private OwnerCardDTO _MapReaderToOwnerCardDTO(SqlDataReader reader)
        {
            return new OwnerCardDTO
            {
                OwnerID = Convert.ToInt32(reader["OwnerID"]),
                ClientRoleID = Convert.ToInt32(reader["ClientRoleID"]),
                ClientID = Convert.ToInt32(reader["ClientID"]),
                PersonID = Convert.ToInt32(reader["PersonID"]),

                OwnerName = reader["OwnerName"] == DBNull.Value ? "" : reader["OwnerName"].ToString(),
                OwnerNationalNo = reader["OwnerNationalNo"] == DBNull.Value ? "" : reader["OwnerNationalNo"].ToString(),
                OwnerPhone = reader["OwnerPhone"] == DBNull.Value ? "" : reader["OwnerPhone"].ToString(),

                RepresentativeName = reader["RepresentativeName"] == DBNull.Value ? "" : reader["RepresentativeName"].ToString(),
                RepresentativeNationalID = reader["RepresentativeNationalID"] == DBNull.Value ? "" : reader["RepresentativeNationalID"].ToString(),
                RepresentativePhone = reader["RepresentativePhone"] == DBNull.Value ? "" : reader["RepresentativePhone"].ToString(),

                RepresentativeDateOfBirth =
                    reader["RepresentativeDateOfBirth"] == DBNull.Value
                        ? (DateTime?)null
                        : Convert.ToDateTime(reader["RepresentativeDateOfBirth"]),

                AgencyNumber = reader["AgencyNumber"] == DBNull.Value ? "" : reader["AgencyNumber"].ToString(),

                AgencyDate =
                    reader["AgencyDate"] == DBNull.Value
                        ? (DateTime?)null
                        : Convert.ToDateTime(reader["AgencyDate"]),

                NationalityID =
                    reader["NationalityID"] == DBNull.Value
                        ? (int?)null
                        : Convert.ToInt32(reader["NationalityID"]),

                NameOfConductor = reader["NameOfConductor"] == DBNull.Value ? "" : reader["NameOfConductor"].ToString(),

                OpeningBalance =
                    reader["OpeningBalance"] == DBNull.Value
                        ? (decimal?)null
                        : Convert.ToDecimal(reader["OpeningBalance"]),

                MovementType = Convert.ToBoolean(reader["MovementType"])
                ? Owner.enBalanceType.Creditor
                : Owner.enBalanceType.Debtor,

                CreationDate = Convert.ToDateTime(reader["CreationDate"]),
                CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"])
            };
        }

        private OwnersListDTO _MapOwnerToDTO(IDataRecord reader)
        {
            return new OwnersListDTO
            {
                OwnerFullName = reader["FullName"].ToString(),
                OwnerPhoneNumber = reader["PhoneNumber"].ToString(),
                OwnerNationalNo = reader["NationalNo"].ToString(),
                OwnerOpeningBalance = Convert.ToDecimal(reader["OpeningBalance"])
            };
        }

        public BindingList<OwnersListDTO> GetAllOwnersList()
        {
            BindingList<OwnersListDTO> listDTOs = new BindingList<OwnersListDTO>();

            try
            {

                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetOwnersList"))
                {
                    while (reader.Read())
                        listDTOs.Add(_MapOwnerToDTO(reader));
                }

                return listDTOs;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: OwnerRepository | Method: GetAllOwnersList | Exception: {ex}"); 
                return null;
            }
        }
    }
}
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
    public class ClientRoleRepository : IClientRoleRepository
    {
        private readonly IAppLogger _logger;

        public ClientRoleRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        public int Add(ClientRole clientRole)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_AddNewClientRole",
                    new SqlParameter("@ClientID", clientRole.ClientID),
                    new SqlParameter("@ClientRoleTypeID", clientRole.ClientRoleTypeID),
                    new SqlParameter("@CreatedDate", clientRole.CreatedDate),
                    new SqlParameter("@CreatedByUserID", clientRole.CreatedByUserID),
                    new SqlParameter("@IsActive", clientRole.IsActive),
                    new SqlParameter("@Notes", SqlHelper.ToDbValue(clientRole.Notes))
                );

                return result != null && int.TryParse(result.ToString(), out int clientRoleID)
                    ? clientRoleID
                    : -1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRoleRepository | Method: Add | ClientID: {clientRole?.ClientID} | Exception: {ex}");
                return -1;
            }
        }

        public bool Update(ClientRole clientRole)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_UpdateClientRole",
                    new SqlParameter("@ClientRoleID", clientRole.ClientRoleID),
                    new SqlParameter("@ClientID", clientRole.ClientID),
                    new SqlParameter("@ClientRoleTypeID", clientRole.ClientRoleTypeID),
                    new SqlParameter("@CreatedDate", clientRole.CreatedDate),
                    new SqlParameter("@CreatedByUserID", clientRole.CreatedByUserID),
                    new SqlParameter("@IsActive", clientRole.IsActive),
                    new SqlParameter("@Notes", SqlHelper.ToDbValue(clientRole.Notes))
                );

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRoleRepository | Method: Update | ClientRoleID: {clientRole?.ClientRoleID} | Exception: {ex}");
                return false;
            }
        }

        public bool Delete(int clientRoleID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_DeleteClientRole",
                    new SqlParameter("@ClientRoleID", clientRoleID)
                );

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRoleRepository | Method: Delete | ClientRoleID: {clientRoleID} | Exception: {ex}");
                return false;
            }
        }

        public ClientRole GetByID(int clientRoleID)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetClientRoleByID",
                    new SqlParameter("@ClientRoleID", clientRoleID)))
                {
                    if (reader.Read())
                        return _MapReaderToClientRole(reader);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRoleRepository | Method: GetByID | ClientRoleID: {clientRoleID} | Exception: {ex}");
                return null;
            }
        }

        public List<ClientRole> GetByClientID(int clientID)
        {
            List<ClientRole> list = new List<ClientRole>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetClientRolesByClientID",
                    new SqlParameter("@ClientID", clientID)))
                {
                    while (reader.Read())
                    {
                        list.Add(_MapReaderToClientRole(reader));
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRoleRepository | Method: GetByClientID | ClientID: {clientID} | Exception: {ex}");
                return null;
            }
        }

        public List<ClientRole> GetAll()
        {
            List<ClientRole> list = new List<ClientRole>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllClientRoles"))
                {
                    while (reader.Read())
                    {
                        list.Add(_MapReaderToClientRole(reader));
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRoleRepository | Method: GetAll | Exception: {ex}");
                return null;
            }
        }

        public bool Exists(int clientRoleID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_IsClientRoleExist",
                    new SqlParameter("@ClientRoleID", clientRoleID)
                );

                return result != null && Convert.ToInt32(result) == 1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRoleRepository | Method: Exists | ClientRoleID: {clientRoleID} | Exception: {ex}");
                return false;
            }
        }

        public bool ExistsByClientAndRoleType(int clientID, byte clientRoleTypeID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_IsClientRoleExistByClientAndRoleType",
                    new SqlParameter("@ClientID", clientID),
                    new SqlParameter("@ClientRoleTypeID", clientRoleTypeID)
                );

                return result != null && Convert.ToInt32(result) == 1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRoleRepository | Method: ExistsByClientAndRoleType | ClientID: {clientID} | RoleTypeID: {clientRoleTypeID} | Exception: {ex}");
                return false;
            }
        }

        private ClientRole _MapReaderToClientRole(SqlDataReader reader)
        {
            return new ClientRole
            {
                ClientRoleID = (int)reader["ClientRoleID"],
                ClientID = (int)reader["ClientID"],
                ClientRoleTypeID = Convert.ToByte(reader["ClientRoleTypeID"]),
                CreatedDate = (DateTime)reader["CreatedDate"],
                CreatedByUserID = (int)reader["CreatedByUserID"],
                IsActive = Convert.ToByte(reader["IsActive"]),
                Notes = reader["Notes"] == DBNull.Value ? "" : reader["Notes"].ToString(),
                Mode = ClientRole.enMode.Update
            };
        }

        public BindingList<ClientListDTO> GetAllClientsList()
        {
            BindingList<ClientListDTO> clients = new BindingList<ClientListDTO>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllClientsRolesList"))
                {
                    while (reader.Read())
                    {
                        clients.Add(new ClientListDTO
                        {
                            ClientID = Convert.ToInt32(reader["ClientID"]),
                            FullName = reader["FullName"].ToString(),
                            ClientTypeName = reader["ClientTypeName"].ToString(),
                            NationalNo = reader["NationalNo"].ToString(),
                            PhoneNumber = reader["PhoneNumber"] == DBNull.Value ? "" : reader["PhoneNumber"].ToString()
                        });
                    }
                }

                return clients;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRepository | Method: GetAllClientsList | Exception: {ex}");
                return null;
            }
        }

        public ClientListDTO GetClientItemInfoByNationalNo(string NationalNo)
        {
            ClientListDTO clientListDTO = new ClientListDTO();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetClientListItemByNationalNo", new SqlParameter("@NationalNo", NationalNo)))
                {
                    if (reader.Read())
                    {
                        clientListDTO.ClientID = Convert.ToInt32(reader["ClientID"]);
                        clientListDTO.FullName = reader["FullName"].ToString();
                        clientListDTO.PhoneNumber = reader["PhoneNumber"].ToString();
                        clientListDTO.NationalNo = reader["NationalNo"].ToString();
                        clientListDTO.ClientTypeName = reader["RoleNameAr"].ToString();
                    }

                    return clientListDTO;
                }
            }

            catch (Exception ex) 
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRepository | Method: GetClientItemInfoByNationalNo | Exception: {ex}");
                return null;
            }
        }
    }
}
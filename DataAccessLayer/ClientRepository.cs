using Helpers;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ClientRepository : IClientRepository
    {
        private readonly IAppLogger _logger;

        public ClientRepository(IAppLogger logger)
        {
            _logger = logger;
        }

        public int Add(Client client)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_AddNewClient",
                    new SqlParameter("@PersonID", client.PersonID),
                    new SqlParameter("@ClientTypeID", client.ClientTypeID),
                    new SqlParameter("@CreatedDate", client.CreatedDate),
                    new SqlParameter("@CreatedByUserID", client.CreatedByUserID),
                    new SqlParameter("@IsActive", client.IsActive),
                    new SqlParameter("@Notes", SqlHelper.ToDbValue(client.Notes))
                );

                return result != null && int.TryParse(result.ToString(), out int clientID)
                    ? clientID
                    : -1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRepository | Method: Add | PersonID: {client?.PersonID} | Exception: {ex}");
                return -1;
            }
        }

        public int GetClientsCount()
        {
            try
            {
                object result = SqlHelper.ExecuteScalar("SP_GetClientsCount");
                return result == null ? 0 : Convert.ToInt32(result);
            }

            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRepository | Method: GetClientsCount | Exception: {ex}");
                return -1;
            }
        }

        public bool Update(Client client)
        {
            try
            {
                object result = SqlHelper.ExecuteNonQuery(
                    "SP_UpdateClient",
                    new SqlParameter("@ClientID", client.ClientID),
                    new SqlParameter("@PersonID", client.PersonID),
                    new SqlParameter("@ClientTypeID", client.ClientTypeID),
                    new SqlParameter("@CreatedDate", client.CreatedDate),
                    new SqlParameter("@CreatedByUserID", client.CreatedByUserID),
                    new SqlParameter("@IsActive", client.IsActive),
                    new SqlParameter("@Notes", SqlHelper.ToDbValue(client.Notes))
                );

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRepository | Method: Update | ClientID: {client?.ClientID} | Exception: {ex}");
                return false;
            }
        }

        public bool Delete(int clientID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_DeleteClient",
                    new SqlParameter("@ClientID", clientID)
                );

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRepository | Method: Delete | ClientID: {clientID} | Exception: {ex}");
                return false;
            }
        }

        public Client GetByID(int clientID)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetClientByID",
                    new SqlParameter("@ClientID", clientID)))
                {
                    if (reader.Read())
                        return _MapReaderToClient(reader);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRepository | Method: GetByID | ClientID: {clientID} | Exception: {ex}");
                return null;
            }
        }

        public Client GetByPersonID(int personID)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetClientByPersonID",
                    new SqlParameter("@PersonID", personID)))
                {
                    if (reader.Read())
                        return _MapReaderToClient(reader);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRepository | Method: GetByPersonID | PersonID: {personID} | Exception: {ex}");
                return null;
            }
        }
        public Client GetByNationalNo(string NationalNo)
        {
            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader(
                    "SP_GetClientByNationalNo",
                    new SqlParameter("@NationalNo", NationalNo)))
                {
                    if (reader.Read())
                        return _MapReaderToClient(reader);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRepository | Method: GetByNationalNo | Exception: {ex}");
                return null;
            }
        }

        public List<Client> GetAll()
        {
            List<Client> clients = new List<Client>();

            try
            {
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SP_GetAllClients"))
                {
                    while (reader.Read())
                    {
                        clients.Add(_MapReaderToClient(reader));
                    }
                }

                return clients;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRepository | Method: GetAll | Exception: {ex}");
                return null;
            }
        }

        public bool Exists(int clientID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_IsClientExist",
                    new SqlParameter("@ClientID", clientID)
                );

                return result != null && Convert.ToInt32(result) == 1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRepository | Method: Exists | ClientID: {clientID} | Exception: {ex}");
                return false;
            }
        }

        public bool ExistsByPersonID(int personID)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(
                    "SP_IsClientExistByPersonID",
                    new SqlParameter("@PersonID", personID)
                );

                return result != null && Convert.ToInt32(result) == 1;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Layer: DataAccess | Class: ClientRepository | Method: ExistsByPersonID | PersonID: {personID} | Exception: {ex}");
                return false;
            }
        }

        private Client _MapReaderToClient(SqlDataReader reader)
        {
            return new Client
            {
                ClientID = (int)reader["ClientID"],
                PersonID = (int)reader["PersonID"],
                ClientTypeID = (int)reader["ClientTypeID"],
                CreatedDate = (DateTime)reader["CreatedDate"],
                CreatedByUserID = (int)reader["CreatedByUserID"],
                IsActive = Convert.ToByte(reader["IsActive"]),
                Notes = reader["Notes"] == DBNull.Value ? "" : reader["Notes"].ToString(),
                Mode = Client.enMode.Update
            };
        }
    }
}
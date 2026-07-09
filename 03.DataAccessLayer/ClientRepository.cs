using Helpers;
using Interfaces;
using Microsoft.Data.SqlClient;
using Models;

namespace DataAccessLayer
{
    public class ClientRepository : IClientRepository
    {
        public int Add(Client client)
        {
            int clientID = -1;

            object Result = SqlHelper.ExecuteScalar("SP_AddClient",
                new("@FullName", SqlHelper.ToDbValue(client.FullName)),
                new("@NationalID", SqlHelper.ToDbValue(client.NationalNo)),
                new("@PhoneNumber", SqlHelper.ToDbValue(client.PhoneNumber)),
                new("@TaxNumber", SqlHelper.ToDbValue(client.TaxNumber)),
                new("@AnotherPhone", SqlHelper.ToDbValue(client.AnotherPhone)),
                new("@Email", SqlHelper.ToDbValue(client.Email)),
                new("@DateOfBirth", SqlHelper.ToDbValue(client.DateOfBirth)),
                new("@Gendor", SqlHelper.ToDbValue(client.Gendor)),
                new("@NameEnglish", SqlHelper.ToDbValue(client.NameEnglish)),
                new("@NationaltyCountryID", SqlHelper.ToDbValue(client.NationalityCountryID)),
                new("@ImagePath", SqlHelper.ToDbValue(client.ImagePath)),
                new("@IDPhotoPath", SqlHelper.ToDbValue(client.IdPhotoPath))
                );

            if (Result != null)
                clientID = Convert.ToInt32(Result);

            return clientID;
        }
        public bool Update(Client client)
        {
            int rowsAffected = 0;

            rowsAffected = SqlHelper.ExecuteNoneQuery("SP_UpdateClient",
                new("@ClientID", SqlHelper.ToDbValue(client.ClientID)),
                new("@FullName", SqlHelper.ToDbValue(client.FullName)),
                new("@NationalID", SqlHelper.ToDbValue(client.NationalNo)),
                new("@PhoneNumber", SqlHelper.ToDbValue(client.PhoneNumber)),
                new("@TaxNumber", SqlHelper.ToDbValue(client.TaxNumber)),
                new("@AnotherPhone", SqlHelper.ToDbValue(client.AnotherPhone)),
                new("@Email", SqlHelper.ToDbValue(client.Email)),
                new("@DateOfBirth", SqlHelper.ToDbValue(client.DateOfBirth)),
                new("@Gendor", SqlHelper.ToDbValue(client.Gendor)),
                new("@NameEnglish", SqlHelper.ToDbValue(client.NameEnglish)),
                new("@NationaltyCountryID", SqlHelper.ToDbValue(client.NationalityCountryID)),
                new("@ImagePath", SqlHelper.ToDbValue(client.ImagePath)),
                new("@IDPhotoPath", SqlHelper.ToDbValue(client.IdPhotoPath))
                );


            return (rowsAffected > 0);
        }
        public bool Delete(int clientID)
        {
            int rowsAffected = 0;

            rowsAffected = SqlHelper.ExecuteNoneQuery("SP_DeleteClient",
                new SqlParameter("@ClientID", clientID));

            return rowsAffected > 0;
        }
        public List<Client> GetAll()
        {
            List<Client> clients = new List<Client>();

            //using (SqlDataReader reader =
            //    SqlHelper.ExecuteReader("SP_GetAllClients"))
            //{
            //    while (reader.Read())
            //    {
            //        Client client = new Client
            //        {
            //            ClientID = (int)reader["ClientID"],
            //            FullName = reader["FullName"].ToString(),
            //            NationalNo = reader["NationalNo"].ToString(),
            //            PhoneNumber = reader["PhoneNumber"].ToString(),
            //            TaxNumber = reader["TaxNumber"].ToString(),
            //            DescribeClientID = (int)reader["DescribeClientID"],
            //            ClientTypeID = (int)reader["ClientTypeID"],
            //            NameEnglish = reader["NameEnglish"].ToString(),
            //            NationalityCountryID = (int)reader["NationalityCountryID"],
            //            ImagePath = reader["ImagePath"] == DBNull.Value
            //                ? ""
            //                : reader["ImagePath"].ToString()
            //        };

            //        clients.Add(client);
            //    }
            //}

            return clients;
        }
        public Client FindByID(int clientID)
        {
            Client client = null;

            return client;
        }
    }
}

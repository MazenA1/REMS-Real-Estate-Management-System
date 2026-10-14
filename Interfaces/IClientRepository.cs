using Models;
using Models.DTOs;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IClientRepository
    {
        int Add(Client client);
        int GetClientsCount();
        bool Update(Client client);
        bool Delete(int clientID);

        Client GetByID(int clientID);
        Client GetByPersonID(int personID);
        Client GetByNationalNo(string NationalNo);

        /// <summary>
        /// Retrieves the client card information
        /// for the specified client.
        /// </summary>
        /// <param name="clientID">
        /// The ID of the client whose information will be retrieved.
        /// </param>
        /// <returns>
        /// A <see cref="ClientCardInfoDTO"/> containing the client information,
        /// or null if no matching client is found.
        /// </returns>
        ClientCardInfoDTO GetClientCardInfoByID(int clientID);

        /// <summary>
        /// Retrieves the client card information
        /// associated whit the specified person.
        /// </summary>
        /// <param name="personID">
        /// The ID of the person whose client information will be retrieved.
        /// </param>
        /// <returns>
        /// A <see cref="ClientCardInfoDTO"/> if the person is registered as a client;
        /// otherwise, null.
        /// </returns>
        ClientCardInfoDTO GetClientCardInfoByPersonID(int personID);
        List<Client> GetAll();

        bool Exists(int clientID);
        bool ExistsByPersonID(int personID);
    }
}
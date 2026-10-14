using Models;
using Models.DTOs;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IClientService
    {

        event Action ClientAdded;

        int GetCount();
        bool Save(Client client);
        bool Delete(int clientID);

        Client GetByID(int clientID);
        Client GetByPersonID(int personID);
        Client GetByNationalNo(string NationalNo);

        /// <summary>
        /// Gets the basic client information for the specified client.
        /// </summary>
        /// <param name="clientID">
        /// The ID of the client to retrieve.
        /// </param>
        /// <returns>
        /// A <see cref="ClientCardInfoDTO"/> if the client exists;
        /// otherwise, null.
        /// </returns>
        ClientCardInfoDTO GetClientCardInfoByID(int clientID);

        /// <summary>
        /// Gets the client information associated
        /// With the speciefed person.
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
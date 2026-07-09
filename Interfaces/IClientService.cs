using Models;
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

        List<Client> GetAll();

        bool Exists(int clientID);
        bool ExistsByPersonID(int personID);
    }
}
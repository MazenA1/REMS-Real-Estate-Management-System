using Models;
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
        List<Client> GetAll();

        bool Exists(int clientID);
        bool ExistsByPersonID(int personID);
    }
}
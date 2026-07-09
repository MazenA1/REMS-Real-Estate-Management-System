using Models;
namespace Interfaces
{
    public interface IClientRepository
    {
        int Add(Client client);

        bool Update(Client client);

        bool Delete(int clientID);

        Client FindByID(int clientID);

        List<Client> GetAll();
    }
}

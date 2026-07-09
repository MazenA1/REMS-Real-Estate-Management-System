using Interfaces;
using Models;

namespace Services
{
    public class ClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository _clientRepository)
        {
            this._clientRepository = _clientRepository;
        }
        private bool _Add(Client client)
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            return _clientRepository.Add(client) != -1;
        }

        private bool _Update(Client client)
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            if (client.ClientID <= 0)
                throw new ArgumentException("Invalid Client ID");

            return _clientRepository.Update(client);
        }
        public bool Delete(int clientID)
        {
            if (clientID <= 0)
                throw new ArgumentException("Invalid Client ID");

            return _clientRepository.Delete(clientID);
        }

        public List<Client> GetAllClients()
        {
            return _clientRepository.GetAll();
        }

        public Client GetClientByID(int clientID)
        {
            if (clientID <= 0)
                throw new Exception("Invalid Client ID");

            return _clientRepository.FindByID(clientID);
        }
        public bool Save(Client client)
        {
            switch (client.Mode)
            {
                case Client.enMode.AddNew:
                    if (_Add(client))
                    {
                        client.Mode = Client.enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case Client.enMode.Update:
                    return _Update(client);
            }

            return false;
        }
    }
}

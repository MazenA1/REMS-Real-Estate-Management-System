using Interfaces;
using Models;
using System;
using System.Collections.Generic;

namespace Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public event Action ClientAdded;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        private bool _AddClient(Client client)
        {
            int clientID = _clientRepository.Add(client);

            if (clientID != -1)
            {
                client.ClientID = clientID;
                ClientAdded?.Invoke();
                return true;
            }

            return false;
        }

        private bool _UpdateClient(Client client)
        {
            return _clientRepository.Update(client);
        }

        public bool Save(Client client)
        {
            switch (client.Mode)
            {
                case Client.enMode.AddNew:
                    if (_AddClient(client))
                    {
                        client.Mode = Client.enMode.Update;
                        return true;
                    }

                    return false;

                case Client.enMode.Update:
                    return _UpdateClient(client);
            }

            return false;
        }

        public bool Delete(int clientID)
        {
            return _clientRepository.Delete(clientID);
        }

        public Client GetByID(int clientID)
        {
            return _clientRepository.GetByID(clientID);
        }
        public Client GetByNationalNo(string NationalNo)
        {
            return _clientRepository.GetByNationalNo(NationalNo);
        }
        public Client GetByPersonID(int personID)
        {
            return _clientRepository.GetByPersonID(personID);
        }

        public List<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public bool Exists(int clientID)
        {
            return _clientRepository.Exists(clientID);
        }

        public bool ExistsByPersonID(int personID)
        {
            return _clientRepository.ExistsByPersonID(personID);
        }
        public int GetCount()
        {
            return _clientRepository.GetClientsCount();
        }
    }
}
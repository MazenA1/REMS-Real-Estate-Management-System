using Interfaces;
using Models;
using Models.DTOs;
using System;
using System.Collections.Generic;

namespace Services
{
    public class ClientRoleService : IClientRoleService
    {
        private readonly IClientRoleRepository _clientRoleRepository;

        public ClientRoleService(IClientRoleRepository clientRoleRepository)
        {
            _clientRoleRepository = clientRoleRepository;
        }

        private bool _AddClientRole(ClientRole clientRole)
        {
            int clientRoleID = _clientRoleRepository.Add(clientRole);

            if (clientRoleID != -1)
            {
                clientRole.ClientRoleID = clientRoleID;
                return true;
            }

            return false;
        }

        private bool _UpdateClientRole(ClientRole clientRole)
        {
            return _clientRoleRepository.Update(clientRole);
        }

        public bool Save(ClientRole clientRole)
        {
            if (clientRole == null)
                return false;

            switch (clientRole.Mode)
            {
                case ClientRole.enMode.AddNew:
                    if (_AddClientRole(clientRole))
                    {
                        clientRole.Mode = ClientRole.enMode.Update;
                        return true;
                    }

                    return false;

                case ClientRole.enMode.Update:
                    return _UpdateClientRole(clientRole);
            }

            return false;
        }

        public bool Delete(int clientRoleID)
        {
            return _clientRoleRepository.Delete(clientRoleID);
        }

        public ClientRole GetByID(int clientRoleID)
        {
            return _clientRoleRepository.GetByID(clientRoleID);
        }

        public List<ClientRole> GetByClientID(int clientID)
        {
            return _clientRoleRepository.GetByClientID(clientID);
        }

        public List<ClientRole> GetAll()
        {
            return _clientRoleRepository.GetAll();
        }

        public List<ClientListDTO> GetAllClientsList()
        {
            return _clientRoleRepository.GetAllClientsList();
        }
        public bool Exists(int clientRoleID)
        {
            return _clientRoleRepository.Exists(clientRoleID);
        }

        public bool ExistsByClientAndRoleType(int clientID, byte clientRoleTypeID)
        {
            return _clientRoleRepository.ExistsByClientAndRoleType(clientID, clientRoleTypeID);
        }
    }
}
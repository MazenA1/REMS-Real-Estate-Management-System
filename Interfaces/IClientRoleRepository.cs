using Models;
using Models.DTOs;
using System.Collections.Generic;
using System.ComponentModel;

namespace Interfaces
{
    public interface IClientRoleRepository
    {
        int Add(ClientRole clientRole);
        bool Update(ClientRole clientRole);
        bool Delete(int clientRoleID);

        ClientRole GetByID(int clientRoleID);
        List<ClientRole> GetByClientID(int clientID);
        List<ClientRole> GetAll();

        bool Exists(int clientRoleID);
        bool ExistsByClientAndRoleType(int clientID, byte clientRoleTypeID);
        BindingList<ClientListDTO> GetAllClientsList();
    }
}
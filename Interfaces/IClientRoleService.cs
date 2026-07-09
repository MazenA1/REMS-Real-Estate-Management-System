using Models;
using Models.DTOs;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IClientRoleService
    {
        bool Save(ClientRole clientRole);
        bool Delete(int clientRoleID);

        ClientRole GetByID(int clientRoleID);
        List<ClientRole> GetByClientID(int clientID);
        List<ClientRole> GetAll();
        List<ClientListDTO> GetAllClientsList();
        bool Exists(int clientRoleID);
        bool ExistsByClientAndRoleType(int clientID, byte clientRoleTypeID);
    }
}
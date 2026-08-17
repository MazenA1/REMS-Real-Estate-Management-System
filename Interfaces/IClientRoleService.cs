using Models;
using Models.DTOs;
using System.Collections.Generic;
using System.ComponentModel;

namespace Interfaces
{
    public interface IClientRoleService
    {
        bool Save(ClientRole clientRole);
        bool Delete(int clientRoleID);

        ClientRole GetByID(int clientRoleID);
        List<ClientRole> GetByClientID(int clientID);
        List<ClientRole> GetAll();
        BindingList<ClientListDTO> GetAllClientsList();


        ClientListDTO GetClientItemInfoByNationalNo(string NatioanlNo);

        bool Exists(int clientRoleID);
        bool ExistsByClientAndRoleType(int clientID, byte clientRoleTypeID);
    }
}
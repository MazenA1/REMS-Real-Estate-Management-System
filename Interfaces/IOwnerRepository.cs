using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.DTOs;
namespace Interfaces
{
    public interface IOwnerRepository
    {
        int Add(Owner owner);
        int GetOwnersCount(); 
        bool Update(Owner owner);
        bool Delete(int ownerID);

        Owner GetByID(int ownerID);
        Owner GetByClientRoleID(int clientRoleID);

        OwnerCardDTO GetOwnerCardByOwnerID(int OwnerID);

        List <Owner> GetAll();

        bool Exists(int ownerID);
        bool ExistsByClientRoleID(int clientRoleID);
    }
}

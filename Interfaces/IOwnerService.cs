using Models;
using Models.DTOs;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IOwnerService
    {
        event Action OwnerAdded;


        bool Save(Owner owner);
        bool Delete(int ownerID);

        int GetCount();

        Owner GetByID(int ownerID);
        Owner GetByClientRoleID(int clientRoleID);

        OwnerCardDTO GetOwnerCardByID(int ownerID);
        OwnerCardDTO GetOwnerCardByNationalNo(string nationalNo);

        List<Owner> GetAll();

        bool Exists(int ownerID);
        bool ExistsByClientRoleID(int clientRoleID);
    }
}
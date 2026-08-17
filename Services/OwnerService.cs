using Interfaces;
using Models;
using Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Services
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _ownerRepository;

        public event Action OwnerAdded; 

        public OwnerService(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        private bool _AddOwner(Owner owner)
        {
            int ownerID = _ownerRepository.Add(owner);

            if (ownerID != -1)
            {
                owner.OwnerID = ownerID;
                OwnerAdded?.Invoke();
                return true;
            }

            return false;
        }

        private bool _UpdateOwner(Owner owner)
        {
            return _ownerRepository.Update(owner);
        }

        public bool Save(Owner owner)
        {
            if (owner == null)
                return false;

            switch (owner.Mode)
            {
                case Owner.enMode.AddNew:
                    if (_AddOwner(owner))
                    {
                        owner.Mode = Owner.enMode.Update;
                        return true;
                    }

                    return false;

                case Owner.enMode.Update:
                    return _UpdateOwner(owner);
            }

            return false;
        }

        public bool Delete(int ownerID)
        {
            return _ownerRepository.Delete(ownerID);
        }

        public Owner GetByID(int ownerID)
        {
            return _ownerRepository.GetByID(ownerID);
        }

        public Owner GetByClientRoleID(int clientRoleID)
        {
            return _ownerRepository.GetByClientRoleID(clientRoleID);
        }

        public List<Owner> GetAll()
        {
            return _ownerRepository.GetAll();
        }

        public bool Exists(int ownerID)
        {
            return _ownerRepository.Exists(ownerID);
        }

        public bool ExistsByClientRoleID(int clientRoleID)
        {
            return _ownerRepository.ExistsByClientRoleID(clientRoleID);
        }
        public int GetCount()
        {
            return _ownerRepository.GetOwnersCount();
        }
        public OwnerCardDTO GetOwnerCardByID(int ownerID)
        {
            return _ownerRepository.GetOwnerCardByOwnerID(ownerID); 
        }

        public OwnerCardDTO GetOwnerCardByNationalNo(string nationalNo)
        {
            return null; // Letar Added
        }

        public BindingList<OwnersListDTO> GetAllOwnersList()
        {
            return _ownerRepository.GetAllOwnersList();
        }
    }
}
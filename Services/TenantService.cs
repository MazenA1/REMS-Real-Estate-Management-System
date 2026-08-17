using Interfaces;
using Models;
using Models.DTOs;
using Models.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Services
{
    public class TenantService : ITenantService
    {
        private readonly ITenantRepository _tenantRepository;

        public event Action TenantAdded;

        public event EventHandler<TenantRegisteredEventArgs> TenantRegistered; 

        public TenantService(ITenantRepository tenantRepository)
        {
            this._tenantRepository = tenantRepository;
        }

        private bool _AddTenant(Tenant tenant)
        {
            int tenantID = _tenantRepository.Add(tenant);

            if (tenantID != -1)
            {
                tenant.TenantID = tenantID;
                TenantRegistered?.Invoke(this, new TenantRegisteredEventArgs(GetClientListItemById(tenantID))); 
                return true;
            }

            return false;
        }

        private bool _UpdateTenant(Tenant tenant)
        {
            return _tenantRepository.Update(tenant);
        }

        public bool Save(Tenant tenant)
        {
            if (tenant == null)
                return false;

            switch (tenant.Mode)
            {
                case Tenant.enMode.AddNew:
                    if (_AddTenant(tenant))
                    {
                        tenant.Mode = Tenant.enMode.Update;
                        return true;

                    }

                    return false;

                case Tenant.enMode.Update:
                    return _UpdateTenant(tenant);
            }

            return false;
        }

        public bool Delete(int tenantID)
        {
            return _tenantRepository.Delete(tenantID);
        }

        public Tenant GetByID(int tenantID)
        {
            return _tenantRepository.GetByID(tenantID);
        }

        public Tenant GetByClientRoleID(int clientRoleID)
        {
            return _tenantRepository.GetByClientRoleID(clientRoleID);
        }

        public List<Tenant> GetAll()
        {
            return _tenantRepository.GetAll();
        }

        public BindingList<TenantListDTO> GetTenantList()
        {
            return _tenantRepository.GetTenantList(); 
        }
        public bool Exists(int tenantID)
        {
            return _tenantRepository.Exists(tenantID);
        }

        public bool ExistsByClientRoleID(int clientRoleID)
        {
            return _tenantRepository.ExistsByClientRoleID(clientRoleID);
        }
        public int GetCount()
        {
            return _tenantRepository.GetTenantsCount();
        }
        public TenantListDTO GetClientListItemById(int ClientID)
        {
            return _tenantRepository.GetClientListItemById(ClientID);
        }
    }
}
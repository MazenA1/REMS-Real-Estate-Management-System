using Models;
using Models.DTOs;
using Models.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Interfaces
{
    public interface ITenantService
    {
        event EventHandler<TenantRegisteredEventArgs> TenantRegistered;

        bool Save(Tenant tenant);
        bool Delete(int tenantID);

        int GetCount();

        Tenant GetByID(int tenantID);
        Tenant GetByClientRoleID(int clientRoleID);

        TenantListDTO GetClientListItemById(int ClientID);
        List<Tenant> GetAll();
        BindingList<TenantListDTO> GetTenantList();

        bool Exists(int tenantID);
        bool ExistsByClientRoleID(int clientRoleID);
    }
}
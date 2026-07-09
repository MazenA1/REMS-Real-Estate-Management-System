using Models;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface ITenantService
    {
        event Action TenantAdded;

        bool Save(Tenant tenant);
        bool Delete(int tenantID);

        int GetCount();

        Tenant GetByID(int tenantID);
        Tenant GetByClientRoleID(int clientRoleID);

        List<Tenant> GetAll();

        bool Exists(int tenantID);
        bool ExistsByClientRoleID(int clientRoleID);
    }
}
using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface ITenantRepository
    {
        int Add(Tenant tenant);
        int GetTenantsCount();
        bool Update(Tenant tenant);
        bool Delete(int tenantID);

        Tenant GetByID(int tenantID);
        Tenant GetByClientRoleID(int clientRoleID);

        List<Tenant> GetAll();

        bool Exists(int tenantID);
        bool ExistsByClientRoleID(int clientRoleID);
    }
}
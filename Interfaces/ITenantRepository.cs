using Models;
using Models.DTOs;
using System.Collections.Generic;
using System.ComponentModel;

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

        TenantListDTO GetClientListItemById(int ClientID); 

        List <Tenant> GetAll();
        BindingList<TenantListDTO> GetTenantList();


        bool Exists(int tenantID);
        bool ExistsByClientRoleID(int clientRoleID);
    }
}
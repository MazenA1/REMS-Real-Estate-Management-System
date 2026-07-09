using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Services
{
    public class DashboardStatisticsService : IDashboardStatisticsService
    {
        private readonly IClientService _clientServices;
        private readonly ITenantService _tenantServices;
        private readonly IOwnerService _ownerService;  


        public DashboardStatisticsService(
            IClientService clientServices,
            ITenantService TenantServices,
            IOwnerService OwnerService
            )
        {
            this._clientServices = clientServices;
            this._tenantServices = TenantServices;
            this._ownerService = OwnerService;
        }

        public int GetClientsCount()
        {
            return _clientServices.GetCount();
        }

        public int GetTenantsCount()
        {
            return _tenantServices.GetCount();
        }
        public int GetOwnersCount()
        {
            return _ownerService.GetCount();
        }
    }
}

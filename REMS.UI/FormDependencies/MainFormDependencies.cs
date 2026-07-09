using Interfaces;
namespace REMS.UI.FormDependencies
{
    public class MainFormDependencies
    {
        public IClientRoleService RoleService { get; set; }
        public IClientService ClientService { get; set; }
        public ITenantService TenantService { get; set; }
        public IOwnerService OwnerService { get; set; }
        public IDashboardStatisticsService DashboardStatisticsService { get; set; }
        public AddEditClientFormDependencies AddEditClientDeps { get; set; }
        public AddNewPropertyFormDependencies AddNewPropertyDeps { get; set; }
    }
}

using Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REMS.UI.Customer_Management;
using REMS.UI.Factories;
using REMS.UI.Form_Models.Services;
using REMS.UI.FormDependencies;
using REMS.UI.Log_In;
using REMS.UI.Users_Management;

namespace REMS.UI
{
    public partial class frmMainService : Form
    {
        private frmLogin frmLogin;
        public frmMainService(frmLogin Form)
        {
            InitializeComponent();
            this.frmLogin = Form;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private AddEditClientFormDependencies
            _InitializeAddEditClientFormDependencies(
                IClientService clientService,
                ITenantService tenantService,
                IOwnerService ownerService)
        {
            IClientRoleService clientRoleService =
                ServiceFactory.CreateClientRoleService();

            return new AddEditClientFormDependencies
            {
                ClientService = clientService,

                ClientFormMapper =
                    new ClientFormMapper(),

                PersonService =
                    ServiceFactory.CreatePersonService(),

                CountryService =
                    ServiceFactory.CreateCountryService(),

                PersonImageService =
                    new PersonImageService(),

                PersonFormMapper =
                    new PersonFormMapper(),

                TenantService =
                    tenantService,

                ClientRoleService =
                    clientRoleService,

                TenantApplicationService = ServiceFactory.CreateTenantRegistrationService(),

                OwnerService =
                    ownerService
            };
        }

        private AddNewPropertyFormDependencies _InitializeAddNewPropertyFormDependencies(AddEditClientFormDependencies addEditClientFormDependencies)
        {
            return new AddNewPropertyFormDependencies
            {
                PropertyTypeService = ServiceFactory.CreatePropertyTypeService(),
                CityService = ServiceFactory.CreateCityService(),
                DistrictService = ServiceFactory.CreateDistrictService(),
                ManagementCommissionTypeService = ServiceFactory.CreateManagementCommissionTypeService(),
                PropertyApplicationService = ServiceFactory.CreatePropertyApplicationService(),
                ClientFormDeps = addEditClientFormDependencies
            };

        }
        private MainFormDependencies _InitializeMainFormDependencies()
        {
            IClientRoleService roleService =
                ServiceFactory.CreateClientRoleService();

            IClientService clientService =
                ServiceFactory.CreateClientService();

            ITenantService tenantService =
                ServiceFactory.CreateTenantService();

            IOwnerService ownerService =
                ServiceFactory.CreateOwnerService();

            IDashboardStatisticsService dashboardStatisticsService =
                new DashboardStatisticsService(clientService, tenantService, ownerService);

            return new MainFormDependencies
            {
                RoleService = roleService,

                ClientService = clientService,

                TenantService = tenantService,

                OwnerService = ownerService,

                DashboardStatisticsService = dashboardStatisticsService,

                AddEditClientDeps =
                    _InitializeAddEditClientFormDependencies(
                        clientService,
                        tenantService,
                        ownerService
                    ),

                AddNewPropertyDeps = _InitializeAddNewPropertyFormDependencies(
                    _InitializeAddEditClientFormDependencies(
                        clientService,
                        tenantService,
                        ownerService
                    )) 
            };
        }
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

            Form frmMain = new frmMain(_InitializeMainFormDependencies());
            frmMain.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Form frmUsers = new frmUsersManagement();
            frmUsers.ShowDialog();
        }
    }
}

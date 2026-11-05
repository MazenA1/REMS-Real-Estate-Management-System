using Interfaces;
using REMS.UI.Factories;
using REMS.UI.Form_Models.Services;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMS.UI.Composition
{
    public static class CompositionRoot
    {
        // TEMP: جسر مؤقت لحد ما نحوّل باقي الفورمات. رح نحذفه بالمرحلة الأخيرة.
        private static IFormFactory _formFactory;
        public static IFormFactory FormFactory =>
            _formFactory ?? (_formFactory = CreateFormFactory());

        // TEMP: كائنات مشتركة لأنها بتطلق أحداث بيسمعها frmMain.
        public static IClientService ClientService { get; } = ServiceFactory.CreateClientService();
        public static IOwnerService OwnerService { get; } = ServiceFactory.CreateOwnerService();
        public static ITenantService TenantService { get; } = ServiceFactory.CreateTenantService();
        public static ITenantApplicationService TenantApplicationService { get; } = ServiceFactory.CreateTenantRegistrationService();
        public static IOwnerApplicationService OwnerApplicationService { get; } = ServiceFactory.CreateOwnerRegistrationService();

        public static IFormFactory CreateFormFactory()
        {
            return new FormFactory(
                dashboardStatisticsService: new DashboardStatisticsService(ClientService, TenantService, OwnerService),
                propertyTypeService: ServiceFactory.CreatePropertyTypeService(),
                districtService: ServiceFactory.CreateDistrictService(),
                managementCommissionTypeService: ServiceFactory.CreateManagementCommissionTypeService(),
                propertyApplicationService: ServiceFactory.CreatePropertyApplicationService(),
                clientService: ClientService,
                clientTypeService: ServiceFactory.CreateClientTypeService(),
                clientFormMapper: new ClientFormMapper(),
                personService: ServiceFactory.CreatePersonService(),
                countryService: ServiceFactory.CreateCountryService(),
                personImageService: new PersonImageService(),
                personFormMapper: new PersonFormMapper(),
                tenantService: TenantService,
                clientRoleService: ServiceFactory.CreateClientRoleService(),
                tenantApplicationService: TenantApplicationService,
                ownerService: OwnerService,
                ownerApplicationService: OwnerApplicationService,
                propertyService: ServiceFactory.CreatePropertyService(),
                cityService: ServiceFactory.CreateCityService(),
                paymentMethodService: ServiceFactory.CreatePaymentMethodService(),
                investmentPurposeService: ServiceFactory.CreateInvestmentPurposeService(),
                interestLevelService: ServiceFactory.CreateInterestLevelService(),
                investorRegistrationService: ServiceFactory.CreateInvestorRegistrationService());
        }
    }
}

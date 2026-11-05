using Interfaces;
using REMS.UI.Factories;
using REMS.UI.Form_Models.Services;
using Services;

namespace REMS.UI.Composition
{
    /// <summary>
    /// Represents the application's composition root.
    /// This is the central place where services are created
    /// and wired together with the form factory.
    /// </summary>
    public static class CompositionRoot
    {
        /// <summary>
        /// Creates and configures the application's form factory
        /// together with all required service dependencies.
        /// </summary>
        /// <returns>
        /// A fully configured form factory used to create application forms.
        /// </returns>
        public static IFormFactory CreateFormFactory()
        {
            // Create shared service instances that must be reused across
            // multiple forms to preserve a consistent application state
            // and ensure that event subscribers receive events
            // from the same service instance.
            IClientService clientService =
                ServiceFactory.CreateClientService();

            IOwnerService ownerService =
                ServiceFactory.CreateOwnerService();

            ITenantService tenantService =
                ServiceFactory.CreateTenantService();

            ITenantApplicationService tenantApplicationService =
                ServiceFactory.CreateTenantRegistrationService();

            IOwnerApplicationService ownerApplicationService =
                ServiceFactory.CreateOwnerRegistrationService();

            // Create the form factory and inject all services
            // required for constructing application forms.
            return new FormFactory(
                dashboardStatisticsService:
                    new DashboardStatisticsService(
                        clientService,
                        tenantService,
                        ownerService),

                propertyTypeService:
                    ServiceFactory.CreatePropertyTypeService(),

                districtService:
                    ServiceFactory.CreateDistrictService(),

                managementCommissionTypeService:
                    ServiceFactory.CreateManagementCommissionTypeService(),

                propertyApplicationService:
                    ServiceFactory.CreatePropertyApplicationService(),

                clientService:
                    clientService,

                clientTypeService:
                    ServiceFactory.CreateClientTypeService(),

                clientFormMapper:
                    new ClientFormMapper(),

                personService:
                    ServiceFactory.CreatePersonService(),

                countryService:
                    ServiceFactory.CreateCountryService(),

                personImageService:
                    new PersonImageService(),

                personFormMapper:
                    new PersonFormMapper(),

                tenantService:
                    tenantService,

                clientRoleService:
                    ServiceFactory.CreateClientRoleService(),

                tenantApplicationService:
                    tenantApplicationService,

                ownerService:
                    ownerService,

                ownerApplicationService:
                    ownerApplicationService,

                propertyService:
                    ServiceFactory.CreatePropertyService(),

                cityService:
                    ServiceFactory.CreateCityService(),

                paymentMethodService:
                    ServiceFactory.CreatePaymentMethodService(),

                investmentPurposeService:
                    ServiceFactory.CreateInvestmentPurposeService(),

                interestLevelService:
                    ServiceFactory.CreateInterestLevelService(),

                investorRegistrationService:
                    ServiceFactory.CreateInvestorRegistrationService());
        }
    }
}
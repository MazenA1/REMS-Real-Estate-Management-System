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

        public static IFormFactory CreateFormFactory()
        {
            return new FormFactory(
                clientService: ServiceFactory.CreateClientService(),
                clientTypeService: ServiceFactory.CreateClientTypeService(),
                clientFormMapper: new ClientFormMapper(),
                personService: ServiceFactory.CreatePersonService(),
                countryService: ServiceFactory.CreateCountryService(),
                personImageService: new PersonImageService(),
                personFormMapper: new PersonFormMapper(),
                tenantService: ServiceFactory.CreateTenantService(),
                clientRoleService: ServiceFactory.CreateClientRoleService(),
                tenantApplicationService: ServiceFactory.CreateTenantRegistrationService(),
                ownerService: ServiceFactory.CreateOwnerService(),
                ownerApplicationService: ServiceFactory.CreateOwnerRegistrationService(),
                propertyService: ServiceFactory.CreatePropertyService(),
                cityService: ServiceFactory.CreateCityService(),
                paymentMethodService: ServiceFactory.CreatePaymentMethodService(),
                investmentPurposeService: ServiceFactory.CreateInvestmentPurposeService(),
                interestLevelService: ServiceFactory.CreateInterestLevelService(),
                investorRegistrationService: ServiceFactory.CreateInvestorRegistrationService());
        }
    }
}

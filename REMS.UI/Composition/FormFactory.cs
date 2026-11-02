using Interfaces;
using Models;
using REMS.UI.Client_Roles.Investor;
using REMS.UI.Client_Roles.Owner;
using REMS.UI.Client_Roles.Tenant_Details;
using REMS.UI.Client_Roles.UnitOwner;
using REMS.UI.Customer_Management;
using REMS.UI.Form_Models.Interfaces;
using REMS.UI.Person;
using REMS.UI.Person.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS.UI.Composition
{
    public class FormFactory : IFormFactory
    {
        // Person
        private readonly IPersonService _personService;
        private readonly ICountryService _countryService;
        private readonly IPersonImageService _personImageService;
        private readonly IPersonFormMapper _personFormMapper;

        // Tenant / Owner
        private readonly ITenantService _tenantService;
        private readonly IClientRoleService _clientRoleService;
        private readonly ITenantApplicationService _tenantApplicationService;
        private readonly IOwnerService _ownerService;
        private readonly IOwnerApplicationService _ownerApplicationService;

        // Investor
        private readonly IPropertyService _propertyService;
        private readonly ICityService _cityService;
        private readonly IPaymentMethodService _paymentMethodService;
        private readonly IInvestmentPurposeService _investmentPurposeService;
        private readonly IInterestLevelService _interestLevelService;
        private readonly IInvestorRegistrationService _investorRegistrationService;

        public FormFactory(
            IPersonService personService,
            ICountryService countryService,
            IPersonImageService personImageService,
            IPersonFormMapper personFormMapper,
            ITenantService tenantService,
            IClientRoleService clientRoleService,
            ITenantApplicationService tenantApplicationService,
            IOwnerService ownerService,
            IOwnerApplicationService ownerApplicationService,
            IPropertyService propertyService,
            ICityService cityService,
            IPaymentMethodService paymentMethodService,
            IInvestmentPurposeService investmentPurposeService,
            IInterestLevelService interestLevelService,
            IInvestorRegistrationService investorRegistrationService)
        {
            _personService = personService;
            _countryService = countryService;
            _personImageService = personImageService;
            _personFormMapper = personFormMapper;
            _tenantService = tenantService;
            _clientRoleService = clientRoleService;
            _tenantApplicationService = tenantApplicationService;
            _ownerService = ownerService;
            _ownerApplicationService = ownerApplicationService;
            _propertyService = propertyService;
            _cityService = cityService;
            _paymentMethodService = paymentMethodService;
            _investmentPurposeService = investmentPurposeService;
            _interestLevelService = interestLevelService;
            _investorRegistrationService = investorRegistrationService;
        }

        public Form CreateFindPerson(EventHandler<OnPersonSelectedEventArgs> onSelected)
        {
            var frm = new frmFindPerson();
            frm.OnPersonSelected += onSelected;
            return frm;
        }

        public Form CreateAddPerson(EventHandler<OnPersonSelectedEventArgs> onSelected)
        {
            var frm = new frmAddPerson(_personService, _countryService,
                                       _personImageService, _personFormMapper);
            frm.OnPersonSelected += onSelected;
            return frm;
        }

        public Form CreateTenantDetails(Client client) =>
            new frmAddEditTenantDetails(_tenantService, _clientRoleService,
                                        _countryService, _tenantApplicationService, client);

        public Form CreateOwnerDetails(Client client) =>
            new frmAddEditOwner(_ownerService, _clientRoleService,
                                _countryService, _ownerApplicationService, client);

        public Form CreateInvestorRegistration(int clientId) =>
            new frmAddNewInvestor(_propertyService, _cityService, _paymentMethodService,
                                  _investmentPurposeService, _interestLevelService,
                                  _investorRegistrationService, clientId);

        public Form CreateUnitOwnerRegistration(int clientId) =>
            new frmRegistrationUnitOwner(clientId);
    }
}


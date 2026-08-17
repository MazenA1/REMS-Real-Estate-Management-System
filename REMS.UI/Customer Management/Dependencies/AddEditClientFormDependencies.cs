using Interfaces;
using REMS.UI.Form_Models.Interfaces;

namespace REMS.UI.FormDependencies
{
    public class AddEditClientFormDependencies 
    {
        public IClientService ClientService { get; set; }
        public IClientFormMapper ClientFormMapper { get; set; }

        public IPersonService PersonService { get; set; }
        public ICountryService CountryService { get; set; }
        public IPersonImageService PersonImageService { get; set; }
        public IPersonFormMapper PersonFormMapper { get; set; }

        public ITenantService TenantService { get; set; }
        public IClientRoleService ClientRoleService { get; set; }
        public ITenantApplicationService TenantApplicationService { get; set; }
        public IOwnerApplicationService OwnerApplicationService { get; set; }
        public IOwnerService OwnerService { get; set; }
        public IPropertyService PropertyService { get; set; }
        public ICityService CityService { get; set; }
        public IPaymentMethodService PaymentMethodService {  get; set; }
        public IInvestmentPurposeService InvestmentPurposeService { get; set; }
        public IInterestLevelService InterestLevelService { get; set; }
        public IInvestorRegistrationService InvestorRegistrationService { get; set; }
    }
}

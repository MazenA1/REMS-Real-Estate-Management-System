using DataAccessLayer;
using Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
namespace REMS.UI.Factories
{
    public static class ServiceFactory
    {
        public static CountreService CreateCountryService()
        {
            IAppLogger appLogger = new EventLogger();
            ICountryRepository countryRepository = new CountryRepository(appLogger); 
            return new CountreService(countryRepository); 
        }

        public static PersonService CreatePersonService()
        {
            IAppLogger appLogger = new EventLogger();
            IPersonRepository clientRepository = new PersonRepository(appLogger); 
            return new PersonService(clientRepository);
        }
        public static UserService CreateUserService()
        {
            IAppLogger appLogger = new EventLogger();
            IUserRepository userRepository = new UserRepository();
            return new UserService(userRepository);
        }
        public static IClientService CreateClientService()
        {
            IAppLogger logger = new EventLogger();

            IClientRepository clientRepository = new ClientRepository(logger);

            return new ClientService(clientRepository);
        }

        public static ClientTypeService CreateClientTypeService()
        {
            IClientTypeRepository repo = new ClientTypeRepository();
            return new ClientTypeService(repo);
        }

        public static IClientRoleService CreateClientRoleService()
        {
            IAppLogger logger = new EventLogger();

            IClientRoleRepository clientRoleRepository = new ClientRoleRepository(logger);

            return new ClientRoleService(clientRoleRepository);
        }
        public static ITenantService CreateTenantService()
        {
            IAppLogger logger = new EventLogger();

            ITenantRepository tenantRepository = new TenantRepository(logger);

            return new TenantService(tenantRepository);
        }
        public static IOwnerService CreateOwnerService()
        {
            IAppLogger logger = new EventLogger();

            IOwnerRepository ownerRepository = new OwnerRepository(logger);

            return new OwnerService(ownerRepository);
        }
        public static IPropertyTypeService CreatePropertyTypeService()
        {
            IAppLogger logger = new EventLogger();

            IPropertyTypeRepository propertyTypeRepository =
                new PropertyTypeRepository(logger);

            return new PropertyTypeService(propertyTypeRepository);
        }

        public static ICityService CreateCityService()
        {
            IAppLogger logger = new EventLogger();

            ICityRepository cityRepository = new CityRepository(logger);

            return new CityService(cityRepository);
        }

        public static IDistrictService CreateDistrictService()
        {
            IAppLogger logger = new EventLogger();

            IDistrictRepository districtRepository =
                new DistrictRepository(logger);

            return new DistrictService(districtRepository);
        }
        public static IManagementCommissionTypeService CreateManagementCommissionTypeService()
        {
            IAppLogger logger = new EventLogger();

            IManagementCommissionTypeRepository repository =
                new ManagementCommissionTypeRepository(logger);

            return new ManagementCommissionTypeService(repository);
        }

        public static IPropertyOwnershipService CreatePropertyOwnershipService()
        {
            IAppLogger logger = new EventLogger();

            IPropertyOwnershipRepository repository =
                new PropertyOwnershipRepository(logger);

            return new PropertyOwnershipService(repository);
        }

        public static IPropertyEvaluationService CreatePropertyEvaluationService()
        {
            IAppLogger logger = new EventLogger();

            IPropertyEvaluationRepository repository =
                new PropertyEvaluationRepository(logger);

            return new PropertyEvaluationService(repository);
        }

        public static IPropertyApplicationService CreatePropertyApplicationService()
        {
            IAppLogger logger = new EventLogger();

            IPropertyApplicationRepository repository = new PropertyApplicationRepository(logger);

            return new PropertyApplicationService(repository); 
        }

        public static IImageService CreateImageService()
        {
             return new ImageService();
        }
    }
}

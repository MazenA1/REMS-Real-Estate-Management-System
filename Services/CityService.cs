using Interfaces;
using Models;
using System.Collections.Generic;

namespace Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public List<City> GetAll()
        {
            return _cityRepository.GetAll();
        }
    }
}
using Interfaces;
using Models;
using Models.DTOs;
using System.Collections.Generic;
using System.ComponentModel;

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
        public BindingList<InvestorPreferredCitieSelectionDTO> GetAllCities()
        {
            return _cityRepository.GetAllCities();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Models;

namespace Services
{
    public class CountreService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        public CountreService(ICountryRepository countryRepository)
        {
            this._countryRepository = countryRepository;
        }
        public Country GetByID(int ID)
        {
            return _countryRepository.FindByID(ID);
        }
        public Country GetByName(string Name)
        {
            return _countryRepository.FindByName(Name);
        }
        public List<Country> GetAll()
        {
            return _countryRepository.GetAll();
        }
    }
}

using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICountryService
    {
        List<Country> GetAll();
        Country GetByID(int countryId);
        Country GetByName(string countryName);
    }
}

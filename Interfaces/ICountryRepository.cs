using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Interfaces
{
    public interface ICountryRepository
    {
        Country FindByID(int ID);
        Country FindByName(string Name);
        List<Country> GetAll();

    }
}

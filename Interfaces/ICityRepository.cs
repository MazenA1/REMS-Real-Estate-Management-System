using Models;
using Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICityRepository
    {
        List<City> GetAll();

        BindingList<InvestorPreferredCitieSelectionDTO> GetAllCities();
    }
}

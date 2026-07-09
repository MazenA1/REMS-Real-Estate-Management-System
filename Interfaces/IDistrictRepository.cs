using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDistrictRepository
    {
        List<District> GetAll();

        List<District> GetByCityID(int cityID);
    }
}

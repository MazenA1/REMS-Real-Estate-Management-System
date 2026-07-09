using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDistrictService
    {
        List<District> GetAll();

        List<District> GetByCityID(int cityID);
    }
}

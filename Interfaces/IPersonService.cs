using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPersonService
    {
        bool Save(Person person);
        Person FindByID(int personId);
        Person FindByNationalNo(string NationalNo); 
        List<Person> GetAll();
        bool Delete(int personId);
    }
}

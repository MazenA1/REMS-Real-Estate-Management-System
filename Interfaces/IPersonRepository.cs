using Models;
using System.Collections.Generic;
using System.Data;

namespace Interfaces
{
    public interface IPersonRepository
    {
        int Add(Person person);
        bool Update(Person person);
        bool Delete(int personID);
        Person GetByID(int personID);
        Person GetByNationalNo(string NationalNo); 
        List<Person> GetAll(); 
        bool Exists(int personID);
        bool ExistsByNationalNo(string nationalNo);
    }
}

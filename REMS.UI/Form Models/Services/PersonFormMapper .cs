using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REMS.UI.Form_Models.Interfaces;

namespace REMS.UI.Form_Models.Services
{
    public class PersonFormMapper : IPersonFormMapper
    {
        public Models.Person MapToPerson(PersonFormData data, Models.Person person = null)
        {
            if (data == null)
                return null;

            if (person == null)
                person = new Models.Person();

            person.FullName = data.FullName;
            person.NationalNo = data.NationalNo;
            person.PhoneNumber = data.PhoneNumber;
            person.AnotherPhone = data.AnotherPhone;
            person.TaxNumber = data.TaxNumber;
            person.NameEnglish = data.NameEnglish;
            person.Email = data.Email;
            person.NationalityCountryID = data.NationalityCountryID;
            person.DateOfBirth = data.DateOfBirth;
            person.Gendor = data.Gendor;

            return person;
        }
    }
}

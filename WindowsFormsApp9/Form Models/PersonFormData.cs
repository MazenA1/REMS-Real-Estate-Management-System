using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMS.UI.Form_Models
{
    public class PersonFormData
    {
        public string FullName { get; set; }
        public string NationalNo { get; set; }
        public string PhoneNumber { get; set; }
        public string AnotherPhone { get; set; }
        public string TaxNumber { get; set; }
        public string NameEnglish { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gendor { get; set; }
    }
}

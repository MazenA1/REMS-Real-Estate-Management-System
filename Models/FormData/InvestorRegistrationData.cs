using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FormData
{
    public class InvestorRegistrationData 
    {
        public ClientRole ClientRole { get; set; }

        public Investor Investor { get; set; }
         
        public List<short> PreferredCityIDs { get; set; }

        public List<short> PreferredPropertyTypeIDs { get; set; }


        public InvestorRegistrationData()
        {
            ClientRole = new ClientRole();

            Investor = new Investor();

            PreferredCityIDs = new List<short>();

            PreferredPropertyTypeIDs = new List<short>();
        }
    }
}

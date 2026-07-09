using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models.FormData
{
    public class OwnerFormData
    {
        public ClientRole ClientRole { get; set; }
        public Owner Owner { get; set; }

        public OwnerFormData()
        {
            ClientRole = new ClientRole();
            Owner = new Owner();
        }
    }
}

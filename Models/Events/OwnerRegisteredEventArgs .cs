using Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Events
{
    public class OwnerRegisteredEventArgs
    {
        public OwnersListDTO ownersListDTO { get; }

        public OwnerRegisteredEventArgs(OwnersListDTO ownersListDTO)
        {
            this.ownersListDTO = ownersListDTO;
        }
    }
}

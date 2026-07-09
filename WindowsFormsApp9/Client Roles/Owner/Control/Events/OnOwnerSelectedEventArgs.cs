using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMS.UI.Client_Roles.Owner.Control.Events
{
    public class OnOwnerSelectedEventArgs  
    {
        public Models.DTOs.OwnerCardDTO OwnerCard;

        public OnOwnerSelectedEventArgs(Models.DTOs.OwnerCardDTO OwnerCard)
        {
            this.OwnerCard = OwnerCard;
        }
    }
}

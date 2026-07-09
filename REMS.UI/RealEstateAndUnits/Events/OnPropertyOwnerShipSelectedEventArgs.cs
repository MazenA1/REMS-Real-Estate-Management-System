using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMS.UI.RealEstateAndUnits.Events
{
    public class OnPropertyOwnerShipSelectedEventArgs : EventArgs
    {
        public Models.PropertyOwnership propertyOwnership;

        public Models.DTOs.OwnerCardDTO OwnerCard;

        public OnPropertyOwnerShipSelectedEventArgs(Models.PropertyOwnership propertyOwnership, Models.DTOs.OwnerCardDTO ownerCard)
        {
            this.propertyOwnership = propertyOwnership;
            this.OwnerCard = ownerCard;
        }
    }
}

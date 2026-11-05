using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Events
{
    public class UnitCoOwnerSelectedEventArgs : EventArgs
    {
        public UnitOwnerRegistrationItem Owner { get; }

        public UnitCoOwnerSelectedEventArgs(UnitOwnerRegistrationItem owner)
        {
            this.Owner = owner; 
        }
    }
}

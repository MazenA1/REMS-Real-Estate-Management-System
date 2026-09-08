using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Events
{
    public class PropertyActionEventArgs : EventArgs
    {
        public int PropertyID { get; }

        public string PropertyName { get; }

        public PropertyActionEventArgs(
            int propertyID,
            string propertyName)
        {
            PropertyID = propertyID;
            PropertyName = propertyName;
        }
    }
}

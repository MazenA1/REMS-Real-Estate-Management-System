using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FormData
{
    public class PropertyRegistrationData
    {
        public Property Property { get; set; }
        public List<PropertyOwnership> PropertyOwnership { get; set; }
        public PropertyEvaluation PropertyEvaluation { get; set; }

        public PropertyRegistrationData()
        {
            Property = new Property();
            PropertyOwnership = new List<PropertyOwnership>();
            PropertyEvaluation = new PropertyEvaluation();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PropertyManagement
    {
        public Property Property {  get; set; }
        public PropertyOwnership PropertyOwnership { get; set; }
        public PropertyEvaluation PropertyEvaluation { get; set; }

        public PropertyManagement()
        {
            Property = new Property();
            PropertyOwnership = new PropertyOwnership();
            PropertyEvaluation = new PropertyEvaluation();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace REMS.UI.Person.Events
{
    public class OnPersonSelectedEventArgs : EventArgs
    {
        public Models.Person Person { get; }

        public OnPersonSelectedEventArgs(Models.Person person)
        {
            this.Person = person;
        }
    }
}

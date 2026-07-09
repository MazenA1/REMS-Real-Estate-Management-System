using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMS.UI.Form_Models.Interfaces
{
    public interface IPersonFormMapper
    {
        Models.Person MapToPerson(PersonFormData data, Models.Person person = null);
    }
}

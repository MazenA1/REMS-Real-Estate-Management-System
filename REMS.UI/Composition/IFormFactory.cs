using Models;
using REMS.UI.Person.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS.UI.Composition
{
    public interface IFormFactory
    {
        Form CreateFindPerson(EventHandler<OnPersonSelectedEventArgs> onSelected);
        Form CreateAddPerson(EventHandler<OnPersonSelectedEventArgs> onSelected);
        Form CreateTenantDetails(Client client);
        Form CreateOwnerDetails(Client client);
        Form CreateInvestorRegistration(int clientId);
        Form CreateUnitOwnerRegistration(int clientId);
    }
}

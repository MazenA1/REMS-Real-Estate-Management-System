using Models;
using REMS.UI.Person.Events;
using System;
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
        Form CreateAddEditClient();
        Form CreateAddEditClient(int clientId);
        Form CreateAddNewProperty();
        Form CreateMain();
        Form CreateMainService(Form loginForm);
    }
}

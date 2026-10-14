using REMS.UI.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS.UI.Client_Roles.Owner.Control
{
    public partial class ctrlCommonSection_Person_ClientSelector : UserControl
    {
        public ctrlCommonSection_Person_ClientSelector()
        {
            InitializeComponent();
        }

        private void btnFindeData_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32( txtFinde.Text);

            ctrlClientCardInfo1.SetClientService(ServiceFactory.CreateClientService(), ServiceFactory.CreateUserService());

            ctrlClientCardInfo1.LoadClientByPersonID(PersonID);
            ctrlPersonCard1.LoadPersonByID(PersonID);
            
        }
    }
}

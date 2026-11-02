using Interfaces;
using REMS.UI.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace REMS.UI.Client_Roles.Owner.Control
{
    /// <summary>
    /// Combines person/client selection and client information display
    /// into a reusable common section and coordinates the selected client
    /// between the contained controls.
    /// </summary>
    public partial class ctrlCommonSection_Person_ClientSelector : UserControl
    {
        /// <summary>
        /// Occurs when the user request to add new client.
        /// </summary>
        public event EventHandler AddClientRequeest; 

        /// <summary>
        /// Occurs when the user request to add new person.
        /// </summary>
        public event EventHandler AddPersonRequeest;

        /// <summary>
        /// Gets whether a valid client is currently loaded.
        /// </summary>
        public bool HasClient
        {
            get
            { 
                return ctrlClientCardInfo1.HasClient; 
            }
        }

        /// <summary>
        /// Gets whether a valid person is currently loaded. 
        /// </summary>
        public bool HasPerson
        {
            get
            {
                return ctrlPersonCard1.HasPerson;
            }
        }

        /// <summary>
        /// Get selected person id.
        /// </summary>
        public int SelectedPersonID
        {
            get
            {
                return ctrlPersonCard1.PersonID;
            }
        }


        /// <summary>
        /// Get selected client id.
        /// </summary>
        public int SelectedClientID
        {
            get
            {
                return ctrlClientCardInfo1.ClientID;
            }
        }
        public Models.Person PersonInfo
        {
            get
            {
                return ctrlPersonCard1.PersonInfo;
            }
        }
         
        public ctrlCommonSection_Person_ClientSelector()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the control with the services required
        /// by its contained client-related controls.
        /// </summary>
        /// <param name="clientService">
        /// The service used to retrieve client information.
        /// </param>
        /// <param name="userService">
        /// The service used to retrieve user information.
        /// </param>
        public ctrlCommonSection_Person_ClientSelector(IClientService clientService, IUserService userService) : this()
        {
            SetServices(clientService, userService);
        }

        /// <summary>
        /// Sets the services required by the contained controls.
        /// </summary>
        /// <param name="clientService">
        /// The client service used to retrieve client information.
        /// </param>
        /// <param name="userService">
        /// The user service used to retrieve user-related information.
        /// </param>
        public void SetServices(IClientService clientService, IUserService userService) 
        {
            ctrlClientCardInfo1.SetClientService(clientService, userService); 
        }
        private void btnFindeData_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFinde.Text, out int personID) ||
                personID <= 0)
            {
                MessageBox.Show(
                    "يرجى إدخال معرف شخص صحيح.",
                    "تنبيه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            ctrlPersonCard1.LoadPersonByID(personID);

            ctrlClientCardInfo1.LoadClientByPersonID(personID);

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClientRequeest?.Invoke(this, EventArgs.Empty);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddPersonRequeest?.Invoke(this, EventArgs.Empty);
        }
    }
}

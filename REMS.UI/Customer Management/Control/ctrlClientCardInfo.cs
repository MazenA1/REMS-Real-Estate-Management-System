using Interfaces;
using Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS.UI.Customer_Management.Control
{

    /// <summary>
    /// Displays the basic information of a client
    /// and supports loading client data by Client ID or Person ID.
    /// </summary>
    public partial class ctrlClientCardInfo : UserControl
    {

        private IClientService _clientService;
        private int _clientID = -1;

        private ClientCardInfoDTO _clientInfo;

        /// <summary>
        /// Get the ID of the currently loaded client.
        /// </summary>
        public int ClientID
        {
            get { return _clientID; }
        }

        /// <summary>
        /// Get the client information of the currently loaded client.
        /// </summary>
        public ClientCardInfoDTO ClientInfo
        {
            get { return _clientInfo; }
        }

        /// <summary>
        /// Gets whether a valid client is currently loaded.
        /// </summary>
        public bool HasClient
        {
            get
            {
                return _clientInfo != null &&
                       _clientID > 0;
            }
        }
        public ctrlClientCardInfo()
        {
            InitializeComponent();
        }

        public ctrlClientCardInfo(IClientService clientService, IUserService userService) : this()
        {
            SetClientService(clientService, userService);
        }

        /// <summary>
        /// Set the client service and user service used by the control.
        /// </summary>
        /// <param name="clientService">
        /// The client service used to access client data.
        /// </param>
        /// <param name="userService">
        /// The user service used to access created by user data.
        /// </param>
        public void SetClientService(IClientService clientService, IUserService userService)
        {
            this._clientService = clientService;
            ctrlCreatedByUser1.SetUserService(userService);
        }

        /// <summary>
        /// Loads and displays the client information
        /// for the specified client ID.
        /// </summary>
        /// <param name="clientID">
        /// The ID of the client to load.
        /// </param>
        /// <returns>
        /// True if the client was found and loaded successfully;
        /// otherwise, false.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the client service has not been initialized.
        /// </exception>
        public bool LoadClient(int clientID)
        {
            if (clientID <= 0)
            {
                Clear();
                return false;
            }

            if (_clientService == null)
            {
                throw new InvalidOperationException(
                    "ClientService has not been initialized.");
            }

            ClientCardInfoDTO client =
                _clientService
                    .GetClientCardInfoByID(clientID);

            if (client == null)
            {
                Clear();
                return false;
            }

            _clientInfo = client;

            _clientID = client.ClientID;

            _FillClientData();

            return true;
        }

        /// <summary>
        /// Loads and displays the client information
        /// associated with the specified person ID.
        /// </summary>
        /// <param name="personID">
        /// The ID of the person whose client information will be loaded.
        /// </param>
        /// <returns>
        /// True if the person is registered as a client
        /// and the client information was loaded successfully;
        /// otherwise, false.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the client service has not been initialized.
        /// </exception>
        public bool LoadClientByPersonID(int personID)
        {
            if (personID <= 0)
            {
                Clear();

                return false;
            }

            if (_clientService == null)
            {
                throw new InvalidOperationException(
                    "ClientService has not been initialized.");
            }

            ClientCardInfoDTO client =
                _clientService
                    .GetClientCardInfoByPersonID(personID);

            if (client == null)
            {
                Clear();

                return false;
            }

            _clientInfo = client;

            _clientID = client.ClientID;

            _FillClientData();

            return true;
        }
        private void _FillClientData()
        {
            txtClientID.Text =
                _clientInfo.ClientID.ToString();

            txtClientTypeName.Text =
                _clientInfo.ClientTypeName;

            txtCreationDate.Text =
                _clientInfo.CreationDate
                    .ToString("dd/MM/yyyy");

            ctrlCreatedByUser1.LoadUser(this._clientInfo.CreatedByUserID);

            tglIsActive.Checked = this._clientInfo.IsActive;


            txtNotes.Text =
                _clientInfo.Notes ?? string.Empty;
        }
        public void Clear()
        {
            _clientID = -1;

            _clientInfo = null;

            txtClientID.Text = string.Empty;

            txtClientTypeName.Text = string.Empty;

            txtCreationDate.Text = string.Empty;

            ctrlCreatedByUser1.Clear();

            tglIsActive.Checked = false;

            txtNotes.Clear();
        }
    }
}

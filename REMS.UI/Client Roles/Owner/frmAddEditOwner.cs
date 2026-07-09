using Interfaces;
using Models;
using Models.FormData;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REMS.UI.Form_Models;

namespace REMS.UI.Client_Roles.Owner
{
    public partial class frmAddEditOwner : Form
    {
        private IOwnerService _ownerService;
        private IClientRoleService _clientRoleService;
        private ICountryService _countryService;
        private IOwnerApplicationService _ownerApplicationService;
        private Client _client;

        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public frmAddEditOwner(IOwnerService ownerService, IClientRoleService clientRoleService, ICountryService countryService,
            IOwnerApplicationService ownerApplicationService, Client client)
        {
            InitializeComponent();
            this._ownerService = ownerService;
            this._clientRoleService = clientRoleService;
            this._countryService = countryService;
            this._ownerApplicationService = ownerApplicationService;
            this._client = client;
        }

        private OwnerFormData _GetFormData()
        {
            return new OwnerFormData
            {
                ClientRole = new ClientRole
                {
                    ClientID = _client.ClientID,
                    ClientRoleTypeID = 2, // Owner
                    CreatedDate = DateTime.Now,
                    CreatedByUserID = Global.Global.CourentUser.UserID,
                    IsActive = 1,
                    Mode = ClientRole.enMode.AddNew
                },

                Owner = new Models.Owner
                {
                    RepresentativeName = txtOwnerRepresentativeName.Text.Trim(),
                    RepresentativeNationalID = txtOwnerRepresentativeNationalID.Text.Trim(),
                    RepresentativePhone = txtOwnerRepresentativePhone.Text.Trim(),
                    RepresentativeDateOfBirth = dtpReprasentativDateOfBirth.Value,

                    AgencyNumber = txtAgancyNumber.Text.Trim(),
                    AgencyDate = dtpAgancyDate.Value,

                    NationalityID = Convert.ToInt32(cbCountries.SelectedValue),

                    NameOfConductor = CbNameOfConductor.Text,

                    OpeningBalance = Convert.ToDecimal(txtOpeningBalance.Text),

                    CreationDate = DateTime.Now,

                    MovementType = rbDebtor.Checked
                        ? Models.Owner.enBalanceType.Debtor
                        : Models.Owner.enBalanceType.Creditor,

                    CreatedByUserID = Global.Global.CourentUser.UserID,

                    Mode = Models.Owner.enMode.AddNew
                }
            };
        }
        private void _FillCountryiesComboBox()
        {
            List<Country> countries = _countryService.GetAll();

            cbCountries.DataSource = countries;
            cbCountries.DisplayMember = "CountryName";
            cbCountries.ValueMember = "Id";
        }
        private void _RestDefaultData()
        {
            _FillCountryiesComboBox();

            txtCurrentDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void _InitializeForAddMode()
        {
            _RestDefaultData();
        }
        private void frmAddEditOwner_Load(object sender, EventArgs e)
        {
            if (this._Mode == enMode.AddNew)
            {
                _InitializeForAddMode();
            }
        }
        private bool _DataSave_AddNewMode()
        {

            OwnerFormData data = _GetFormData();

            if (_ownerApplicationService.RegisterOwner(data))
            {
                MessageBox.Show("تم حفظ المستأجر بنجاح.");
            }

            return false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (this._Mode)
            {
                case enMode.AddNew:
                    if (_DataSave_AddNewMode())
                    {
                        this._Mode = enMode.Update;
                        return;
                    }
                    break;
            }
        }
    }
}

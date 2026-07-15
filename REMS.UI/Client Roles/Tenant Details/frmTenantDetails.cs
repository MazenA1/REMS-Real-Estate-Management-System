using Guna.UI2.WinForms;
using Interfaces;
using Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using REMS.UI.Form_Models;
using REMS.UI.Validation;

namespace REMS.UI.Client_Roles.Tenant_Details
{
    public partial class frmAddEditTenantDetails : Form
    {
        private ICountryService _countryService;
        private ITenantService _tenantService;
        private IClientRoleService _clientRoleService;
        private ITenantApplicationService _tenantApplicationService;
        private Models.Client _client;
        private Models.ClientRole _clientRole;
        private Models.Tenant _tenant;
        private enum enMode { AddNew = 0, Update = 1};
        private enMode _Mode;
        public frmAddEditTenantDetails(ITenantService tenantService, IClientRoleService clientRoleService, ICountryService countryService,
            ITenantApplicationService tenantApplicationService
            , Models.Client client)
        { 
            InitializeComponent();
            this._Mode = enMode.AddNew;
            this._tenantService = tenantService;
            this._clientRoleService = clientRoleService;
            this._countryService = countryService;
            this._tenantApplicationService = tenantApplicationService;
            this._client = client;
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
        private void frmAddEditTenantDetails_Load(object sender, EventArgs e)
        {
            if (this._Mode == enMode.AddNew)
            {
                _InitializeForAddMode();
            }
        }
        private TenantRegistrationData _GetFormData()
        {
            return new TenantRegistrationData
            {
                ClientRole = new ClientRole
                {
                    ClientID = _client.ClientID,
                    ClientRoleTypeID = 1, // Tenant
                    CreatedDate = DateTime.Now,
                    CreatedByUserID = Global.Global.CourentUser.UserID,
                    IsActive = 1,
                    Mode = ClientRole.enMode.AddNew
                },

                Tenant = new Tenant
                {
                    RepresentativeName = txtTenantRepresentativeName.Text.Trim(),
                    RepresentativeNationalID = txtTenantRepresentativeNationalID.Text.Trim(),
                    RepresentativeDate = dtpReprasentativDateOfBirth.Value,
                    AgencyNumber = txtAgancyNumber.Text.Trim(),
                    AgencyDate = dtpAgancyDate.Value,
                    NationalityID = Convert.ToInt32(cbCountries.SelectedValue),
                    NameOfConductor = CbNameOfConductor.Text, // Lettar Add Conductor Table
                    OpeningBalance = Convert.ToDecimal(txtOpeningBalance.Text),
                    CreationDate = DateTime.Now,
                    MovementType = rbDebtor.Checked ? Tenant.enBalanceType.Debtor : Tenant.enBalanceType.Creditor,
                    TenantEvaluation = (byte)rsTenantEvaluation.Value,
                    Mode = Tenant.enMode.AddNew
                }
            };
        }
        private bool _DataSave_AddNewMode()
        {

            TenantRegistrationData data = _GetFormData();

            if (_tenantApplicationService.Register(data))
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

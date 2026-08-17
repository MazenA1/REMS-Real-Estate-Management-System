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
using System.Threading.Tasks;
using System.Windows.Forms;
using REMS.UI.Client_Roles.Owner;
using REMS.UI.Client_Roles.Tenant_Details;
using REMS.UI.Factories;
using REMS.UI.Form_Models;
using REMS.UI.Form_Models.Interfaces;
using REMS.UI.Form_Models.Services;
using REMS.UI.FormDependencies;
using REMS.UI.Global;
using REMS.UI.Person;
using REMS.UI.Person.Events;
using REMS.UI.Validation;
using static REMS.UI.Customer_Management.Control.ctrlClientRoleNavigator;
using REMS.UI.Client_Roles.Investor;

namespace REMS.UI.Customer_Management
{
    public partial class frmAddEditClient : Form
    {
        //private readonly IClientTypeService _clientTypeService;

        private readonly AddEditClientFormDependencies _deps;

        private Models.Person _person;
        private Models.Client _client;

        private int _PersonID {  get; set; }
        private enum enMode { AddNew = 0, Edit = 1 }
        private enMode _Mode {  get; set; }
        private int _ClientID { get; set; }
        public frmAddEditClient(AddEditClientFormDependencies deps)
        {
            InitializeComponent();
            this._deps = deps;

            _Mode = enMode.AddNew;
        }

        public frmAddEditClient(int clientID, AddEditClientFormDependencies deps)
        {
            _Mode = enMode.Edit;
            _ClientID = clientID;
            this._deps = deps;

        }
        private void _FillClientTypesComboBox()
        {
            var service = ServiceFactory.CreateClientTypeService();

            var types = service.GetAll();

            cbClientTypes.DataSource = types;
            cbClientTypes.DisplayMember = "TypeNameAr";
            cbClientTypes.ValueMember = "ClientTypeID";
        }
        private bool _ValidateForm()
        {
            bool isValid = true;

            if (!ValidationHelper.ValidateRequiredComboBox(cbClientTypes, errorProvider1, "الرجاء اختيار النوع"))
                isValid = false;

            return isValid;
        }
        private void _InitializeData() 
        {
            _FillClientTypesComboBox();
        }
        private void _LoadPersonCardInfo(int PersonID)
        {
            ctrlPersonCard1.LoadPersonByID(PersonID);
            this._PersonID = PersonID;
        }
        private void _LoadClientData(Client client)
        {
            _LoadPersonCardInfo(client.PersonID);

            txtClientID.Text = client.ClientID.ToString();
            cbClientTypes.SelectedValue = client.ClientTypeID;
            txtNotes.Text = client.Notes;
        }

        private void _InitializeForUpdateMode()
        {
            _client = _deps.ClientService.GetByID(this._ClientID);

            if (_client == null)
            {
                MessageBox.Show("تعذر العثور على بيانات العميل المطلوب.",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                btnSave.Enabled = false;
                btnNext.Enabled = false;
                return;
            }

            _client.Mode = Client.enMode.Update;
            _LoadClientData(_client);

            btnSave.Enabled = true;
            btnNext.Enabled = true;
        }
        private void _SetupAddMode()
        {
            this.Text = "إضافة عميل جديد";

            _client = null;
            _PersonID = 0;

            txtClientID.Text = "N/A";
            btnSave.Enabled = false;
            btnNext.Enabled = false;
        }
        private void _SetupEditMode()
        {
            this.Text = "تعديل بيانات العميل";

            btnSave.Enabled = true;
            btnNext.Enabled = true;
        }
        private void frmAddEditClient_Load(object sender, EventArgs e)
        {
            _InitializeData();

            if (_Mode == enMode.AddNew)
            {
                _SetupAddMode();
            }
            else
            {
                _SetupEditMode();
                _InitializeForUpdateMode();
            }
        }
        private bool _CheckClientIsExist(int PersonID)
        {
            return _deps.ClientService.ExistsByPersonID(PersonID);
        }
        private void _SetSelectedPerson(Models.Person person)
        {
            if (person == null)
                return;

            _PersonID = person.PersonID;

            LiAddPerson.Text = $"{person.NationalNo} - {person.FullName}";
            LiSelectedPerson.Text = $"{person.NationalNo} - {person.FullName}";

            ctrlPersonCard1.LoadPersonByID(person.PersonID);
        }
        private void _OnPersonSelected(object sender, OnPersonSelectedEventArgs e)
        {
            _SetSelectedPerson(e.Person);

            this.Show();

            if (_Mode == enMode.AddNew && _deps.ClientService.ExistsByPersonID(_PersonID))
            {
                this._client = _deps.ClientService.GetByPersonID(_PersonID);

                MessageBox.Show("هذا الشخص مضاف مسبقًا كعميل.",
                    "تنبيه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                btnSave.Enabled = false;
                btnNext.Enabled = true;
                return;
            }

            btnSave.Enabled = true;
            btnNext.Enabled = false;
        }
        private void _AfterUpdatePersonInfo(object sender, OnPersonSelectedEventArgs e)
        {
            // Update Top Header Info.
            _SetSelectedPerson(e.Person);
        }
        private void LiAddPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmFindPerson frm = new frmFindPerson();
            frm.OnPersonSelected += _OnPersonSelected;
            ctrlPersonCard1.EditLinkClicked += _AfterUpdatePersonInfo;
            frm.ShowDialog();
        }
        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }
        private ClientFormData _GetFormData()
        {
            bool isAddMode = _Mode == enMode.AddNew;

            return new ClientFormData
            {
                ClientInfo = new Client
                {
                    Mode = isAddMode ? Client.enMode.AddNew : Client.enMode.Update,

                    ClientID = isAddMode ? 0 : _client.ClientID,
                    PersonID = _PersonID,

                    ClientTypeID = Convert.ToInt32(cbClientTypes.SelectedValue),

                    CreatedDate = isAddMode ? DateTime.Now : _client.CreatedDate,
                    CreatedByUserID = isAddMode ? Global.Global.CourentUser.UserID : _client.CreatedByUserID,

                    IsActive = 1,
                    Notes = txtNotes.Text.Trim()
                }
            };
        }
        private bool _SaveClient()  
        {
            ClientFormData formData = _GetFormData();
            _client = _deps.ClientFormMapper.MapToClient(formData);

            if (!_deps.ClientService.Save(_client))
                return false;

            txtClientID.Text = _client.ClientID.ToString();

            return true;
        }
        private void _GoToClientSettingsTab()
        {
            tcClientInfo.SelectedTab = tcClientInfo.TabPages["tabClientSettings"];
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            _GoToClientSettingsTab();
        }
        private void btnSaveClick(object sender, EventArgs e)
        {
            if (_PersonID <= 0)
            {
                MessageBox.Show("الرجاء اختيار شخص أولًا.",
                    "تنبيه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!_ValidateForm())
            {
                MessageBox.Show("لا يمكن إتمام العملية. يرجى التأكد من إدخال جميع البيانات المطلوبة.",
                    "تنبيه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (_Mode == enMode.AddNew && _deps.ClientService.ExistsByPersonID(_PersonID))
            {
                MessageBox.Show("عملية الإضافة مرفوضة: العميل مضاف مسبقًا ولا يمكن تكراره.",
                    "تنبيه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (_SaveClient())
            {
                MessageBox.Show("تم حفظ بيانات العميل بنجاح.",
                    "تم الحفظ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btnNext.Enabled = true;
                _Mode = enMode.Edit;
            }
            else
            {
                MessageBox.Show("فشل حفظ بيانات العميل. تحقق من البيانات وحاول مرة أخرى.",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void _OpenAddPersonForm()
        {
            frmAddPerson frm = new frmAddPerson(
                _deps.PersonService,
                _deps.CountryService,
                _deps.PersonImageService,
                _deps.PersonFormMapper);

            frm.OnPersonSelected += _OnPersonSelected;
            frm.ShowDialog();
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            _OpenAddPersonForm();
        }
        private void _OpenTenantDetailsForm()
        {
            if (_client == null || _client.ClientID <= 0)
            {
                MessageBox.Show("يجب حفظ العميل أولًا قبل إضافة تفاصيل المستأجر.",
                    "تنبيه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Form frm = new frmAddEditTenantDetails(
                _deps.TenantService,
                _deps.ClientRoleService,
                _deps.CountryService,
                _deps.TenantApplicationService,
                _client);

            frm.ShowDialog();
        }
        private void btnTenant_Click(object sender, EventArgs e)
        {
            _OpenTenantDetailsForm();
        }

        private void _OpenOwnerDetailsForm()
        {

            Form frm = new frmAddEditOwner(this._deps.OwnerService, this._deps.ClientRoleService, this._deps.CountryService, this._deps.OwnerApplicationService, this._client);
            frm.ShowDialog();
        }
        private void btnOwner_Click(object sender, EventArgs e)
        {
            _OpenOwnerDetailsForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _client = _deps.ClientService.GetByNationalNo(txtFind.Text.Trim());

            if (_client != null)
            {
                _SetupEditMode();
                _client.Mode = Client.enMode.Update;
                _LoadClientData(_client);

                btnSave.Enabled = true;
                btnNext.Enabled = true;
            }
            else
                MessageBox.Show("تعذر العثور على بيانات العميل المطلوب.",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void btnInvestor_Click(object sender, EventArgs e)
        {
            frmAddNewInvestor frm = new frmAddNewInvestor(this._deps.PropertyService, this._deps.CityService, this._deps.PaymentMethodService,
                this._deps.InvestmentPurposeService, this._deps.InterestLevelService, this._deps.InvestorRegistrationService, this._ClientID);  
            frm.ShowDialog();
        }
    }
}

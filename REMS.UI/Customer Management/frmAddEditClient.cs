using Interfaces;
using Models;
using REMS.UI.Composition;
using REMS.UI.Form_Models;
using REMS.UI.Form_Models.Interfaces;
using REMS.UI.Person.Events;
using REMS.UI.Validation;
using System;
using System.Windows.Forms;

namespace REMS.UI.Customer_Management
{
    public partial class frmAddEditClient : Form
    {
        private readonly IClientService _clientService;
        private readonly IClientTypeService _clientTypeService;
        private readonly IClientFormMapper _clientFormMapper;
        private readonly IFormFactory _formFactory;

        private readonly int _initialClientID;   
        private Client _client;                  
        private int _personID;

        /// وضع التعديل = في عميل محمّل وله ID. هاد المصدر الوحيد لمعرفة الوضع.
        private bool IsEditMode => _client != null && _client.ClientID > 0;
        private int CurrentClientID => IsEditMode ? _client.ClientID : 0;

        #region Constructors

        public frmAddEditClient(
            IClientService clientService,
            IClientTypeService clientTypeService,
            IClientFormMapper clientFormMapper,
            IFormFactory formFactory)
        {
            InitializeComponent();

            _clientService = clientService;
            _clientTypeService = clientTypeService;
            _clientFormMapper = clientFormMapper;
            _formFactory = formFactory;

            // الربط مرة وحدة هون، مش داخل Click.
            ctrlPersonCard1.EditLinkClicked += _OnPersonInfoUpdated;
        }

        public frmAddEditClient(
            int clientID,
            IClientService clientService,
            IClientTypeService clientTypeService,
            IClientFormMapper clientFormMapper,
            IFormFactory formFactory)
            : this(clientService, clientTypeService, clientFormMapper, formFactory)
        {
            _initialClientID = clientID;
        }

        #endregion


        #region Messages

        private void ShowWarning(string msg) =>
            MessageBox.Show(msg, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void ShowError(string msg) =>
            MessageBox.Show(msg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void ShowInfo(string msg) =>
            MessageBox.Show(msg, "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void ShowClientNotFound() =>
            ShowError("تعذر العثور على بيانات العميل المطلوب.");

        #endregion


        #region Initialization

        private void frmAddEditClient_Load(object sender, EventArgs e)
        {
            _FillClientTypesComboBox();

            if (_initialClientID > 0)
                _LoadExistingClient(_clientService.GetByID(_initialClientID));
            else
                _SetupAddMode();
        }

        private void _FillClientTypesComboBox()
        {
            cbClientTypes.DataSource = _clientTypeService.GetAll();
            cbClientTypes.DisplayMember = "TypeNameAr";
            cbClientTypes.ValueMember = "ClientTypeID";
        }

        private void _SetupAddMode()
        {
            Text = "إضافة عميل جديد";
            _client = null;
            _personID = 0;
            txtClientID.Text = "N/A";

            _SetButtons(canSave: false, canNext: false);
        }

        /// يحمّل عميل موجود (من الـ Constructor أو من البحث) ويحوّل الفورم لوضع التعديل.
        private void _LoadExistingClient(Client client)
        {
            if (client == null)
            {
                ShowClientNotFound();
                _SetButtons(canSave: false, canNext: false);
                return;
            }

            _client = client;
            _client.Mode = Client.enMode.Update;

            Text = "تعديل بيانات العميل";
            _LoadPersonCard(client.PersonID);

            txtClientID.Text = client.ClientID.ToString();
            cbClientTypes.SelectedValue = client.ClientTypeID;
            txtNotes.Text = client.Notes;

            _SetButtons(canSave: true, canNext: true);
        }

        private void _LoadPersonCard(int personID)
        {
            _personID = personID;
            ctrlPersonCard1.LoadPersonByID(personID);
        }

        private void _SetButtons(bool canSave, bool canNext)
        {
            btnSave.Enabled = canSave;
            btnNext.Enabled = canNext;
        }

        #endregion


        #region Person selection

        private void _SetSelectedPerson(Models.Person person)
        {
            if (person == null) return;

            string title = $"{person.NationalNo} - {person.FullName}";
            LiAddPerson.Text = title;
            LiSelectedPerson.Text = title;

            _LoadPersonCard(person.PersonID);
        }

        private void _OnPersonSelected(object sender, OnPersonSelectedEventArgs e)
        {
            _SetSelectedPerson(e.Person);

            // الشخص مضاف مسبقًا كعميل: حمّله بدل ما تسمح بتكرار.
            if (!IsEditMode && _clientService.ExistsByPersonID(_personID))
            {
                ShowWarning("هذا الشخص مضاف مسبقًا كعميل.");
                _LoadExistingClient(_clientService.GetByPersonID(_personID));
                _SetButtons(canSave: false, canNext: true);
                return;
            }

            _SetButtons(canSave: true, canNext: false);
        }

        private void _OnPersonInfoUpdated(object sender, OnPersonSelectedEventArgs e)
        {
            _SetSelectedPerson(e.Person); // تحديث الهيدر بعد تعديل بيانات الشخص
        }

        private void LiAddPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var frm = _formFactory.CreateFindPerson(_OnPersonSelected))
                frm.ShowDialog(this);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            using (var frm = _formFactory.CreateAddPerson(_OnPersonSelected))
                frm.ShowDialog(this);
        }

        #endregion


        #region Validation & Save

        private bool _ValidateForm()
        {
            return ValidationHelper.ValidateRequiredComboBox(
                cbClientTypes, errorProvider1, "الرجاء اختيار النوع");
        }

        private ClientFormData _GetFormData()
        {
            bool isAddMode = !IsEditMode;

            return new ClientFormData
            {
                ClientInfo = new Client
                {
                    Mode = isAddMode ? Client.enMode.AddNew : Client.enMode.Update,
                    ClientID = isAddMode ? 0 : _client.ClientID,
                    PersonID = _personID,
                    ClientTypeID = Convert.ToInt32(cbClientTypes.SelectedValue),
                    CreatedDate = isAddMode ? DateTime.Now : _client.CreatedDate,
                    CreatedByUserID = isAddMode
                        ? Global.Global.CourentUser.UserID
                        : _client.CreatedByUserID,
                    IsActive = 1,
                    Notes = txtNotes.Text.Trim()
                }
            };
        }

        private bool _SaveClient()
        {
            var client = _clientFormMapper.MapToClient(_GetFormData());

            if (!_clientService.Save(client))
                return false;

            _client = client;
            txtClientID.Text = client.ClientID.ToString();
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_personID <= 0)
            {
                ShowWarning("الرجاء اختيار شخص أولًا.");
                return;
            }

            if (!_ValidateForm())
            {
                ShowWarning("لا يمكن إتمام العملية. يرجى التأكد من إدخال جميع البيانات المطلوبة.");
                return;
            }

            if (!IsEditMode && _clientService.ExistsByPersonID(_personID))
            {
                ShowWarning("عملية الإضافة مرفوضة: العميل مضاف مسبقًا ولا يمكن تكراره.");
                return;
            }

            if (!_SaveClient())
            {
                ShowError("فشل حفظ بيانات العميل. تحقق من البيانات وحاول مرة أخرى.");
                return;
            }

            ShowInfo("تم حفظ بيانات العميل بنجاح.");
            Text = "تعديل بيانات العميل";
            btnNext.Enabled = true;
        }

        #endregion


        #region Search

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _LoadExistingClient(_clientService.GetByNationalNo(txtFind.Text.Trim()));
        }

        #endregion


        #region Navigation / Role forms

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcClientInfo.SelectedTab = tcClientInfo.TabPages["tabClientSettings"];
        }

        /// الأدوار (مستأجر/مالك/مستثمر) ما بتنفتح إلا بعد ما العميل ينحفظ ويصير إله ID.
        private bool _EnsureClientSaved(string roleName)
        {
            if (IsEditMode) return true;

            ShowWarning($"يجب حفظ العميل أولًا قبل إضافة تفاصيل {roleName}.");
            return false;
        }

        private void _ShowForm(Form form)
        {
            using (form)
                form.ShowDialog(this);
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            if (_EnsureClientSaved("المستأجر"))
                _ShowForm(_formFactory.CreateTenantDetails(_client));
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            if (_EnsureClientSaved("المالك"))
                _ShowForm(_formFactory.CreateOwnerDetails(_client));
        }

        private void btnInvestor_Click(object sender, EventArgs e)
        {
            if (_EnsureClientSaved("المستثمر"))
                _ShowForm(_formFactory.CreateInvestorRegistration(CurrentClientID));
        }

        private void btnUnitOwner_Click(object sender, EventArgs e)
        {
            if (_EnsureClientSaved("مالك الوحدة"))
                _ShowForm(_formFactory.CreateUnitOwnerRegistration(CurrentClientID));
        }

        #endregion
    }
}
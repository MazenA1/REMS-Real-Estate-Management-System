using Guna.UI2.WinForms;
using Interfaces;
using Models;
using Models.DTOs;
using Models.FormData;
using REMS.UI.Global;
using REMS.UI.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS.UI.Client_Roles.Investor
{
    public partial class frmAddNewInvestor : Form
    {
        private BindingList<InvestorPreferredPropertyTypeDTO> _properties = new BindingList<InvestorPreferredPropertyTypeDTO>();
        private BindingList<InvestorPreferredCitieSelectionDTO> _Cities = new BindingList<InvestorPreferredCitieSelectionDTO>();

        private List<InvestorPreferredPropertyTypeDTO> _selectedPropertyTypes = new List<InvestorPreferredPropertyTypeDTO>();
        private List<InvestorPreferredCitieSelectionDTO> _selectedCities = new List<InvestorPreferredCitieSelectionDTO>();

        private IPropertyService _PropertyService;

        private ICityService _CityService;
        private IPaymentMethodService _PaymentMethodService { get; set; }
        private IInvestmentPurposeService _InvestmentPurposeService { get; set; }
        private IInterestLevelService _InterestLevelService { get; set; }
        private IInvestorRegistrationService _InvestorRegistrationService { get; set; }

        private bool _isLoadingPropertyTypes, _isLoadingCities, _isFilteringCities = false;
        private int _ClientID {  get; set; }
        public frmAddNewInvestor(IPropertyService propertyService, ICityService cityService, IPaymentMethodService PaymentMethodService,
            IInvestmentPurposeService InvestmentPurposeService, IInterestLevelService InterestLevelService,
            IInvestorRegistrationService InvestorRegistrationService, int ClientID) 
        {
            InitializeComponent();
            this._PropertyService = propertyService;    
            this._CityService = cityService;
            this._PaymentMethodService = PaymentMethodService;
            this._InvestmentPurposeService = InvestmentPurposeService;
            this._InterestLevelService = InterestLevelService;
            this._InvestorRegistrationService = InvestorRegistrationService;
            this._ClientID = ClientID;
        }

        private async Task _LoadAllPropertyAsync() 
        {

            try
            {
                this._properties = await Task.Run(() =>
                    this._PropertyService.GetPropertyTypesWithPropertiesCount());

                dgvPropertyTypes.DataSource = this._properties;

                dgvPropertyTypes.Columns["PropertyTypeID"].HeaderText = "معرف نوع العقار"; 
                dgvPropertyTypes.Columns["PropertyTypeName"].HeaderText = "نوع العقار";
                dgvPropertyTypes.Columns["PropertiesCount"].HeaderText = "عدد العقارات";
                dgvPropertyTypes.Columns["Selected"].HeaderText = "مُختار";

                this._isLoadingPropertyTypes = true;
            }
            finally
            {
                this._isLoadingPropertyTypes = false;
            }
        }
        private async Task _LoadAllCitiesAsync() 
        {

            try
            {

                this._isFilteringCities = true;

                this._Cities = await Task.Run(() => 
                    this._CityService.GetAllCities());

                dgvCities.DataSource = this._Cities; 

                dgvCities.Columns["CitieName"].HeaderText = "اسم المدينة";
                dgvCities.Columns["PlateCode"].HeaderText = "رمز اللوحة";
                dgvCities.Columns["Selected"].HeaderText = "مُختار";

                this._isLoadingCities = true;
            }
            finally
            {
                this._isLoadingCities = false;
                this._isFilteringCities = false;
            }
        }
        private void StyledgvCitiesTypesGrid() 
        {

            dgvCities.BorderStyle = BorderStyle.None;
            dgvCities.RowHeadersVisible = false;
            dgvCities.BackgroundColor = Color.White;
            dgvCities.GridColor = Color.FromArgb(235, 235, 235);

            dgvCities.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvCities.EnableHeadersVisualStyles = false;

            // الهيدر
            dgvCities.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;

            dgvCities.ThemeStyle.HeaderStyle.Height = 45;
            dgvCities.ColumnHeadersHeight = 45;

            dgvCities.ThemeStyle.HeaderStyle.BackColor = Color.White;
            dgvCities.ThemeStyle.HeaderStyle.ForeColor = Color.Black;

            dgvCities.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvCities.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            dgvCities.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvCities.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvCities.ColumnHeadersDefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Bold);

            dgvCities.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // الصفوف
            dgvCities.ThemeStyle.RowsStyle.Height = 45;
            dgvCities.RowTemplate.Height = 45;

            dgvCities.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCities.DefaultCellStyle.BackColor = Color.White;

            dgvCities.ThemeStyle.RowsStyle.ForeColor =
                Color.FromArgb(35, 35, 35);

            dgvCities.DefaultCellStyle.ForeColor =
                Color.FromArgb(35, 35, 35);

            dgvCities.DefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Regular);

            dgvCities.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // alternating rows
            dgvCities.ThemeStyle.AlternatingRowsStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            dgvCities.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            // التحديد
            dgvCities.ThemeStyle.RowsStyle.SelectionBackColor =
                Color.FromArgb(230, 226, 255);

            dgvCities.ThemeStyle.RowsStyle.SelectionForeColor =
                Color.FromArgb(35, 35, 35);

            dgvCities.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 226, 255);

            dgvCities.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(35, 35, 35);

            // إعدادات إضافية
            dgvCities.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvCities.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvCities.RowHeadersVisible = false;

            dgvCities.MultiSelect = false;

            dgvCities.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvCities.AllowUserToAddRows = false;
            dgvCities.AllowUserToResizeRows = false;
            dgvCities.AllowUserToResizeColumns = false;

            

            dgvCities.RightToLeft = RightToLeft.Yes;

        }
        private void StylePropertyTypesGrid()
        {

            dgvPropertyTypes.BorderStyle = BorderStyle.None;
            dgvPropertyTypes.RowHeadersVisible = false;
            dgvPropertyTypes.BackgroundColor = Color.White;
            dgvPropertyTypes.GridColor = Color.FromArgb(235, 235, 235);

            dgvPropertyTypes.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvPropertyTypes.EnableHeadersVisualStyles = false;

            // الهيدر
            dgvPropertyTypes.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;

            dgvPropertyTypes.ThemeStyle.HeaderStyle.Height = 45;
            dgvPropertyTypes.ColumnHeadersHeight = 45;

            dgvPropertyTypes.ThemeStyle.HeaderStyle.BackColor = Color.White;
            dgvPropertyTypes.ThemeStyle.HeaderStyle.ForeColor = Color.Black;

            dgvPropertyTypes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvPropertyTypes.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            dgvPropertyTypes.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvPropertyTypes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvPropertyTypes.ColumnHeadersDefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Bold);

            dgvPropertyTypes.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // الصفوف
            dgvPropertyTypes.ThemeStyle.RowsStyle.Height = 45;
            dgvPropertyTypes.RowTemplate.Height = 45;

            dgvPropertyTypes.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvPropertyTypes.DefaultCellStyle.BackColor = Color.White;

            dgvPropertyTypes.ThemeStyle.RowsStyle.ForeColor =
                Color.FromArgb(35, 35, 35);

            dgvPropertyTypes.DefaultCellStyle.ForeColor =
                Color.FromArgb(35, 35, 35);

            dgvPropertyTypes.DefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Regular);

            dgvPropertyTypes.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // alternating rows
            dgvPropertyTypes.ThemeStyle.AlternatingRowsStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            dgvPropertyTypes.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            // التحديد
            dgvPropertyTypes.ThemeStyle.RowsStyle.SelectionBackColor =
                Color.FromArgb(230, 226, 255);

            dgvPropertyTypes.ThemeStyle.RowsStyle.SelectionForeColor =
                Color.FromArgb(35, 35, 35);

            dgvPropertyTypes.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 226, 255);

            dgvPropertyTypes.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(35, 35, 35);

            // إعدادات إضافية
            dgvPropertyTypes.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvPropertyTypes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvPropertyTypes.RowHeadersVisible = false;

            dgvPropertyTypes.MultiSelect = false;

            dgvPropertyTypes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvPropertyTypes.AllowUserToAddRows = false;
            dgvPropertyTypes.AllowUserToResizeRows = false;
            dgvPropertyTypes.AllowUserToResizeColumns = false;


            dgvPropertyTypes.RightToLeft = RightToLeft.Yes;


        }
        private void _FillPaymentMethods()
        {
            cbPaymentMethod.DataSource =
                this._PaymentMethodService.GetAllActive();

            cbPaymentMethod.DisplayMember =
                "PaymentMethodNameArabic";

            cbPaymentMethod.ValueMember =
                "PaymentMethodID";

            cbPaymentMethod.SelectedIndex = -1;
        }
        private void _FillInvestmentPurposes()
        {
            cbPurposeInvestment.DataSource =
                this._InvestmentPurposeService.GetAllActive(); 

            cbPurposeInvestment.DisplayMember =
                "PurposeNameArabic";

            cbPurposeInvestment.ValueMember =
                "InvestmentPurposeID";

            cbPurposeInvestment.SelectedIndex = -1;
        }
        private void _FillInterestLevels()
        {
            cbLevelOfInterest.DataSource =
                this._InterestLevelService.GetAllActive();

            cbLevelOfInterest.DisplayMember =
                "InterestLevelNameArabic";

            cbLevelOfInterest.ValueMember =
                "InterestLevelID";

            cbLevelOfInterest.SelectedIndex = -1;
        }
        private void _FillSearchTypes()
        {
            cbSearchBy.Items.Clear();

            cbSearchBy.Items.Add("اسم المدينة");
            cbSearchBy.Items.Add("رمز اللوحة");

            cbSearchBy.SelectedIndex = 0;
        }
        private async void frmAddNewInvestor_Load(object sender, EventArgs e) 
        { 
            // dgvPropertys
            StylePropertyTypesGrid();
            await _LoadAllPropertyAsync();

            // dgvCities
            StyledgvCitiesTypesGrid();
            await _LoadAllCitiesAsync();

            _FillPaymentMethods();
            _FillInvestmentPurposes();
            _FillInterestLevels();
            _FillSearchTypes();
        }
        private void dgvPropertyTypes_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (_isLoadingPropertyTypes) 
                return;

            if (dgvPropertyTypes.CurrentCell is DataGridViewCheckBoxCell &&
                dgvPropertyTypes.IsCurrentCellDirty)
            {
                dgvPropertyTypes.CommitEdit(
                    DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dgvPropertyTypes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (_isLoadingPropertyTypes)
                return;

            if (e.RowIndex < 0)
                return;

            if (dgvPropertyTypes.Columns[e.ColumnIndex].Name != "Selected")
                return;

            DataGridViewRow row =
                dgvPropertyTypes.Rows[e.RowIndex];

            InvestorPreferredPropertyTypeDTO item =
                row.DataBoundItem as InvestorPreferredPropertyTypeDTO;

            if (item == null)
                return;

            if (item.Selected)
            {
                // تم تحديد الـ CheckBox

                if (!_selectedPropertyTypes.Any(
                    x => x.PropertyTypeID == item.PropertyTypeID))
                {
                    _selectedPropertyTypes.Add(item);
                }
            }
            else
            {
                // تم إلغاء تحديد الـ CheckBox

                var existingItem =
                    _selectedPropertyTypes.FirstOrDefault(
                        x => x.PropertyTypeID == item.PropertyTypeID);

                if (existingItem != null)
                {
                    _selectedPropertyTypes.Remove(existingItem);
                }
            }
        }
        private void dgvCities_CurrentCellDirtyStateChanged(object sender, EventArgs e) 
        {
            if (this._isLoadingCities) 
                return;

            if (dgvCities.CurrentCell is DataGridViewCheckBoxCell &&
                dgvCities.IsCurrentCellDirty)
            {
                dgvCities.CommitEdit(
                    DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dgvCities_CellValueChanged(object sender, DataGridViewCellEventArgs e)  
        {

            if (this._isLoadingCities)
                return;

            if (e.RowIndex < 0)
                return;

            if (dgvCities.Columns[e.ColumnIndex].Name != "Selected")
                return;

            DataGridViewRow row =
                dgvCities.Rows[e.RowIndex];

            InvestorPreferredCitieSelectionDTO item =
                row.DataBoundItem as InvestorPreferredCitieSelectionDTO;

            if (item == null)
                return;

            if (item.Selected)
            {
                // تم تحديد الـ CheckBox

                if (!this._selectedCities.Any(
                    C => C.CitieId == item.CitieId))
                {
                    this._selectedCities.Add(item);
                }
            }
            else
            {
                // تم إلغاء تحديد الـ CheckBox

                var existingItem =
                    this._selectedCities.FirstOrDefault(
                        C => C.PlateCode == item.PlateCode); 

                if (existingItem != null)
                {
                    this._selectedCities.Remove(existingItem);
                }
            }
        }
        private bool _ValidateForm()
        {
            bool isValid = true;

            if (!ValidationHelper.ValidateRequiredComboBox(cbPaymentMethod, errorProvider1, "يرجى اختيار عمليه الدفع"))
                isValid = false;

            if (!ValidationHelper.ValidateRequiredComboBox(cbPurposeInvestment, errorProvider1, "يرجى اختيار الغرض من الاستثمار"))
                isValid = false;

            if (!ValidationHelper.ValidateRequiredComboBox(cbLevelOfInterest, errorProvider1, "يرجى اختيار مستوى الاهتمام")) 
                isValid = false;

            if (!ValidationHelper.ValidateRequiredCheckBox(cbReadyToInvest, errorProvider1, "يجب تحديد هذا الخيار"))
                isValid = false;

            return isValid;
        }
        private void btnInvestorSave_Click(object sender, EventArgs e)
        {
            if (_ValidateForm() && this._InvestorRegistrationService.RegisterInvestor(_GetInvestorRegistrationData()))
                MessageBox.Show(
                    "تم تسجيل المستثمر بنجاح.",
                    "تم التسجيل",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                MessageBox.Show(
                    "فشل تسجيل المستثمر. يرجى التحقق من البيانات والمحاولة مرة أخرى.",
                    "فشل التسجيل",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _SearchCities();
        }
        private InvestorRegistrationData _GetInvestorRegistrationData()
        {
            InvestorRegistrationData data =
                new InvestorRegistrationData();

            // =========================================
            // ClientRole
            // =========================================

            data.ClientRole.ClientID = 50;

            data.ClientRole.ClientRoleTypeID = 4;

            data.ClientRole.CreatedByUserID =
                Global.Global.CourentUser.UserID;


            // =========================================
            // InvestorDetails
            // =========================================

            data.Investor.MinimumBudget =
                nudMinBudget.Value;

            data.Investor.MaximumBudget =
                nudMaxBudget.Value;

            data.Investor.OpeningBalance =
                nudOpeningBalance.Value;


            data.Investor.PaymentMethodID =
                Convert.ToByte(cbPaymentMethod.SelectedValue);

            data.Investor.InvestmentPurposeID =
                Convert.ToByte(cbPurposeInvestment.SelectedValue);

            data.Investor.InterestLevelID =
                Convert.ToByte(cbLevelOfInterest.SelectedValue);


            data.Investor.ReadyToInvest =
               cbReadyToInvest.Checked;


            data.Investor.RepresentativeName =
                string.IsNullOrWhiteSpace(txtRepresentativeName.Text)
                    ? null
                    : txtRepresentativeName.Text.Trim();


            data.Investor.RepresentativeNationalID =
                string.IsNullOrWhiteSpace(txtRepresentativeNationalNo.Text)
                    ? null
                    : txtRepresentativeNationalNo.Text.Trim();


            data.Investor.AgencyNumber =
                string.IsNullOrWhiteSpace(txtAgencyNumber.Text)
                    ? null
                    : txtAgencyNumber.Text.Trim();


            data.Investor.AgencyDate =
                dtpAgencyDate.Value;


            data.Investor.CreatedByUserID =
                Global.Global.CourentUser.UserID;


            data.Investor.Notes =
                string.IsNullOrWhiteSpace(txtDescription.Text)
                    ? null
                    : txtDescription.Text.Trim();


            // =========================================
            // Preferred Cities
            // =========================================

            data.PreferredCityIDs =
                this._selectedCities
                    .Select(x => x.CitieId)
                    .Distinct()
                    .ToList();


            // =========================================
            // Preferred Property Types
            // =========================================

            data.PreferredPropertyTypeIDs =
                _selectedPropertyTypes
                    .Select(x => x.PropertyTypeID)
                    .Distinct()
                    .ToList();


            return data;
        }
        private void _SearchCities()
        {
            string searchText = txtSearch.Text.Trim();

            IEnumerable<InvestorPreferredCitieSelectionDTO> Result = this._Cities;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                switch (cbSearchBy.SelectedIndex)
                {
                    case 0:
                        Result = this._Cities.Where(
                            City => 
                                !string.IsNullOrWhiteSpace(City.CitieName)&&
                                City.CitieName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);
                        break;

                    case 1:
                        Result = this._Cities.Where(City => City.PlateCode.ToString().StartsWith(searchText));
                        break;
                }

            }

            try
            {
                //_isFilteringCities = true;

                dgvCities.DataSource =
                    new BindingList<InvestorPreferredCitieSelectionDTO>(
                        Result.ToList());
            }
            finally
            {
                //_isFilteringCities = false;
            }
        }

    }
}

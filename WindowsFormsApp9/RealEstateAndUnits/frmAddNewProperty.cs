using DataAccessLayer;
using Guna.UI2.WinForms;
using Interfaces;
using Models;
using Models.FormData;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REMS.UI.Client_Roles.Owner;
using REMS.UI.Client_Roles.Owner.Control.Events;
using REMS.UI.Customer_Management;
using REMS.UI.Factories;
using REMS.UI.FormDependencies;
using REMS.UI.RealEstateAndUnits.Events;
using REMS.UI.Validation;
using static System.Windows.Forms.MonthCalendar;

namespace REMS.UI.RealEstateAndUnits
{
    public partial class frmAddNewProperty : Form
    {

        private AddNewPropertyFormDependencies _deps;
        private Dictionary<int, City> _citiesCache;
        private Dictionary<int, List<District>> _districtsByCityId;

        private List<PropertyOwnership> _propertyOwnerships = new List<PropertyOwnership>();

        IImageService imageService = new ImageService();
        private int _SelectedOwnerID {  get; set; }
        public frmAddNewProperty(AddNewPropertyFormDependencies deps)
        {
            InitializeComponent();
            this._deps = deps;
        }
        private void _FillcbPropertyTypes()
        {
            var types = this._deps.PropertyTypeService.GetAll();

            cbPropertyTypes.DataSource = types;
            cbPropertyTypes.DisplayMember = "ArabicName";
            cbPropertyTypes.ValueMember = "PropertyTypeID";
        }
        private void _FillcbCities()
        {
            var cities = this._deps.CityService.GetAll().OrderBy(c => c.CityNameTurkish).ToList();

            _citiesCache =
                cities.ToDictionary(c => c.CityID, c => c);

            cbCities.SelectedIndexChanged -=
                cbCities_SelectedIndexChanged;

            cbCities.DataSource = cities; 

            cbCities.DisplayMember =
                nameof(City.CityNameTurkish);

            cbCities.ValueMember =
                nameof(City.CityID);

            cbCities.SelectedIndex = -1;

            cbCities.SelectedIndexChanged +=
                cbCities_SelectedIndexChanged;
        }
        private void _FillDistrictsByCityID(int cityID)
        {

            if (_districtsByCityId == null)
                _LoadDistrictsCache();

            if (!_districtsByCityId.TryGetValue(cityID, out var districts))
                districts = new List<District>();

            cbDistricts.DataSource = districts;
            cbDistricts.DisplayMember = nameof(District.DistrictNameTurkish);
            cbDistricts.ValueMember = nameof(District.DistrictID);
            cbDistricts.SelectedIndex = -1;
        }
        private void _LoadDistrictsCache()
        {
            _districtsByCityId = this._deps.DistrictService.GetAll().GroupBy(d => d.CityID).ToDictionary(g => g.Key, g => g.ToList());
        }
        private void cbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCities.SelectedValue == null)
                return;

            if (!int.TryParse(cbCities.SelectedValue.ToString(), out int cityID))
                return;

            _FillDistrictsByCityID(cityID);
        }
        private void _FillcbManagementCommissionTypes()
        {
            var commissionTypes = this._deps.ManagementCommissionTypeService.GetAll();

            cbManagementCommissionTypes.DataSource = commissionTypes;
            cbManagementCommissionTypes.DisplayMember = "ArabicName";
            cbManagementCommissionTypes.ValueMember = "ManagementCommissionTypeID";
        }

        private void _CreateColumns()
        {
            dgvContracts.Columns.Clear();

            dgvContracts.Columns.Add("FullName", "الاسم الكامل");
            dgvContracts.Columns.Add("NationalNo", "الرقم الوطني");
            dgvContracts.Columns.Add("PhoneNumber", "رقم الهاتف");
            dgvContracts.Columns.Add("DeedNumber", "رقم الصك");
            dgvContracts.Columns.Add("OwnershipPercentage", "نسبه الملكيه");

            // زر التعديل
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "Edit";
            btnEdit.HeaderText = "تعديل";
            btnEdit.Text = "تعديل";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.FlatStyle = FlatStyle.Standard;
            btnEdit.Width = 90;

            // زر الحذف
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Delete";
            btnDelete.HeaderText = "حذف";
            btnDelete.Text = "حذف";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.FlatStyle = FlatStyle.Standard;
            btnDelete.Width = 80;
            dgvContracts.Columns.Add(btnEdit);
            dgvContracts.Columns.Add(btnDelete);
        }
        private void _FillContractsGrid(OnPropertyOwnerShipSelectedEventArgs PropertyInfo)
        {

            dgvContracts.Rows.Add(
                PropertyInfo.OwnerCard.OwnerName, // FullName
                PropertyInfo.OwnerCard.OwnerNationalNo,// National No
                PropertyInfo.OwnerCard.OwnerPhone,// Phone Number
                PropertyInfo.propertyOwnership.DeedNumber,// Deed Number
                PropertyInfo.propertyOwnership.OwnershipPercentage // %
            );

        }
        private void _StyleContractsGrid()
        {
            dgvContracts.RightToLeft = RightToLeft.Yes;
            dgvContracts.EnableHeadersVisualStyles = false;

            // الشكل العام
            dgvContracts.BorderStyle = BorderStyle.None;
            dgvContracts.BackgroundColor = Color.White;
            dgvContracts.GridColor = Color.FromArgb(230, 230, 230);
            dgvContracts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvContracts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvContracts.RowHeadersVisible = false;

            // الهيدر
            dgvContracts.ColumnHeadersHeight = 45;
            dgvContracts.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvContracts.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvContracts.ColumnHeadersDefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Bold);
            dgvContracts.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // الصفوف
            dgvContracts.RowTemplate.Height = 50;
            dgvContracts.DefaultCellStyle.BackColor = Color.White;
            dgvContracts.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvContracts.DefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Regular);
            dgvContracts.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // ========================
            // إعدادات زر التعديل
            // ========================
            dgvContracts.Columns["Edit"].DefaultCellStyle.Font =
                new Font("Cairo", 9, FontStyle.Bold);

            dgvContracts.Columns["Edit"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvContracts.Columns["Edit"].DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(225, 238, 252);

            dgvContracts.Columns["Edit"].DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(25, 90, 165);


            // ========================
            // إعدادات زر الحذف
            // ========================
            dgvContracts.Columns["Delete"].DefaultCellStyle.Font =
                new Font("Cairo", 9, FontStyle.Bold);

            dgvContracts.Columns["Delete"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvContracts.Columns["Delete"].DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(255, 232, 232);

            dgvContracts.Columns["Delete"].DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(170, 35, 35);

            // الصف المتناوب
            dgvContracts.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            // التحديد
            dgvContracts.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 245, 255);
            dgvContracts.DefaultCellStyle.SelectionForeColor = Color.Black;

            // الحجم
            dgvContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContracts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContracts.MultiSelect = false;
            dgvContracts.AllowUserToAddRows = false;
            dgvContracts.AllowUserToResizeRows = false;

            dgvContracts.EnableHeadersVisualStyles = false;

            dgvContracts.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvContracts.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // هذا السطر هو المهم:
            dgvContracts.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvContracts.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void frmAddNewProperty_Load(object sender, EventArgs e)
        {
            _FillcbPropertyTypes();
            _FillcbCities();
            _FillcbManagementCommissionTypes();


            // Data Grade view style
            _CreateColumns();
            _StyleContractsGrid();
        }
        private void _OnOwnerSelected(object sender, OnOwnerSelectedEventArgs e)
        {
            txtOwnerName.Text = e.OwnerCard.OwnerName;
            this._SelectedOwnerID = e.OwnerCard.OwnerID; // Letar Handling
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {

            frmFindOwner frm = new frmFindOwner();
            frm.OnOwnerSelected += _OnOwnerSelected;
            frm.ShowDialog();

            //frmAddEditClient frm = new frmAddEditClient(this._deps);
            //frm.ShowDialog();
        }
        private bool _SaveProperty()
        {
            PropertyRegistrationData fromData = _GetFormData();

            PropertyRegistrationData PropertyApplicationinfo = new PropertyRegistrationData
            {
                Property = fromData.Property,
                PropertyOwnership = fromData.PropertyOwnership,
                PropertyEvaluation = fromData.PropertyEvaluation,
            };


            return this._deps.PropertyApplicationService.Add(PropertyApplicationinfo) > 0;  
        }

        private PropertyOwnership _GetMainOwnerFromControls()
        {
            return new PropertyOwnership
            {
                OwnerID = this._SelectedOwnerID,
                DeedNumber = txtInstrumentNumber.Text.Trim(),
                DeedDate = dtbDateOfInstrument.Value,
                LandNumber = txtPlotNumber.Text.Trim(),
                OwnershipStatusID = null,
                DeedImagePath = _HandleDeedImage(),
                OwnershipPercentage = txtOwnershipPercentage.Value,
                CreatedByUserID = Global.Global.CourentUser.UserID,
                IsPrimaryOwner = CBPrimaryOwner.Checked
            };
        }

        private List<PropertyOwnership> _GetAllOwnerships()
        {
            List<PropertyOwnership> ownerships = new List<PropertyOwnership>();

            // 1. أضف المالك الرئيسي القادم من الحقول
            ownerships.Add(_GetMainOwnerFromControls());

            // 2. أضف الشركاء الموجودين في الـ DataGridView
            ownerships.AddRange(_propertyOwnerships);

            return ownerships;
        }
        private PropertyRegistrationData _GetFormData()
        {
            return new PropertyRegistrationData
            {
                Property = new Property
                {
                    PropertyName = txtPropertyName.Text.Trim(),
                    PropertyTypeID = Convert.ToInt32(cbPropertyTypes.SelectedValue),
                    Address = txtPropertyAddress.Text.Trim(),
                    CityID = Convert.ToInt32(cbCities.SelectedValue),
                    DistrictID = Convert.ToInt32(cbDistricts.SelectedValue),
                    Area = txtPropertyArea.Value,
                    BuildingYear = (short)txtBuldingYear.Value,
                    Description = txtDescription.Text.Trim(),
                    ManagementCommissionValue = txtCommission.Value,
                    ManagementCommissionTypeID = Convert.ToInt32(cbManagementCommissionTypes.SelectedValue),
                    IsSubjectToVAT = cbIsSubjecttoVat.Checked,
                    CreatedByUserID = Global.Global.CourentUser.UserID
                },

                PropertyOwnership = _GetAllOwnerships(),


                PropertyEvaluation = new PropertyEvaluation
                {
                    Rating = (byte)rsPropertyEvaluation.Value,
                    EvaluationAmount = txtValuationAmount.Value,
                    PurchasePrice = txtPurchasePrice.Value,
                    EvaluationDate = dtpEvaluationDate.Value,
                    EvaluatedBy = txtResidentialEntity.Text.Trim(),
                    CreatedByUserID = Global.Global.CourentUser.UserID
                }
            };
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_ValidateForm())
            {
                MessageBox.Show("لا يمكن إتمام العملية. يرجى التأكد من إدخال جميع البيانات المطلوبة.",
                "تنبيه",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning); ;

                return;
            }

            if (_SaveProperty())
            {
                MessageBox.Show(
                    "تم حفظ معلومات العقار بنجاح.",
                    "تمت العملية بنجاح",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "فشلت عملية حفظ معلومات العقار، يرجى المحاولة مرة أخرى.",
                    "فشل العملية",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }


        private string _HandleDeedImage() 
        {
            string ImageFolder = @"C:\\REMS_DeedImages";

            string NewPath = imageService.SaveImage(openFileDialog1.FileName.ToString(), ImageFolder);

            if (NewPath != null)
            {
                return NewPath;
            }
            
            return null;
        }
        private bool _ValidateForm()  
        {
            bool isValid = true; 

            if (!ValidationHelper.ValidateRequiredTextBox(txtPropertyName, errorProvider1, "اسم العقار مطلوب"))
                isValid = false;

            if (!ValidationHelper.ValidateRequiredTextBox(txtPropertyAddress, errorProvider1, "عنوان العقار مطلوب"))
                isValid = false;

            if (!ValidationHelper.ValidateRequiredComboBox(cbPropertyTypes, errorProvider1, "نوع العقار مطلوب")) 
                isValid = false;

            return isValid;
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام
            if (char.IsDigit(e.KeyChar))
                return;

            // السماح بـ Backspace
            if (e.KeyChar == (char)Keys.Back)
                return;

            // منع أي شيء آخر
            e.Handled = true;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSuccess.Visible = true;
            }

        }

        private void _OnPropertyOwnerShipSelected(object sender, OnPropertyOwnerShipSelectedEventArgs e)
        {
            _propertyOwnerships.Add(e.propertyOwnership);
            _FillContractsGrid(e);
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmAddPropertyOwnerships frm = new frmAddPropertyOwnerships();
            frm.OnPropertyOwnerShipSelected += _OnPropertyOwnerShipSelected;
            frm.ShowDialog();
        }
    }
}
 
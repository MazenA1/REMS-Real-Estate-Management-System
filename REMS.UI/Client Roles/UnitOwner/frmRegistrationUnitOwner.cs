using Models;
using Models.Events;
using REMS.UI.Factories;
using REMS.UI.RealEstateAndUnits;
using REMS.UI.RealEstateAndUnits.Events;
using REMS.UI.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace REMS.UI.Client_Roles.UnitOwner
{
    /// <summary>
    /// Manages the registration of unit ownership,
    /// including co-owner, ownership percentages,
    /// ownership representatives, and unit selection.
    /// </summary>
    public partial class frmRegistrationUnitOwner : Form
    {
        private int _CuurentClientID = -1;
        private string _SelectedImagePath = string.Empty;
        private decimal _totalPercentage;

        /// <summary>
        /// Gets or updates the total ownership percentage
        /// and notifies the form when the value changes.
        /// </summary>
        private decimal TotalPercentage
        {
            get => _totalPercentage;

            set
            {
                if (_totalPercentage == value)
                    return;

                _totalPercentage = value;

                TotalPercentageChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Occurs when the total ownership percentage changes.
        /// </summary>
        private event EventHandler TotalPercentageChanged;

        /// <summary>
        /// Represents the owner who initiated the unit ownership registration process.
        /// This owner is loaded using the client ID passed to the registration form
        /// and is managed separately from the co-owners displayed in the grid.
        /// </summary>
        private UnitOwnerRegistrationItem _CurrentOwner;

        /// <summary>
        /// Contains the co-owners added during the unit ownership registration process.
        /// This collection is bound directly to the DataGridView, allowing the UI
        /// to automatically reflect additions, removals, and property changes.
        /// The current owner is not included in this collection.
        /// </summary>
        private BindingList<UnitOwnerRegistrationItem> _Co_Owners = new BindingList<UnitOwnerRegistrationItem>();

        public frmRegistrationUnitOwner(int CuurentClientID)
        {
            InitializeComponent();

            this._CuurentClientID = CuurentClientID;

            _InitializeForm();
        }


        [Conditional("DEBUG")]
        private void _DebugTrace(string message)
        {
            Debug.WriteLine($"[{nameof(frmManageUnitCoOwners)}] {message}");
        }

        /// <summary>
        /// Recalculates the ownership summary using the current owners list
        /// and updates the displayed owner count.
        /// </summary>
        private void _CalculateOwnershipSummary()
        {
            TotalPercentage =
                _Co_Owners.Sum(owner => owner.OwnershipPercentage);

            _UpdatePersonCount();
        }

        private void Frm_TotalPercentageChanged(object sender, EventArgs e)
        {
            // Refresh the ownership summary displayed to the user.

            lblTotalPercentage.Text =
                $"{TotalPercentage}%";

            lblRemainingPercentage.Text =
                $"{100m - TotalPercentage}%";
        }

        /// <summary>
        /// Return the total number of owners,
        /// including the current client and all added co-owner. 
        /// </summary>
        private int _GetPersonCount()
        {
            return (this._CuurentClientID != -1 ? 1 : 0) + this._Co_Owners.Count;
        }

        /// <summary>
        /// Configures the owners grid and binds it to the owners list.
        /// </summary>
        private void _InitializeOwnersGrid()
        {
            dgvUnitCoOwner.AutoGenerateColumns = false;

            _InitializeUnitCoOwnerColumns();

            _InitializeUnitCoOwnerStyle();

            dgvUnitCoOwner.DataSource = _Co_Owners;
        }

        /// <summary>
        /// Creates and configures the columns used to display
        /// and edit unit co-owner information.
        /// </summary>
        private void _InitializeUnitCoOwnerColumns()
        {
            dgvUnitCoOwner.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colFullName =
                new DataGridViewTextBoxColumn();

            colFullName.Name = "colFullName";
            colFullName.HeaderText = "الاسم الكامل";
            colFullName.DataPropertyName =
                nameof(UnitOwnerRegistrationItem.FullName);
             
            dgvUnitCoOwner.Columns.Add(colFullName);


            DataGridViewTextBoxColumn colNationalNo =
                new DataGridViewTextBoxColumn();

            colNationalNo.Name = "colNationalNo";
            colNationalNo.HeaderText = "الرقم الوطني";
            colNationalNo.DataPropertyName =
                nameof(UnitOwnerRegistrationItem.NationalNo);

            dgvUnitCoOwner.Columns.Add(colNationalNo);


            DataGridViewTextBoxColumn colPhoneNumber =
                new DataGridViewTextBoxColumn();

            colPhoneNumber.Name = "colPhoneNumber";
            colPhoneNumber.HeaderText = "رقم الهاتف";
            colPhoneNumber.DataPropertyName =
                nameof(UnitOwnerRegistrationItem.PhoneNumber);

            dgvUnitCoOwner.Columns.Add(colPhoneNumber);


            DataGridViewTextBoxColumn colDeedNumber =
                new DataGridViewTextBoxColumn();

            colDeedNumber.Name = "colDeedNumber";
            colDeedNumber.HeaderText = "رقم الصك";
            colDeedNumber.DataPropertyName =
                nameof(UnitOwnerRegistrationItem.DeedNumber);

            dgvUnitCoOwner.Columns.Add(colDeedNumber);


            DataGridViewTextBoxColumn colOwnershipPercentage =
                new DataGridViewTextBoxColumn();

            colOwnershipPercentage.Name = "colOwnershipPercentage";
            colOwnershipPercentage.HeaderText = "نسبة الملكية";
            colOwnershipPercentage.DataPropertyName =
                nameof(UnitOwnerRegistrationItem.OwnershipPercentage);

            dgvUnitCoOwner.Columns.Add(colOwnershipPercentage);


            DataGridViewCheckBoxColumn colIsOwnershipRepresentative =
                new DataGridViewCheckBoxColumn();

            colIsOwnershipRepresentative.Name =
                "colIsOwnershipRepresentative";

            colIsOwnershipRepresentative.HeaderText =
                "ممثل الملاك";

            colIsOwnershipRepresentative.DataPropertyName =
                nameof(UnitOwnerRegistrationItem.IsOwnershipRepresentative);

            colIsOwnershipRepresentative.Width = 100;

            dgvUnitCoOwner.Columns.Add(colIsOwnershipRepresentative);


            DataGridViewButtonColumn btnDelete =
                new DataGridViewButtonColumn();

            btnDelete.Name = "Delete";
            btnDelete.HeaderText = "حذف";
            btnDelete.Text = "حذف";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.FlatStyle = FlatStyle.Standard;
            btnDelete.Width = 80;

            dgvUnitCoOwner.Columns.Add(btnDelete);


            dgvUnitCoOwner.Columns["colFullName"].ReadOnly = true;
            dgvUnitCoOwner.Columns["colNationalNo"].ReadOnly = true;
            dgvUnitCoOwner.Columns["colPhoneNumber"].ReadOnly = true;

            dgvUnitCoOwner.Columns["colDeedNumber"].ReadOnly = false;
            dgvUnitCoOwner.Columns["colOwnershipPercentage"].ReadOnly = false;

            dgvUnitCoOwner.Columns["colIsOwnershipRepresentative"].ReadOnly = false;

            dgvUnitCoOwner.CellContentClick += dgvUnitCoOwner_CellContentClick;
        }

        /// <summary>
        /// Applies the visual and interaction settings
        /// for the unit co-owners grid.
        /// </summary>
        private void _InitializeUnitCoOwnerStyle()
        {
            dgvUnitCoOwner.RightToLeft = RightToLeft.Yes;
            dgvUnitCoOwner.EnableHeadersVisualStyles = false;

            // الشكل العام
            dgvUnitCoOwner.BorderStyle = BorderStyle.None;
            dgvUnitCoOwner.BackgroundColor = Color.White;
            dgvUnitCoOwner.GridColor = Color.FromArgb(230, 230, 230);
            dgvUnitCoOwner.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUnitCoOwner.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvUnitCoOwner.RowHeadersVisible = false;

            // الهيدر
            dgvUnitCoOwner.ColumnHeadersHeight = 45;
            dgvUnitCoOwner.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvUnitCoOwner.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvUnitCoOwner.ColumnHeadersDefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Bold);
            dgvUnitCoOwner.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // الصفوف
            dgvUnitCoOwner.RowTemplate.Height = 50;
            dgvUnitCoOwner.DefaultCellStyle.BackColor = Color.White;
            dgvUnitCoOwner.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvUnitCoOwner.DefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Regular);
            dgvUnitCoOwner.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // ========================
            // إعدادات زر التعديل
            // ========================
            //dgvUnitCoOwner.Columns["Edit"].DefaultCellStyle.Font =
            //    new Font("Cairo", 9, FontStyle.Bold);

            //dgvUnitCoOwner.Columns["Edit"].DefaultCellStyle.Alignment =
            //    DataGridViewContentAlignment.MiddleCenter;

            //dgvUnitCoOwner.Columns["Edit"].DefaultCellStyle.SelectionBackColor =
            //    Color.FromArgb(225, 238, 252);

            //dgvUnitCoOwner.Columns["Edit"].DefaultCellStyle.SelectionForeColor =
            //    Color.FromArgb(25, 90, 165);


            // ========================
            // إعدادات زر الحذف
            // ========================
            dgvUnitCoOwner.Columns["Delete"].DefaultCellStyle.Font =
                new Font("Cairo", 9, FontStyle.Bold);

            dgvUnitCoOwner.Columns["Delete"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvUnitCoOwner.Columns["Delete"].DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(255, 232, 232);

            dgvUnitCoOwner.Columns["Delete"].DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(170, 35, 35);

            // الصف المتناوب
            dgvUnitCoOwner.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            // التحديد
            dgvUnitCoOwner.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 245, 255);
            dgvUnitCoOwner.DefaultCellStyle.SelectionForeColor = Color.Black;

            // الحجم
            dgvUnitCoOwner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnitCoOwner.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnitCoOwner.MultiSelect = false;
            dgvUnitCoOwner.AllowUserToAddRows = false;
            dgvUnitCoOwner.AllowUserToResizeRows = false;

            dgvUnitCoOwner.EnableHeadersVisualStyles = false;

            dgvUnitCoOwner.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvUnitCoOwner.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // هذا السطر هو المهم:
            dgvUnitCoOwner.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvUnitCoOwner.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void dgvUnitCoOwner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvUnitCoOwner.Columns[e.ColumnIndex].Name != "Delete")
                return;

            UnitOwnerRegistrationItem owner =
                dgvUnitCoOwner.Rows[e.RowIndex].DataBoundItem
                as UnitOwnerRegistrationItem;

            if (owner == null)
                return;

            this._Co_Owners.Remove(owner);

            //_CalculateOwnershipSummary();
        }

        private void _InitializeForm()
        {
            _InitializeOwnersGrid();

            _InitializeDefultValue();

            TotalPercentageChanged += Frm_TotalPercentageChanged;
            _Co_Owners.ListChanged += _Owners_ListChanged;
        }

        /// <summary>
        /// Responds to changes in the owners collection
        /// and refreshes ownership summary information.
        /// </summary>
        private void _Owners_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                case ListChangedType.ItemDeleted:
                case ListChangedType.Reset:

                    _CalculateOwnershipSummary();

                    break;

                case ListChangedType.ItemChanged:

                    if (e.PropertyDescriptor?.Name ==
                        nameof(UnitOwnerRegistrationItem.OwnershipPercentage))
                    {
                        _CalculateOwnershipSummary();
                    }

                    break;
            }

            if (e.ListChangedType == ListChangedType.ItemChanged &&
            e.NewIndex >= 0 &&
            e.NewIndex < _Co_Owners.Count)
            {
                UnitOwnerRegistrationItem owner =
                    _Co_Owners[e.NewIndex];
            }

        }

        private void _UpdatePersonCount()
        {
            LabPersonCount.Text = _GetPersonCount().ToString();
        }

        /// <summary>
        /// Initializes the default registration values
        /// displayed when the form is opened.
        /// </summary>
        private void _InitializeDefultValue()
        {
            txtCreationUserID.Text = Global.Global.CourentUser.UserID.ToString();
            txtCreatedDate.Text = DateTime.Now.ToString();

            _UpdatePersonCount();
        }

        private void FrmFindProperty_PropertyAndUnitSelected(object sender, PropertyAndUnitSelectedEventArgs e)
        {
            txtUnitID.Text = e.Unit.UnitNumber.ToString() + " - " + e.Unit.BuildingNumber + " - " + e.Property.PropertyName; 
        } 

        private void btnSelectUnit_Click(object sender, EventArgs e)
        {
            frmFindPropertyBasicInfo frm = new frmFindPropertyBasicInfo();
            frm.PropertyAndUnitSelected += FrmFindProperty_PropertyAndUnitSelected;
            frm.ShowDialog();
        }

        private void btnAddCoOwner_Click(object sender, EventArgs e)
        {
            frmManageUnitCoOwners frm = new frmManageUnitCoOwners();
            frm.UnitCoOwnerSelected += FrmManageUnitCoOwners_UnitCoOwnerSelected;
            frm.ShowDialog();
        }


        /// <summary>
        /// Determines whether the specified client has already
        /// been added to the owners list.
        /// </summary>
        /// <param name="clientID">The client ID to check.</param>
        /// <returns>
        /// True if the client already exists in the owners list;
        /// otherwise, false.
        /// </returns>
        private bool _isDuplicateOwner(int ClientID)  
        {
            if (this._Co_Owners == null)
            {
                return false;
            }

            return this._Co_Owners.Any(Owner => Owner.ClientID == ClientID);
        }

        /// <summary>
        /// Returns all owners participating in the current ownership registration,
        /// including the current owner and all added co-owners.
        /// </summary>
        private List<UnitOwnerRegistrationItem> _GetAllOwners()
        {
            List<UnitOwnerRegistrationItem> owners =
                new List<UnitOwnerRegistrationItem>();

            if (_CurrentOwner != null)
                owners.Add(_CurrentOwner);

            owners.AddRange(_Co_Owners);

            return owners;
        }

        private void FrmManageUnitCoOwners_UnitCoOwnerSelected(object sender ,UnitCoOwnerSelectedEventArgs e)  
        {

            UnitOwnerRegistrationItem SelectedCo_Owner = e.Owner;

            if (_isDuplicateOwner(SelectedCo_Owner.ClientID))
            {
                MessageBox.Show(
                    "تمت إضافة هذا العميل كمالك بالفعل."); 

                return;
            }

            this._Co_Owners.Add(SelectedCo_Owner);

            _CalculateOwnershipSummary(); 

        }

        private void btnDelteCoowners_Click(object sender, EventArgs e)
        {
            this._Co_Owners.Clear();
        }

        private bool _ValidateForm() 
        {
            bool isValid = true;

            if (!ValidationHelper.ValidateRequiredTextBox(txtUnitID, errorProvider1, "يرجى اختيار الوحده"))
                isValid = false;

            if (!ValidationHelper.ValidateRequiredTextBox(txtDeedNumber, errorProvider1, "يرجى اختيار رقم السند")) 
                isValid = false;

            if (!ValidationHelper.ValidateRequiredTextBox(txtOwnershipPercentage, errorProvider1, "يرجى اختيار النسبه"))
                isValid = false;

            return isValid;

        }
        private UnitOwnerRegistrationItem _BuildCurrentOwnerRegistration()
        {
            if (!_ValidateForm())
            {
                MessageBox.Show("لا يمكن إتمام العملية. يرجى التأكد من إدخال جميع البيانات المطلوبة.",
                    "تنبيه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return null;
            }

            return new UnitOwnerRegistrationItem() 
            {
                ClientID = this._CuurentClientID,
                PersonID = -1,
                PersonInfo = null,
                DeedDate = dtbDateOfInstrument.Value,
                DeedNumber = txtDeedNumber.Text,
                Notes = txtOwnerShipDescription.Text,
                IsOwnershipRepresentative = chkOwnershipRepresentative.Checked,
                DeedImagePath = this._SelectedImagePath,
                OwnershipPercentage = Convert.ToDecimal(txtOwnershipPercentage.Text),
                
            } ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UnitOwnerRegistrationItem CurrentOwnerRegistrationItem
                = _BuildCurrentOwnerRegistration();
        }

        private void LlAddDeedImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string SelectedPath = openFileDialog1.FileName;

                if (!string.IsNullOrWhiteSpace(SelectedPath))
                {
                    this._SelectedImagePath = SelectedPath;
                    pbSuccess.Visible = true; 
                }

                else
                    pbCancel.Visible = true;
            }
        }
    }
}

using Models;
using Models.Enum;
using Models.Events;
using REMS.UI.Factories;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Interfaces;
using System.IO;

namespace REMS.UI.Client_Roles.UnitOwner
{
    /// <summary>
    /// Provides a form for selecting a client as a unit co-owner,
    /// entering ownership details, and returning the completed
    /// registration item to the caller.
    /// </summary>
    public partial class frmManageUnitCoOwners : Form
    {
        /// <summary>
        /// Occurs when a unit co-owner has been selected
        /// and the ownership information has been completed.
        /// </summary>
        public event EventHandler<UnitCoOwnerSelectedEventArgs> UnitCoOwnerSelected;

        private string _selectedDeedImagePath;
        public frmManageUnitCoOwners()
        {

            InitializeComponent();

            _InitializeForm();

        }

        [Conditional("DEBUG")] 
        private void _DebugTrace(string message) 
        {
            Debug.WriteLine($"[{nameof(frmManageUnitCoOwners)}] {message}");
        }

        private void _InitializeControl()
        {
            ctrlCommonSection_Person_ClientSelector1.SetServices(ServiceFactory.CreateClientService(), ServiceFactory.CreateUserService());
        }

        private void _LoadValue()
        {
            txtClientID.Text = ctrlCommonSection_Person_ClientSelector1.HasClient
                ? ctrlCommonSection_Person_ClientSelector1.SelectedClientID.ToString() : "0";

            txtPersonID.Text = ctrlCommonSection_Person_ClientSelector1.HasPerson
                ? ctrlCommonSection_Person_ClientSelector1.SelectedPersonID.ToString() : "0";
        }

        private void _InitializeForm()
        {
            _InitializeControl();

            _LoadValue();
        }

        public void RaiseUnitCoOwnerSelected(UnitOwnerRegistrationItem unitOwnerRegistrationItem) 
        {
             RaiseUnitCoOwnerSelected(new UnitCoOwnerSelectedEventArgs(unitOwnerRegistrationItem));
        }

        public virtual void RaiseUnitCoOwnerSelected(UnitCoOwnerSelectedEventArgs e)
        {
            UnitCoOwnerSelected?.Invoke(this, e);
        }

        /// <summary>
        /// Validation the entered ownership information and creates
        /// a unit owner registration item when the data is valid.
        /// </summary>
        /// <param name="item">
        /// When this method returns true, contains the completed
        /// unit owner registration item; otherwise, null.
        /// </param>
        /// <returns>
        /// True if the entered data is valid and the registration 
        /// item was created successfully; othewise, false.
        /// </returns>
        private bool TryBuildUnitOwnerRegistrationItem(out UnitOwnerRegistrationItem item)
        {
            item = null;

            _DebugTrace("Bulging UnitOwnerRegistrationItem");


            if (!ctrlCommonSection_Person_ClientSelector1.HasPerson) 
            {
                _DebugTrace("Build failed : No person selected");

                MessageBox.Show("يُرجى اختيار شخص.");
                return false;
            }

            if (!ctrlCommonSection_Person_ClientSelector1.HasClient) 
            {
                _DebugTrace("Build failed : No client selected"); 


                MessageBox.Show("الشخص المختار ليس عميلاً صالحاً.");
                return false;
            }

            if (!decimal.TryParse(txtOwnershipPercentage.Text,
                                  out decimal ownershipPercentage))
            {
                _DebugTrace(
                    $"Invalid ownership percentage: {txtOwnershipPercentage.Text}");


                MessageBox.Show("يرجى إدخال نسبة ملكية صحيحة.");
                txtOwnershipPercentage.Focus();
                return false;
            }

            if (ownershipPercentage <= 0 || ownershipPercentage > 100)
            {
                _DebugTrace($"Constraint failed {txtOwnershipPercentage.Name} :" +
                    $" Ownership percentage must be between 0 and 100 "); 

                MessageBox.Show("يجب أن تتراوح نسبة الملكية بين 0 و100.");
                txtOwnershipPercentage.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(_selectedDeedImagePath))
            {
                MessageBox.Show(
                    "يُرجى اختيار صورة للسند.");

                return false;
            }

            if (!File.Exists(_selectedDeedImagePath))
            {
                MessageBox.Show(
                    "تعذّر العثور على صورة الصكّ المختارة.");

                return false;
            }

            item = new UnitOwnerRegistrationItem
            {
                PersonID = ctrlCommonSection_Person_ClientSelector1.SelectedPersonID,

                PersonInfo = ctrlCommonSection_Person_ClientSelector1.PersonInfo,

                ClientID = ctrlCommonSection_Person_ClientSelector1.SelectedClientID,

                OwnershipPercentage = ownershipPercentage,

                IsOwnershipRepresentative =
                    chkOwnershipRepresentative.Checked,

                DeedNumber =
                    string.IsNullOrWhiteSpace(txtDeedNumber.Text)
                        ? null
                        : txtDeedNumber.Text.Trim(),

                DeedDate =
                    dtpDeedDate.Checked
                        ? dtpDeedDate.Value.Date
                        : (DateTime?)null,

                DeedImagePath = this._selectedDeedImagePath,

                Notes =
                    string.IsNullOrWhiteSpace(txtNotes.Text)
                        ? null
                        : txtNotes.Text.Trim()
            };

            return true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (!TryBuildUnitOwnerRegistrationItem(out UnitOwnerRegistrationItem item))
                return;

            _DebugTrace($"Raising UnitCoOwnerSelected for ClientID={item.ClientID} ClientName={item.PersonInfo.FullName}."); 

            RaiseUnitCoOwnerSelected(item);

            this.Close();
        }

        private void btnNextt_Click(object sender, EventArgs e)
        {

            if (!ctrlCommonSection_Person_ClientSelector1.HasPerson)
            {
                MessageBox.Show("يرجى اختيار شخص.");
                return;
            }

            if (!ctrlCommonSection_Person_ClientSelector1.HasClient)
            {
                MessageBox.Show(
                    "يجب أن يكون الشخص المختار مسجلاً كعميل.");
                return;
            }

            _LoadValue();

            tcManageUnitCoOwners.SelectedTab = tabUnitCoOwner;

        }

        private void liSetDeedImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() !=
                DialogResult.OK)
                return;

            this._selectedDeedImagePath = 
                openFileDialog1.FileName;

            pbSuccess.Visible = true;
        }

    }
}

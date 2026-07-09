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

namespace REMS.UI.Client_Roles.Owner.Control
{
    public partial class ctrlOwnerInfoCard : UserControl
    {
        private IOwnerService _ownerService;
        private OwnerCardDTO _ownerCard;

        public ctrlOwnerInfoCard()
        {
            InitializeComponent();
        }

        public ctrlOwnerInfoCard(IOwnerService ownerService)
        {
            InitializeComponent();
            _ownerService = ownerService;
        }

        public OwnerCardDTO SelectedOwnerCard
        {
            get { return this._ownerCard; }
        }

        public int OwnerID
        {
            get { return _ownerCard == null ? -1 : _ownerCard.OwnerID; }
        }

        public void SetServices(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        public bool LoadOwnerByOwnerID(int ownerID)
        {
            if (_ownerService == null)
            {
                MessageBox.Show("Owner service is not initialized.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            if (ownerID <= 0)
            {
                _ResetOwnerInfo();
                return false;
            }

            _ownerCard = _ownerService.GetOwnerCardByID(ownerID);

            if (_ownerCard == null)
            {
                _ResetOwnerInfo();

                MessageBox.Show("لم يتم العثور على بيانات المالك.",
                    "تنبيه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            _FillOwnerInfo();
            return true;
        }

        public bool LoadOwnerByNationalNo(string nationalNo)
        {
            if (_ownerService == null)
            {
                MessageBox.Show("Owner service is not initialized.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            if (string.IsNullOrWhiteSpace(nationalNo))
            {
                _ResetOwnerInfo();
                return false;
            }

            _ownerCard = _ownerService.GetOwnerCardByNationalNo(nationalNo.Trim());

            if (_ownerCard == null)
            {
                _ResetOwnerInfo();

                MessageBox.Show("لم يتم العثور على بيانات المالك.",
                    "تنبيه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            _FillOwnerInfo();
            return true;
        }

        private void _FillOwnerInfo()
        {
            txtOwnerID.Text = _ownerCard.OwnerID.ToString();

            //txtOwnerName.Text = _ownerCard.OwnerName;
            //txtOwnerNationalNo.Text = _ownerCard.OwnerNationalNo;
            //txtOwnerPhone.Text = _ownerCard.OwnerPhone;

            txtOwnerRepresentativeName.Text = _ownerCard.RepresentativeName;
            txtOwnerRepresentativeNationalID.Text = _ownerCard.RepresentativeNationalID;
            txtOwnerRepresentativePhone.Text = _ownerCard.RepresentativePhone;

            if (_ownerCard.RepresentativeDateOfBirth.HasValue)
                dtpReprasentativDateOfBirth.Value = _ownerCard.RepresentativeDateOfBirth.Value;
            else
                dtpReprasentativDateOfBirth.Value = DateTime.Now;

            txtAgancyNumber.Text = _ownerCard.AgencyNumber;

            if (_ownerCard.AgencyDate.HasValue)
                dtpAgancyDate.Value = _ownerCard.AgencyDate.Value;
            else
                dtpAgancyDate.Value = DateTime.Now;

            if (_ownerCard.NationalityID.HasValue)
                cbCountries.SelectedValue = _ownerCard.NationalityID.Value;
            else
                cbCountries.SelectedIndex = -1;

            CbNameOfConductor.Text = _ownerCard.NameOfConductor;

            txtOpeningBalance.Text = _ownerCard.OpeningBalance.HasValue
                ? _ownerCard.OpeningBalance.Value.ToString("0.##")
                : "0";

            //rbCreditor.Checked = _ownerCard.MovementType;
            //rbDebtor.Checked = !_ownerCard.MovementType;
        }

        private void _ResetOwnerInfo()
        {
            _ownerCard = null;

            txtOwnerID.Text = string.Empty;

            //txtOwnerName.Text = string.Empty;
            //txtOwnerNationalNo.Text = string.Empty;
            //txtOwnerPhone.Text = string.Empty;

            txtOwnerRepresentativeName.Text = string.Empty;
            txtOwnerRepresentativeNationalID.Text = string.Empty;
            txtOwnerRepresentativePhone.Text = string.Empty;

            //txtOwnerAgancyNumber.Text = string.Empty;

            txtOpeningBalance.Text = "0";

            CbNameOfConductor.SelectedIndex = -1;
            cbCountries.SelectedIndex = -1;

            rbDebtor.Checked = true;
            rbCreditor.Checked = false;

            dtpReprasentativDateOfBirth.Value = DateTime.Now;
            dtpAgancyDate.Value = DateTime.Now;
        }
    }
}


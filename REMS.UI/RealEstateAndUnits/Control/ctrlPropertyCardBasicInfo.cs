using Interfaces;
using Models.DTOs;
using Models.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace REMS.UI.RealEstateAndUnits.Control
{
    public partial class ctrlPropertyCardBasicInfo : UserControl
    {

        private IPropertyService _propertyService;

        private int _propertyID = -1;

        private PropertyBasicInfoDTO _property;

        public int PropertyID
        {
            get
            {
                return _propertyID;
            }
        }


        public PropertyBasicInfoDTO PropertyInfo
        {
            get
            {
                return _property;
            }
        }


        public bool HasProperty
        {
            get
            {
                return _property != null &&
                       _propertyID > 0;
            }
        }

        public event EventHandler<PropertyActionEventArgs>
            AddUnitRequested;

        public event EventHandler<PropertyActionEventArgs>
            ShowUnitsRequested;


        public ctrlPropertyCardBasicInfo()
        {
           InitializeComponent();

           _InitializeControl();
        }


        public ctrlPropertyCardBasicInfo( 
            IPropertyService propertyService)
            : this()
        {
            _propertyService = propertyService;
        }

        public void SetPropertyService(
            IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }


        private void _InitializeControl()
        {
            _WireEvents();

            Clear();
        }

        private void _WireEvents()
        {
            lnkAddUnit.LinkClicked +=
                lnkAddUnit_LinkClicked;

            lnkShowUnits.LinkClicked +=
                lnkShowUnits_LinkClicked;
        }
        public bool LoadProperty(int propertyID)
        {
            if (propertyID <= 0)
            {
                Clear();
                return false;
            }


            if (_propertyService == null)
            {
                throw new InvalidOperationException(
                    "PropertyService has not been initialized.");
            }


            PropertyBasicInfoDTO property =
                _propertyService.GetPropertyCardInfoByID(
                    propertyID);


            if (property == null)
            {
                Clear();
                return false;
            }


            this._property = property; 

            this._propertyID =
                property.PropertyID;


            _FillPropertyData();

            _EnableUnitLinks(true);

            return true;
        }

        private void _FillPropertyData()
        {
            if (_property == null)
                return;


            txtPropertyID.Text =
                _property.PropertyID.ToString();


            txtPropertyCode.Text =
                _property.PropertyCode.ToString();


            txtPropertyName.Text =
                _property.PropertyName ?? string.Empty;


            txtBuildingYear.Text =
                _property.BuildingYear.HasValue
                    ? _property.BuildingYear.Value.ToString()
                    : string.Empty;


            txtCity.Text =
                _property.CityName ?? string.Empty;


            txtDistrict.Text =
                _property.DistrictName ?? string.Empty;


            txtArea.Text =
                _property.Area.HasValue
                    ? _property.Area.Value.ToString("N2")
                    : string.Empty;


            txtManagementCommissionType.Text =
                _property.ManagementCommissionTypeName
                ?? string.Empty;


            txtManagementCommissionValue.Text =
                _property.ManagementCommissionValue.HasValue
                    ? _property.ManagementCommissionValue
                        .Value.ToString("N2")
                    : string.Empty;


            txtCreatedDate.Text =
                _property.CreatedDate
                    .ToString("dd/MM/yyyy");


            txtCreatedByUser.Text =
                _property.CreatedByUserName
                ?? string.Empty;


            chkSubjectToVAT.Checked =
                _property.IsSubjectToVAT;


            txtAddress.Text =
                _property.Address
                ?? string.Empty;


            txtDescription.Text =
                _property.Description
                ?? string.Empty;


            _SetActiveStatus(
                _property.IsActive);
        }
        private void _SetActiveStatus(bool isActive)
        {
            if (isActive)
            {
                btnActive.BackColor =
                    Color.FromArgb(46, 169, 132);

                btnActive.ForeColor =
                    Color.White;


                btnInactive.BackColor =
                    Color.FromArgb(240, 240, 240);

                btnInactive.ForeColor =
                    Color.Gray;
            }
            else
            {
                btnInactive.BackColor =
                    Color.FromArgb(216, 77, 87);

                btnInactive.ForeColor =
                    Color.White;


                btnActive.BackColor =
                    Color.FromArgb(240, 240, 240);

                btnActive.ForeColor =
                    Color.Gray;
            }
        }

        private void lnkAddUnit_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            if (!HasProperty)
                return;


            _RaiseAddUnitRequested();
        }


        private void lnkShowUnits_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            if (!HasProperty)
                return;


            _RaiseShowUnitsRequested();
        }


        private void _RaiseAddUnitRequested()
        {
            AddUnitRequested?.Invoke(
                this,
                new PropertyActionEventArgs(
                    _propertyID,
                    _property.PropertyName));
        }
        private void _RaiseShowUnitsRequested()
        {
            ShowUnitsRequested?.Invoke(
                this,
                new PropertyActionEventArgs(
                    _propertyID,
                    _property.PropertyName));
        }
        private void _EnableUnitLinks(bool enabled)
        {
            lnkAddUnit.Enabled = enabled;
            lnkShowUnits.Enabled = enabled;
        }
        public void Clear()
        {
            _propertyID = -1;

            _property = null;


            txtPropertyID.Clear();
            txtPropertyCode.Clear();
            txtPropertyName.Clear();

            txtBuildingYear.Clear();

            txtCity.Clear();
            txtDistrict.Clear();

            txtArea.Clear();

            txtManagementCommissionType.Clear();
            txtManagementCommissionValue.Clear();

            txtCreatedDate.Clear();
            txtCreatedByUser.Clear();

            txtTaxType.Clear();

            txtAddress.Clear();
            txtDescription.Clear();


            chkSubjectToVAT.Checked = false;


            btnActive.BackColor =
                Color.FromArgb(240, 240, 240);

            btnActive.ForeColor =
                Color.Gray;


            btnInactive.BackColor =
                Color.FromArgb(240, 240, 240);

            btnInactive.ForeColor =
                Color.Gray;


            _EnableUnitLinks(false);
        }
    }
}

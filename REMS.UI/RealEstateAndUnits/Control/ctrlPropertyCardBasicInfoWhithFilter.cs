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

namespace REMS.UI.RealEstateAndUnits.Control
{
    public partial class ctrlPropertyCardBasicInfoWhithFilter : UserControl
    {

        // =========================================
        // Filter Enum
        // =========================================

        private enum enFilterBy
        {
            PropertyID = 1,
            PropertyName = 2
        }


        // =========================================
        // Fields
        // =========================================

        private IPropertyService _propertyService;


        // =========================================
        // Public Properties
        // =========================================

        public int PropertyID
        {
            get
            {
                return ctrlPropertyCardBasicInfo1.PropertyID;
            }
        }


        public PropertyBasicInfoDTO PropertyInfo
        {
            get
            {
                return ctrlPropertyCardBasicInfo1.PropertyInfo;
            }
        }


        public bool HasProperty
        {
            get
            {
                return ctrlPropertyCardBasicInfo1.HasProperty;
            }
        }


        public ctrlPropertyCardBasicInfoWhithFilter()
        {
            InitializeComponent();

            _InitializeControl();
        }


        // =========================================
        // Constructor With DI
        // =========================================

        public ctrlPropertyCardBasicInfoWhithFilter( 
            IPropertyService propertyService)
            : this()
        {
            SetPropertyService(propertyService);
        }

        // =========================================
        // Dependency Injection
        // =========================================

        public void SetPropertyService(
            IPropertyService propertyService)
            {
                _propertyService = propertyService;

                // نفس الـ Service نعطيها للـ Child Control
                ctrlPropertyCardBasicInfo1.SetPropertyService(
                    propertyService);
            }
        // =========================================
        // Initialization
        // =========================================

        private void _InitializeControl()
        {
            _InitializeFilterComboBox();

            _WireEvents();

            _ResetFilter();

            ctrlPropertyCardBasicInfo1.Clear();
        }


        // =========================================
        // Initialize Filter ComboBox
        // =========================================

        private void _InitializeFilterComboBox()
        {
            cbFilterBy.Items.Clear();

            cbFilterBy.Items.Add(
                new FilterItem(
                    enFilterBy.PropertyID,
                    "معرف العقار"));

            cbFilterBy.Items.Add(
                new FilterItem(
                    enFilterBy.PropertyName,
                    "اسم العقار"));

            cbFilterBy.DisplayMember = "Text";

            cbFilterBy.ValueMember = "Value";

            cbFilterBy.SelectedIndex = 0;
        }


        // =========================================
        // Wire Events
        // =========================================

        private void _WireEvents()
        {
            btnSearch.Click +=
                btnSearch_Click;

            cbFilterBy.SelectedIndexChanged +=
                cbFilterBy_SelectedIndexChanged;

            txtFilterValue.KeyDown +=
                txtFilterValue_KeyDown;
        }


        // =========================================
        // Reset Filter
        // =========================================

        private void _ResetFilter()
        {
            cbFilterBy.SelectedIndex = 0;

            txtFilterValue.Clear();

            txtFilterValue.Focus();
        }


        // =========================================
        // Search Button
        // =========================================

        private void btnSearch_Click(
            object sender,
            EventArgs e)
        {
            _Search();
        }


        // =========================================
        // Press Enter To Search
        // =========================================

        private void txtFilterValue_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;

            _Search();
        }


        // =========================================
        // Filter Changed
        // =========================================

        private void cbFilterBy_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            txtFilterValue.Clear();

            ctrlPropertyCardBasicInfo1.Clear();

            txtFilterValue.Focus();
        }


        // =========================================
        // Main Search Method
        // =========================================

        private void _Search()
        {
            if (_propertyService == null)
            {
                throw new InvalidOperationException(
                    "PropertyService has not been initialized.");
            }


            if (string.IsNullOrWhiteSpace(
                txtFilterValue.Text))
            {
                MessageBox.Show(
                    "يرجى إدخال قيمة للبحث.",
                    "بحث عن عقار",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFilterValue.Focus();

                return;
            }


            FilterItem selectedFilter =
                cbFilterBy.SelectedItem as FilterItem;


            if (selectedFilter == null)
                return;


            PropertyBasicInfoDTO property = null;


            switch (selectedFilter.Value)
            {
                case enFilterBy.PropertyID:

                    property =
                        _SearchByPropertyID();

                    break;


                case enFilterBy.PropertyName:

                    property =
                        _SearchByPropertyName();

                    break;
            }


            _HandleSearchResult(property);
        }


        // =========================================
        // Search By Property ID
        // =========================================

        private PropertyBasicInfoDTO
            _SearchByPropertyID()
        {
            int propertyID;


            if (!int.TryParse(
                txtFilterValue.Text.Trim(),
                out propertyID))
            {
                MessageBox.Show(
                    "معرف العقار يجب أن يكون رقمًا صحيحًا.",
                    "بحث عن عقار",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return null;
            }


            if (propertyID <= 0)
            {
                MessageBox.Show(
                    "معرف العقار غير صالح.",
                    "بحث عن عقار",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return null;
            }


            return
                _propertyService
                    .GetPropertyCardInfoByID(
                        propertyID);
        }


        // =========================================
        // Search By Property Name
        // =========================================

        private PropertyBasicInfoDTO
            _SearchByPropertyName()
        {
            string propertyName =
                txtFilterValue.Text.Trim();


            if (string.IsNullOrWhiteSpace(
                propertyName))
            {
                return null;
            }


            return null;
                //_propertyService
                //    .GetPropertyBasicInfoByName(
                //        propertyName);
        }


        // =========================================
        // Handle Search Result
        // =========================================

        private void _HandleSearchResult(
            PropertyBasicInfoDTO property)
        {
            if (property == null)
            {
                ctrlPropertyCardBasicInfo1.Clear();

                MessageBox.Show(
                    "لم يتم العثور على العقار.",
                    "نتيجة البحث",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }


            ctrlPropertyCardBasicInfo1.LoadProperty(
                property.PropertyID);
        }


        // =========================================
        // Clear
        // =========================================

        public void Clear()
        {
            txtFilterValue.Clear();

            ctrlPropertyCardBasicInfo1.Clear();

            cbFilterBy.SelectedIndex = 0;
        }


        // =========================================
        // Filter Item
        // =========================================

        private class FilterItem
        {
            public enFilterBy Value { get; }

            public string Text { get; }


            public FilterItem(
                enFilterBy value,
                string text)
            {
                Value = value;

                Text = text;
            }
        }
    }
}

using DataAccessLayer;
using Guna.UI2.WinForms;
using Interfaces;
using Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REMS.UI.Factories;
using REMS.UI.Form_Models;
using REMS.UI.Form_Models.Interfaces;
using REMS.UI.Form_Models.Services;
using REMS.UI.Person.Events;
using REMS.UI.Properties;
using REMS.UI.Validation;

namespace REMS.UI.Customer_Management
{
    public partial class frmAddPerson : Form
    {
        public event EventHandler<OnPersonSelectedEventArgs> OnPersonSelected;
        private enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        private enMode _Mode;

        private readonly IPersonService _PersonServices;
        private readonly ICountryService _CountryService;
        private readonly IPersonImageService _personImageService;
        private readonly IPersonFormMapper _personFormMapper;

        private Models.Person _Person;

        private Country _Country;
        public frmAddPerson(
            IPersonService personService,
            ICountryService countryService,
            IPersonImageService personImageService,
            IPersonFormMapper personFormMapper)
        {
            InitializeComponent();

            _PersonServices = personService;
            _CountryService = countryService;
            _personImageService = personImageService;
            _personFormMapper = personFormMapper;

            _Mode = enMode.AddNew;
        }

        private int _personId;
        public frmAddPerson( 
            int personId,
            IPersonService personService,
            ICountryService countryService,
            IPersonImageService personImageService,
            IPersonFormMapper personFormMapper)
        {
            InitializeComponent();

            _personId = personId;
            _PersonServices = personService;
            _CountryService = countryService;
            _personImageService = personImageService;
            _personFormMapper = personFormMapper;

            _Mode = enMode.Update;
            
            
        }
        private void Link_SetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PbClientImage.ImageLocation = openFileDialog1.FileName;
                LiRemoveImage.Visible = true;
            }
        }
        private void _FillCountryiesComboBox()
        {
            List<Country> countries = _CountryService.GetAll();

            cbCountries.DataSource = countries;
            cbCountries.DisplayMember = "CountryName";
            cbCountries.ValueMember = "Id";
        }
        private void _RestClientImage()
        {
            PbClientImage.Image = rbMale.Checked ? Resources.icons8_person_48__1_ : Resources.icons8_person_50;
        }
        private bool _ValidateForm()
        {
            bool isValid = true;

            if (!ValidationHelper.ValidateRequiredTextBox(txtFullName, errorProvider1, "الاسم الكامل مطلوب"))
                isValid = false;

            if (!ValidationHelper.ValidateRequiredTextBox(txtNationalID, errorProvider1, "الرقم الوطني مطلوب"))
                isValid = false;

            if (!ValidationHelper.ValidateRequiredTextBox(txtPhoneNumber1, errorProvider1, "رقم الهاتف مطلوب"))
                isValid = false;

            if (!ValidationHelper.ValidateRequiredComboBox(cbCountries, errorProvider1, "الرجاء اختيار البلد"))
                isValid = false;

            return isValid;
        }
        private void _RestDefaultData()
        {
            _FillCountryiesComboBox();

            if (this._Mode == enMode.AddNew)
            {
                this.Text = "إضافة عميل جديد";
                _Person = new Models.Person();
                _RestClientImage();
            }
            else
            {
                this.Text = "تحديث العميل";
                _Person = new Models.Person();

            }

        }
        private void _LoadPersonDataToForm()
        {
            txtPersonID.Text = _Person.PersonID.ToString();
            txtFullName.Text = _Person.FullName;
            txtNationalID.Text = _Person.NationalNo;
            txtPhoneNumber1.Text = _Person.PhoneNumber;
            txtPhone2.Text = _Person.AnotherPhone;
            txtTaxNumber.Text = _Person.TaxNumber;
            txtNameEnglish.Text = _Person.NameEnglish;
            txtEmail.Text = _Person.Email;
            dtpDate.Value = _Person.DateOfBirth;
            cbCountries.SelectedValue = _Person.NationalityCountryID;
            txtImageID.Text = _Person.IdPhotoPath;

            if (_Person.Gendor == (byte)enGendor.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            if (!string.IsNullOrWhiteSpace(_Person.ImagePath))
            {
                PbClientImage.ImageLocation = _Person.ImagePath;
                LiRemoveImage.Visible = true;
            }
            else
            {
                PbClientImage.ImageLocation = null;
                _RestClientImage();
                LiRemoveImage.Visible = false;
            }
        }
        private void _InitializeForAddMode()
        {
            _RestDefaultData();
        }
        private void _InitializeForUpdateMode()
        {
            _RestDefaultData();

            this._Person = _PersonServices.FindByID(this._personId);
            this._Person.Mode = Models.Person.enMode.Update;
            if (_Person == null)
            {
                MessageBox.Show("تعذر العثور على بيانات الشخص المطلوب.",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close();
                return;
            }

            _LoadPersonDataToForm();
        }
        private void frmAddClient_Load(object sender, EventArgs e)
        {
            if (this._Mode == enMode.AddNew)
            {
                _InitializeForAddMode();
            }
            else
            {
                _InitializeForUpdateMode();
            }
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (PbClientImage.ImageLocation == null)
                PbClientImage.Image = Resources.icons8_person_48__1_;
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (PbClientImage.ImageLocation == null)
                PbClientImage.Image = Resources.icons8_person_50;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private PersonFormData _GetFormData()
        {
            return new PersonFormData
            {
                FullName = txtFullName.Text.Trim(),
                NationalNo = txtNationalID.Text.Trim(),
                PhoneNumber = txtPhoneNumber1.Text.Trim(),
                AnotherPhone = txtPhone2.Text.Trim(),
                TaxNumber = txtTaxNumber.Text.Trim(),
                NameEnglish = txtNameEnglish.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                NationalityCountryID = Convert.ToInt32(cbCountries.SelectedValue),
                DateOfBirth = dtpDate.Value.Date,
                Gendor = rbMale.Checked ? (byte)enGendor.Male : (byte)enGendor.Female
            };
        }
        private bool _HandlePersonImage()
        {

            if (_personImageService.HandlePersonalImage(_Person, PbClientImage.ImageLocation))
                return true;

            else
            {
                MessageBox.Show("حدث خطأ أثناء نسخ الصورة.", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        private bool _HandlePersonImageID()
        {
            if (_personImageService.HandelIdImage(_Person, txtImageID.Text))
                return true;

            else
            {
                MessageBox.Show("حدث خطأ أثناء نسخ الصورة.", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void _SaveNewPerson()
        {
            PersonFormData formData = _GetFormData();
            this._Person = _personFormMapper.MapToPerson(formData, this._Person);

            if (!_HandlePersonImage())
            {
                MessageBox.Show("لا يمكن إتمام العملية.",
                "تنبيه",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                return;
            }

            if (!_HandlePersonImageID())
            {
                MessageBox.Show("لا يمكن إتمام العملية.",
                "تنبيه",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                return;
            }

            if (_PersonServices.Save(_Person))
            {
                MessageBox.Show("تم حفظ بيانات العميل بنجاح.",
                "تم الحفظ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                txtPersonID.Text = _Person.PersonID.ToString();

                _RaiseOnPersonSelected(this._Person);
            }
            else
                MessageBox.Show("تعذر إتمام عملية إضافة العميل. يرجى التحقق من البيانات والمحاولة مرة أخرى.",
                "خطأ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        private void _RaiseOnPersonSelected(OnPersonSelectedEventArgs e)
        {
            OnPersonSelected?.Invoke(this, e);
        }
        private void _RaiseOnPersonSelected(Models.Person Person)
        {
            _RaiseOnPersonSelected(new OnPersonSelectedEventArgs(Person));
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!_ValidateForm())
            {
                MessageBox.Show("لا يمكن إتمام العملية. يرجى التأكد من إدخال جميع البيانات المطلوبة.",
                "تنبيه",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning); ;

                return;
            }
                _SaveNewPerson();

            // Later Added Updating Mode.
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImageID.Text = openFileDialog1.FileName;
                txtImageID.IconRight = Resources.icons8_success_25;
            }
        }
    }
}

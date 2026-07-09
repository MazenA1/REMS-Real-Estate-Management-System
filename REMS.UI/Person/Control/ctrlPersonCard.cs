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
using REMS.UI.Customer_Management;
using REMS.UI.Factories;
using REMS.UI.Form_Models.Interfaces;
using REMS.UI.Form_Models.Services;
using REMS.UI.Person.Events;
using REMS.UI.Properties;

namespace REMS.UI.Person.Control
{
    public partial class ctrlPersonCard : UserControl
    {

        public event EventHandler<OnPersonSelectedEventArgs> EditLinkClicked;

        private readonly IPersonService _personService;
        private readonly ICountryService _countryService;

        private Models.Person _person;

        public ctrlPersonCard()
        {
            InitializeComponent();
            this._personService = ServiceFactory.CreatePersonService();
            this._countryService = ServiceFactory.CreateCountryService();
        }
        public ctrlPersonCard(IPersonService personService, ICountryService countryService)
        {
            InitializeComponent();

            _personService = personService;
            _countryService = countryService;
        }

        public Models.Person SelectedPerson
        {
            get { return _person; }
        }

        public bool LoadPersonByID(int personID)
        {
            if (personID <= 0)
            {
                _ResetPersonInfo();
                return false;
            }

            _person = _personService.FindByID(personID);

            if (_person == null)
            {
                _ResetPersonInfo();
                return false;
            }

            _FillPersonInfo();
            return true;
        }

        private void _RaiseEditLinkClicked(OnPersonSelectedEventArgs e)
        {
            EditLinkClicked?.Invoke(this, e);
        }
        private void _RaiseEditLinkClicked(Models.Person Person)
        {
            _RaiseEditLinkClicked(new OnPersonSelectedEventArgs(Person));
        }
        public bool LoadPersonByNationalNo(string nationalNo)
        {
            if (string.IsNullOrWhiteSpace(nationalNo))
            {
                _ResetPersonInfo();
                return false;
            }

            _person = _personService.FindByNationalNo(nationalNo.Trim());

            if (_person == null)
            {
                _ResetPersonInfo();
                return false;
            }

            _FillPersonInfo();
            return true;
        }

        private void _FillPersonInfo()
        {
            txtPersonID.Text = _person.PersonID.ToString();
            txtFullName.Text = _person.FullName;
            txtNationalID.Text = _person.NationalNo;
            txtPhoneNumber1.Text = _person.PhoneNumber;
            txtPhone2.Text = _person.AnotherPhone;
            txtTaxNumber.Text = _person.TaxNumber;
            txtNameEnglish.Text = _person.NameEnglish;
            txtEmail.Text = _person.Email;
            dtpDate.Value = _person.DateOfBirth;

            _LoadCountryName(_person.NationalityCountryID);
            _LoadGender();
            _LoadPersonImage();
        }

        private void _LoadCountryName(int countryID)
        {
            Country country = _countryService.GetByID(countryID);

            txtCountry.Text = country != null ? country.CountryName : "";
        }

        private void _LoadGender()
        {
            bool isMale = _person.Gendor == 0;

            rbMale.Checked = isMale;
            rbFemale.Checked = !isMale;
        }

        private void _LoadPersonImage()
        {
            if (!string.IsNullOrWhiteSpace(_person.ImagePath) && System.IO.File.Exists(_person.ImagePath))
            {
                PbClientImage.ImageLocation = _person.ImagePath;
            }
            else
            {
                PbClientImage.ImageLocation = null;
                PbClientImage.Image = _person.Gendor == 0
                    ? Resources.icons8_person_48__1_
                    : Resources.icons8_person_50;
            }
        }

        private void _ResetPersonInfo()
        {
            _person = null;

            txtPersonID.Text = "";
            txtFullName.Text = "";
            txtNationalID.Text = "";
            txtPhoneNumber1.Text = "";
            txtPhone2.Text = "";
            txtTaxNumber.Text = "";
            txtNameEnglish.Text = "";
            txtEmail.Text = "";
            txtCountry.Text = "";

            dtpDate.Value = DateTime.Now.Date;

            rbMale.Checked = false;
            rbFemale.Checked = false;

            PbClientImage.ImageLocation = null;
            PbClientImage.Image = Resources.icons8_person_48__1_;
        }
        private void _Frm_OnPersonSelected(object sender, OnPersonSelectedEventArgs e)
        {
            this._person = e.Person;
            LoadPersonByID(this._person.PersonID);
        }
        private void LiEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            IPersonService personService = ServiceFactory.CreatePersonService();
            ICountryService countryService = ServiceFactory.CreateCountryService();
            IPersonImageService personImageService = new PersonImageService();
            IPersonFormMapper personFormMapper = new PersonFormMapper();
            
            frmAddPerson frm = new frmAddPerson(
                _person.PersonID,
                personService,
                countryService,
                personImageService,
                personFormMapper);

            frm.OnPersonSelected += _Frm_OnPersonSelected;

            frm.ShowDialog();

            _RaiseEditLinkClicked(this._person);
        }
    }
}

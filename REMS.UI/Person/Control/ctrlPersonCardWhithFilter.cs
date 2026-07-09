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
using REMS.UI.Validation;

namespace REMS.UI.Person.Control
{
    public partial class ctrlPersonCardWhithFilter : UserControl
    {
        public Models.Person Person;
        public ctrlPersonCardWhithFilter()
        {
            InitializeComponent();
        }
        private void _OnPersonSelected(object sender, OnPersonSelectedEventArgs e)
        {
            this.Person = e.Person;
            ctrlPersonCard1.LoadPersonByID(this.Person.PersonID);
            txtFinde.Text = this.Person.PersonID.ToString();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            IPersonService personService = ServiceFactory.CreatePersonService();
            ICountryService countryService = ServiceFactory.CreateCountryService();
            IPersonImageService personImageService = new PersonImageService();
            IPersonFormMapper personFormMapper = new PersonFormMapper();

            frmAddPerson frm = new frmAddPerson(
                personService,
                countryService,
                personImageService,
                personFormMapper);
            frm.OnPersonSelected += _OnPersonSelected;

            frm.ShowDialog();
        }
        private bool _ControlValidater()
        {
            bool IsValid = false;

            if (!ValidationHelper.ValidateRequiredTextBox(txtFinde, errorProvider1, "الرجاء تعبئه الحقل المطلوب"))
                IsValid = false;

            if (!ValidationHelper.ValidateRequiredComboBox(CbType, errorProvider1, "الرجاء اختيار العمليه"))
                IsValid = false;

            return IsValid;
        }
        private void _FindNo()
        {

            switch (CbType.Text)
            {
                case "معرف الشخص":
                    ctrlPersonCard1.LoadPersonByID(int.Parse(txtFinde.Text.Trim()));
                    this.Person = ctrlPersonCard1.SelectedPerson;
                    break;

                case "الرقم الوطني":
                    ctrlPersonCard1.LoadPersonByNationalNo(txtFinde.Text.Trim());
                    this.Person = ctrlPersonCard1.SelectedPerson;
                    break;
            }

        }
        private void btnFindePerson_Click(object sender, EventArgs e)
        {
            if (!_ControlValidater())
            {
                txtFinde.Focus();
                _FindNo();
            }
        }
    }
}

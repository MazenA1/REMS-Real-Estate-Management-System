using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REMS.UI.Client_Roles.Owner.Control.Events;
using REMS.UI.Factories;
using REMS.UI.Person.Control;
using REMS.UI.Validation;

namespace REMS.UI.Client_Roles.Owner.Control
{
    public partial class ctrlFindOwnerWhithFilter : UserControl
    {
        public event EventHandler<OnOwnerSelectedEventArgs> OnOwnerSelected;  

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get 
            { 
                return this._FilterEnabled; 
            }

            set
            {
                if (this._FilterEnabled != value)
                {
                    this._FilterEnabled = value;
                    GBFilter.Enabled = this._FilterEnabled;
                }
            }
        }
        public ctrlFindOwnerWhithFilter()
        {
            InitializeComponent();
        }
        public void RaiseOnOwnerSelected(Models.DTOs.OwnerCardDTO OwnerDetails) 
        {
            RaiseOnOwnerSelected(new OnOwnerSelectedEventArgs(OwnerDetails)); 
        }

        protected virtual void RaiseOnOwnerSelected(OnOwnerSelectedEventArgs e)
        {
            OnOwnerSelected?.Invoke(this, e);
        }
        private bool _ControlValidater()
        {
            bool IsValid = true;

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
                    ctrlOwnerInfoCard1.SetServices(ServiceFactory.CreateOwnerService());
                    ctrlOwnerInfoCard1.LoadOwnerByOwnerID(int.Parse(txtFinde.Text.Trim()));
                    break;

                case "الرقم الوطني":
                    //ctrlPersonCard1.LoadPersonByNationalNo(txtFinde.Text.Trim());
                    //this.Person = ctrlPersonCard1.SelectedPerson;
                    break;
            }


            if (OnOwnerSelected != null)
                RaiseOnOwnerSelected(ctrlOwnerInfoCard1.SelectedOwnerCard);
            else
                MessageBox.Show("error", "error"); // Letar Handling.
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

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
using REMS.UI.Validation;

namespace REMS.UI.Client_Roles.Owner
{
    public partial class frmFindOwner : Form
    {
        public event EventHandler<OnOwnerSelectedEventArgs> OnOwnerSelected;
        public frmFindOwner()
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

        private void _OnOwnerSelected(object sender ,OnOwnerSelectedEventArgs e) 
        {
            RaiseOnOwnerSelected(e.OwnerCard);
        }
        private void frmFindOwner_Load(object sender, EventArgs e)
        {
            ctrlFindOwnerWhithFilter1.OnOwnerSelected += _OnOwnerSelected;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

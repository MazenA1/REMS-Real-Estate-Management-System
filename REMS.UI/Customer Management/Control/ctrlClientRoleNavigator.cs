using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS.UI.Customer_Management.Control
{
    public partial class ctrlClientRoleNavigator : UserControl
    {
        public enum enClientRole
        {
            Tenant,
            Owner,
            SubOwner,
            Investor,
            ServiceProvider,
            SingleOwner
        }

        public event Action<enClientRole> RoleSelected;

        public bool ShowTenant
        {
            get => btnTenant.Enabled;
            set => btnTenant.Enabled = value;
        }

        public bool ShowOwner
        {
            get => btnOwner.Enabled;
            set => btnOwner.Enabled = value;
        }

        public bool ShowSubOwner
        {
            get => btnSup_Owner.Enabled;
            set => btnSup_Owner.Enabled = value;
        }

        public bool ShowInvestor
        {
            get => btnInvestor.Enabled;
            set => btnInvestor.Enabled = value;
        }

        public bool ShowServiceProvider
        {
            get => btnServicesProvider.Enabled;
            set => btnServicesProvider.Enabled = value;
        }

        public bool ShowSingleOwner
        {
            get => btnOwner_alone.Enabled;
            set => btnOwner_alone.Enabled = value;
        }
        public bool ShowAllRoles
        {
            set
            {
                ShowTenant = value;
                ShowOwner = value;
                ShowSubOwner = value;
                ShowInvestor = value;
                ShowServiceProvider = value;
                ShowSingleOwner = value;
            }
        }
        public ctrlClientRoleNavigator()
        {
            InitializeComponent();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            RoleSelected?.Invoke(enClientRole.Tenant);
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            RoleSelected?.Invoke(enClientRole.Owner);
        }

        private void btnSup_Owner_Click(object sender, EventArgs e)
        {
            RoleSelected?.Invoke(enClientRole.SubOwner);
        }

        private void btnInvestor_Click(object sender, EventArgs e)
        {
            RoleSelected?.Invoke(enClientRole.Investor);
        }

        private void btnServicesProvider_Click(object sender, EventArgs e)
        {
            RoleSelected?.Invoke(enClientRole.ServiceProvider);
        }

        private void btnOwner_alone_Click(object sender, EventArgs e)
        {
            RoleSelected?.Invoke(enClientRole.SingleOwner);

        }

    }
}

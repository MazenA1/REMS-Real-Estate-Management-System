using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS.UI.Lease_Contracts
{
    public partial class frmLeaseContracts : Form
    {
        private Form _currentForm;
        public frmLeaseContracts()
        {
            InitializeComponent();
        }

        private void _OpenFormInPanel(Form childForm)
        {
            if (_currentForm != null)
                _currentForm.Close();

            _currentForm = childForm;

            PanelContainer.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(0, 0);
            childForm.Dock = DockStyle.Fill;
            childForm.Margin = Padding.Empty;

            PanelContainer.Padding = Padding.Empty;
            PanelContainer.AutoScroll = false;

            PanelContainer.Controls.Add(childForm);
            childForm.Show();
            childForm.BringToFront();
        }

        private void btnContractList_Click(object sender, EventArgs e)
        {
            frmTableContractsView frm = new frmTableContractsView();
            _OpenFormInPanel(frm); 
        }
    }
}

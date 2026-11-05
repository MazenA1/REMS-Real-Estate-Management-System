using REMS.UI.Composition;
using REMS.UI.Users_Management;
using System;
using System.Windows.Forms;

namespace REMS.UI
{
    public partial class frmMainService : Form
    {
        private readonly Form _loginForm;
        private readonly IFormFactory _formFactory;

        public frmMainService(Form loginForm, IFormFactory formFactory)
        {
            InitializeComponent();

            _loginForm = loginForm;
            _formFactory = formFactory;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            using (Form frm = _formFactory.CreateMain())
                frm.ShowDialog(this);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            _loginForm.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Form frmUsers = new frmUsersManagement();
            frmUsers.ShowDialog();
        }
    }
}
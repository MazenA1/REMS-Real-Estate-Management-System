using Interfaces;
using REMS.UI.Composition;
using REMS.UI.Global;
using Services;
using System;
using System.Windows.Forms;

namespace REMS.UI.Log_In
{
    public partial class frmLogin : Form
    {
        private readonly IUserService _userService;
        private readonly IFormFactory _formFactory;

        private User _user = null;

        public frmLogin(IUserService userService, IFormFactory formFactory)
        {
            InitializeComponent();

            _userService = userService;
            _formFactory = formFactory;
        }

        private bool _ValidatingUser()
        {
            _user = _userService.FindUserByUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (_user != null)
            {
                if (chRememberMe.Checked)
                    Global.Global.RememberUsernameAndPassword(_user.UserName.Trim(), _user.Password.Trim());
                else
                    Global.Global.RememberUsernameAndPassword("", "");

                if (!_user.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            else
                return false;
        }

        private void _InitializeCurrentUser()
        {
            Global.Global.CourentUser = _user;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (!_ValidatingUser())
                return;

            _InitializeCurrentUser();

            this.Hide();
            using (Form mainService = _formFactory.CreateMainService(this))
                mainService.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
            string UserName = "", Password = "";

            if (Global.Global.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chRememberMe.Checked = true;
            }
            else
                chRememberMe.Checked = false;
        }
    }
}
using Interfaces;
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
using REMS.UI.Factories;
using REMS.UI.Global;

namespace REMS.UI.Log_In
{
    public partial class frmLogin : Form
    {
        private User _user = null;
        private readonly IUserService _userService = ServiceFactory.CreateUserService();
        public frmLogin(IUserService userService)
        {
            InitializeComponent();
            this._userService = userService;
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
            Form frmMain = new frmMainService(this);
            frmMain.ShowDialog();
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

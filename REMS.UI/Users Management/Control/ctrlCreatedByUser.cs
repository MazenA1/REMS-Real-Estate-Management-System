using Interfaces;
using Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS.UI.Users_Management.Control
{
    public partial class ctrlCreatedByUser : UserControl
    {
        private IUserService _userService;

        private int _userID = -1;

        private CreatedByUserInfoDTO _userInfo;

        public int UserID
        {
            get { return _userID; }
        }

        public CreatedByUserInfoDTO UserInfo
        {
            get { return _userInfo; }
        }

        public bool HasUser
        {
            get
            {
                return _userInfo != null &&
                       _userID > 0;
            }
        }
        public ctrlCreatedByUser()
        {
            InitializeComponent();

            _InitializeControl();
        }

        public ctrlCreatedByUser(IUserService userService): this()
        {
            SetUserService(userService);
        }
        public void SetUserService(IUserService userService)
        {
            _userService = userService;
        }

        private void _InitializeControl()
        {
            Clear();
        }

        /// <summary>
        /// Loads and displays the user information for the specified user ID.
        /// </summary>
        /// <param name="userID">
        /// The ID of the user to load.
        /// </param>
        /// <returns>
        /// True if the user was found and loaded successfully;
        /// otherwise, false.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the user service has not been initialized.
        /// </exception>
        public bool LoadUser(int userID)
        {
            if (userID <= 0)
            {
                Clear();

                return false;
            }

            if (_userService == null)
            {
                throw new InvalidOperationException(
                    "UserService has not been initialized.");
            }

            CreatedByUserInfoDTO user =
                _userService
                    .GetCreatedByUserInfoByID(userID);

            if (user == null)
            {
                Clear();

                return false;
            }

            _userInfo = user;

            _userID = user.UserID;

            _FillUserData();

            return true;
        }

        private void _FillUserData()
        {
            txtUserID.Text =
                _userInfo.UserID.ToString();

            txtUserName.Text =
                _userInfo.UserName ?? string.Empty;

            tglIsActive.Checked =
                _userInfo.IsActive;
        }

        public void Clear()
        {
            _userID = -1;

            _userInfo = null;

            txtUserID.Clear();

            txtUserName.Clear();

            tglIsActive.Checked = false;
        }
    }
}

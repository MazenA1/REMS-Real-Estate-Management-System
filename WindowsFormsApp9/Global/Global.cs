using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS.UI.Global
{
    public static class Global 
    {
        public static User CourentUser;
        public static bool RememberUsernameAndPassword(string UserName, string Password)
        {
            try
            {

                string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\REMS";
                string ValueName1 = "UserName", ValueType = UserName, Valuename2 = "Password", ValueType2 = Password;

                Registry.SetValue(KeyPath, ValueName1, ValueType, RegistryValueKind.String);
                Registry.SetValue(KeyPath, Valuename2, ValueType2, RegistryValueKind.String);

                return true;

            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
        public static bool GetStoredCredential(ref string UserName, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
                string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\REMS";
                UserName = Registry.GetValue(KeyPath, "UserName", null) as string;
                Password = Registry.GetValue(KeyPath, "Password", null) as string;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }


    }
}

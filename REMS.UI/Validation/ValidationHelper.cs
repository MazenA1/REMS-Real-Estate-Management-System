using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS.UI.Validation
{
    public class ValidationHelper 
    {
        public static bool ValidateRequiredTextBox(Guna2TextBox textBox, ErrorProvider errorProvider, string message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, message);
                return false;
            }

            errorProvider.SetError(textBox, "");
            return true;
        }

        public static bool ValidateRequiredComboBox(ComboBox comboBox, ErrorProvider errorProvider, string message)
        {
            if (comboBox.SelectedIndex == -1 || comboBox.SelectedValue == null)
            {
                errorProvider.SetError(comboBox, message);
                return false;
            }

            errorProvider.SetError(comboBox, "");
            return true;
        }

        public static bool ValidateTextLength(Guna2TextBox textBox, ErrorProvider errorProvider, string message, int minLength)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text.Trim().Length < minLength)
            {
                errorProvider.SetError(textBox, message);
                return false;
            }

            errorProvider.SetError(textBox, "");
            return true;
        }

        public static bool ValidateRequiredCheckBox(CheckBox checkBox, ErrorProvider errorProvider, string message)
        {
            if (!checkBox.Checked)
            {
                errorProvider.SetError(checkBox, message);
                return false;
            }

            errorProvider.SetError(checkBox, "");
            return true;
        }
    }
}


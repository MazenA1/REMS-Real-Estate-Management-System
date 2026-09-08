using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS.UI.RealEstateAndUnits
{
    public partial class frmFindPropertyBasicInfo : Form
    {
        public frmFindPropertyBasicInfo()
        {
            InitializeComponent();
        }

        private void btnCompleated_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REMS.UI.Person.Events;

namespace REMS.UI.Person
{
    public partial class frmFindPerson : Form
    {
        public event EventHandler<OnPersonSelectedEventArgs> OnPersonSelected;
        private void _RaiseOnPersonSelected(OnPersonSelectedEventArgs e)
        {
            OnPersonSelected?.Invoke(this, e);
        }
        private void _RaiseOnPersonSelected(Models.Person Person)
        {
            _RaiseOnPersonSelected(new OnPersonSelectedEventArgs(Person));
        }
        public frmFindPerson()
        {
            InitializeComponent();
        }
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            _RaiseOnPersonSelected(ctrlPersonCardWhithFilter1.Person);
            this.Close();
        }
    }
}

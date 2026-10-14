using Models.DTOs;
using Models.Events;
using REMS.UI.Client_Roles.UnitOwner.Control;
using REMS.UI.Factories;
using REMS.UI.RealEstateAndUnits.Control;
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
        private int _PropertyID;

        public event EventHandler<PropertyAndUnitSelectedEventArgs> PropertyAndUnitSelected; 
        public frmFindPropertyBasicInfo()
        {
            InitializeComponent();

            _InitializeControls();

            _WireEvents();
        }
        private void _InitializeControls()
        {
            ctrlPropertyCardBasicInfoWhithFilter1.SetPropertyService(ServiceFactory.CreatePropertyService());

            ctrlUnitsListView1.SetUnitService(ServiceFactory.CreateUnitService());
        }
        private void btnCompleated_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _WireEvents()
        {
            ctrlPropertyCardBasicInfoWhithFilter1.ShowUnitsRequested
                += ctrlPropertyBasicInfoWithFilter1_ShowUnitsRequested;

            ctrlUnitsListView1.UnitSelected
                += ctrlUnitListView_AfterSelectUnit;
        }
        private void ctrlPropertyBasicInfoWithFilter1_ShowUnitsRequested(
        object sender,
        PropertyActionEventArgs e)
        {
            this._PropertyID = e.PropertyID;

        }
        private void ctrlUnitListView_AfterSelectUnit(object sender, UnitSelectedEventArgs e) 
        {
            this.Close();

            this.PropertyAndUnitSelected?.Invoke(this, new PropertyAndUnitSelectedEventArgs(ctrlPropertyCardBasicInfoWhithFilter1.PropertyInfo, e.Unit));
        }
        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2TabControl1.SelectedTab == tabUnits && ctrlPropertyCardBasicInfoWhithFilter1.HasProperty)
            {
                ctrlUnitsListView1.LoadUnitsByPropertyID(ctrlPropertyCardBasicInfoWhithFilter1.PropertyID);
            }
            else
            {
                DialogResult result = MessageBox.Show("يرجى اختيار العقار أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                    guna2TabControl1.SelectedTab = tabProperty;
            }
        }
    }
}

using REMS.UI.RealEstateAndUnits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS.UI.Client_Roles.UnitOwner
{
    public partial class frmRegistrationUnitOwner : Form
    {
        public frmRegistrationUnitOwner()
        {
            InitializeComponent();
        }

        private void _CreateColumns()
        {
            dgvUnitOwnerShip.Columns.Clear();

            dgvUnitOwnerShip.Columns.Add("FullName", "الاسم الكامل");
            dgvUnitOwnerShip.Columns.Add("NationalNo", "الرقم الوطني");
            dgvUnitOwnerShip.Columns.Add("PhoneNumber", "رقم الهاتف");
            dgvUnitOwnerShip.Columns.Add("DeedNumber", "رقم الصك");
            dgvUnitOwnerShip.Columns.Add("OwnershipPercentage", "نسبه الملكيه");

            // زر التعديل
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "Edit";
            btnEdit.HeaderText = "تعديل";
            btnEdit.Text = "تعديل";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.FlatStyle = FlatStyle.Standard;
            btnEdit.Width = 90;

            // زر الحذف
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Delete";
            btnDelete.HeaderText = "حذف";
            btnDelete.Text = "حذف";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.FlatStyle = FlatStyle.Standard;
            btnDelete.Width = 80;
            dgvUnitOwnerShip.Columns.Add(btnEdit);
            dgvUnitOwnerShip.Columns.Add(btnDelete);
        }
        private void _StyleContractsGrid()
        {
            dgvUnitOwnerShip.RightToLeft = RightToLeft.Yes;
            dgvUnitOwnerShip.EnableHeadersVisualStyles = false;

            // الشكل العام
            dgvUnitOwnerShip.BorderStyle = BorderStyle.None;
            dgvUnitOwnerShip.BackgroundColor = Color.White;
            dgvUnitOwnerShip.GridColor = Color.FromArgb(230, 230, 230);
            dgvUnitOwnerShip.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUnitOwnerShip.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvUnitOwnerShip.RowHeadersVisible = false;

            // الهيدر
            dgvUnitOwnerShip.ColumnHeadersHeight = 45;
            dgvUnitOwnerShip.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvUnitOwnerShip.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvUnitOwnerShip.ColumnHeadersDefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Bold);
            dgvUnitOwnerShip.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // الصفوف
            dgvUnitOwnerShip.RowTemplate.Height = 50;
            dgvUnitOwnerShip.DefaultCellStyle.BackColor = Color.White;
            dgvUnitOwnerShip.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvUnitOwnerShip.DefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Regular);
            dgvUnitOwnerShip.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // ========================
            // إعدادات زر التعديل
            // ========================
            dgvUnitOwnerShip.Columns["Edit"].DefaultCellStyle.Font =
                new Font("Cairo", 9, FontStyle.Bold);

            dgvUnitOwnerShip.Columns["Edit"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvUnitOwnerShip.Columns["Edit"].DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(225, 238, 252);

            dgvUnitOwnerShip.Columns["Edit"].DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(25, 90, 165);


            // ========================
            // إعدادات زر الحذف
            // ========================
            dgvUnitOwnerShip.Columns["Delete"].DefaultCellStyle.Font =
                new Font("Cairo", 9, FontStyle.Bold);

            dgvUnitOwnerShip.Columns["Delete"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvUnitOwnerShip.Columns["Delete"].DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(255, 232, 232);

            dgvUnitOwnerShip.Columns["Delete"].DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(170, 35, 35);

            // الصف المتناوب
            dgvUnitOwnerShip.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            // التحديد
            dgvUnitOwnerShip.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 245, 255);
            dgvUnitOwnerShip.DefaultCellStyle.SelectionForeColor = Color.Black;

            // الحجم
            dgvUnitOwnerShip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnitOwnerShip.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnitOwnerShip.MultiSelect = false;
            dgvUnitOwnerShip.AllowUserToAddRows = false;
            dgvUnitOwnerShip.AllowUserToResizeRows = false;

            dgvUnitOwnerShip.EnableHeadersVisualStyles = false;

            dgvUnitOwnerShip.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvUnitOwnerShip.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // هذا السطر هو المهم:
            dgvUnitOwnerShip.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvUnitOwnerShip.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void frmRegistrationUnitOwner_Load(object sender, EventArgs e)
        {
            _CreateColumns();
            _StyleContractsGrid();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmFindPropertyBasicInfo frm = new frmFindPropertyBasicInfo();
            frm.ShowDialog();
        }
    }
}

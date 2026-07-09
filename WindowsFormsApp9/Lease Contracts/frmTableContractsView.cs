using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS.UI.Lease_Contracts
{
    public partial class frmTableContractsView : Form
    {
        public frmTableContractsView()
        {
            InitializeComponent();
        }

        private void _CreateContractColumns()
        {
            dgvContracts.Columns.Clear();

            dgvContracts.Columns.Add("ContractID", "رقم العقد");
            dgvContracts.Columns.Add("Property", "العقار");
            dgvContracts.Columns.Add("UnitNo", "رقم الوحدة");
            dgvContracts.Columns.Add("Tenant", "المستأجر");
            dgvContracts.Columns.Add("StartDate", "تاريخ بداية الإيجار");
            dgvContracts.Columns.Add("Duration", "مدة العقد");
            dgvContracts.Columns.Add("Amount", "قيمة العقد");
            dgvContracts.Columns.Add("Status", "الحالة");
            dgvContracts.Columns.Add("PaymentStatus", "الحالة");
            dgvContracts.Columns.Add("Show", "عرض");

            dgvContracts.RightToLeft = RightToLeft.Yes;
        }

        private void _FillContractsData()
        {
            dgvContracts.Rows.Clear();

            dgvContracts.Rows.Add("8838852", "عمارة السعادة", "وحدة 6", "أحمد ر", "2021-08-15", "6.0 شهر", "6,000.00", "فعال", "غير مرحل", "عرض 👁");
            dgvContracts.Rows.Add("8838851", "تجارية 2", "وحدة 2", "أشرف تست", "2020-08-16", "24.0 شهر", "2,400.00", "فعال", "مرحل ✔", "عرض 👁");
            dgvContracts.Rows.Add("8838850", "فيلا", "وحدة 5", "توفيق تست", "2020-08-15", "12.0 شهر", "12,000.00", "فعال", "مرحل ✔", "عرض 👁");
            dgvContracts.Rows.Add("8838849", "تجارية 3", "وحدة 2", "قاسم", "2021-01-01", "12.0 شهر", "5,917.81", "مغلق", "مرحل ✔", "عرض 👁");
            dgvContracts.Rows.Add("8838848", "فيلا", "وحدة 4", "محمد تست", "2020-08-14", "24.0 شهر", "24,000.00", "فعال", "مرحل ✔", "عرض 👁");
            dgvContracts.Rows.Add("8838847", "تعدد مالك جديد", "وحدة 1", "قاسم", "2021-07-01", "6.0 شهر", "15,000.00", "مغلق", "مرحل ✔", "عرض 👁");
        }

        private void _StyleContractsGrid()
        {
            dgvContracts.EnableHeadersVisualStyles = false;
            dgvContracts.RightToLeft = RightToLeft.Yes;

            dgvContracts.BackgroundColor = Color.White;
            dgvContracts.BorderStyle = BorderStyle.None;
            dgvContracts.GridColor = Color.FromArgb(230, 230, 230);

            dgvContracts.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvContracts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgvContracts.ColumnHeadersHeight = 38;
            dgvContracts.RowTemplate.Height = 34;

            dgvContracts.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvContracts.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
            dgvContracts.ColumnHeadersDefaultCellStyle.Font =
                new Font("Cairo", 9, FontStyle.Bold);
            dgvContracts.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvContracts.DefaultCellStyle.BackColor = Color.White;
            dgvContracts.DefaultCellStyle.ForeColor = Color.FromArgb(65, 65, 65);
            dgvContracts.DefaultCellStyle.Font =
                new Font("Cairo", 9, FontStyle.Regular);
            dgvContracts.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvContracts.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(250, 250, 250);

            dgvContracts.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 240, 255);
            dgvContracts.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(40, 40, 40);

            dgvContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContracts.RowHeadersVisible = false;
            dgvContracts.MultiSelect = false;
            dgvContracts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContracts.AllowUserToAddRows = false;
            dgvContracts.AllowUserToResizeRows = false;
            dgvContracts.ReadOnly = true;
        }

        private void dgvContracts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columnName = dgvContracts.Columns[e.ColumnIndex].Name;
            string value = e.Value?.ToString();

            if (columnName == "Status")
            {
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (value == "فعال")
                    e.CellStyle.BackColor = Color.FromArgb(39, 174, 96);
                else if (value == "مغلق")
                    e.CellStyle.BackColor = Color.FromArgb(130, 130, 130);
            }

            if (columnName == "PaymentStatus")
            {
                if (value.Contains("غير"))
                    e.CellStyle.ForeColor = Color.FromArgb(192, 57, 43);
                else
                    e.CellStyle.ForeColor = Color.FromArgb(39, 174, 96);
            }

            if (columnName == "Show")
            {
                e.CellStyle.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }
        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmTableContractsView_Load(object sender, EventArgs e)
        {
            _CreateContractColumns();
            _StyleContractsGrid();
            _FillContractsData();

            dgvContracts.CellFormatting += dgvContracts_CellFormatting;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            frmAddNewLeaseAgreement frm = new frmAddNewLeaseAgreement();
            frm.ShowDialog();
        }
    }
}

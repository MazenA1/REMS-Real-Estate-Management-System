using Guna.UI2.WinForms;
using Interfaces;
using Microsoft.Web.WebView2.Core;
using Models;
using Models.DTOs;
using REMS.UI.Factories;
using REMS.UI.Form_Models.Interfaces;
using REMS.UI.Form_Models.Services;
using REMS.UI.FormDependencies;
using REMS.UI.Lease_Contracts;
using REMS.UI.RealEstateAndUnits;
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

namespace REMS.UI.Customer_Management
{
    public partial class frmMain : Form
    {

        private MainFormDependencies _deps;
        private AddEditClientFormDependencies _clientFormDeps;
        private BindingList<ClientListDTO> _clients = new BindingList<ClientListDTO>(); 
        public frmMain(MainFormDependencies deps)
        {
            InitializeComponent();
            this._deps = deps;
        }

        private void _PrepareDataGridView()
        {
            dgvAllClients.AutoGenerateColumns = false;

            dgvAllClients.Columns["colClientName"].DataPropertyName = "FullName";
            dgvAllClients.Columns["colClientType"].DataPropertyName = "ClientTypeName";
            dgvAllClients.Columns["colNationalNo"].DataPropertyName = "NationalNo";
            dgvAllClients.Columns["colPhoneNumber"].DataPropertyName = "PhoneNumber";

            if (!dgvAllClients.Columns.Contains("colEdit"))
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
                editColumn.Name = "colEdit";
                editColumn.HeaderText = "تعديل";
                editColumn.Text = "تعديل";
                editColumn.UseColumnTextForButtonValue = true;
                editColumn.Width = 90;
                dgvAllClients.Columns.Add(editColumn);
            }

            if (!dgvAllClients.Columns.Contains("colDelete"))
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "colDelete";
                deleteColumn.HeaderText = "حذف";
                deleteColumn.Text = "حذف";
                deleteColumn.UseColumnTextForButtonValue = true;
                deleteColumn.Width = 90;
                dgvAllClients.Columns.Add(deleteColumn);
            }

            dgvAllClients.Columns["colClientName"].DisplayIndex = 0;
            dgvAllClients.Columns["colPhoneNumber"].DisplayIndex = 1;
            dgvAllClients.Columns["colClientType"].DisplayIndex = 2;
            dgvAllClients.Columns["colNationalNo"].DisplayIndex = 3;
            dgvAllClients.Columns["colEdit"].DisplayIndex = 4;
            dgvAllClients.Columns["colDelete"].DisplayIndex = 5;

            dgvAllClients.Columns["colDelete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAllClients.Columns["colEdit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAllClients.Columns["colEdit"].Width = 70;
            dgvAllClients.Columns["colDelete"].Width = 70;
        }
        private async Task _LoadAllClientsAsync()
        {
            _clients = await Task.Run(() =>
                _deps.RoleService.GetAllClientsList());

            dgvAllClients.DataSource = _clients;
        }

        private void _StyleDataGridView()
        {
            // الشكل العام
            dgvAllClients.BorderStyle = BorderStyle.None;
       
            dgvAllClients.BackgroundColor = Color.White;
            dgvAllClients.GridColor = Color.FromArgb(235, 235, 235);

            dgvAllClients.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvAllClients.EnableHeadersVisualStyles = false;

            // الهيدر
            dgvAllClients.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;

            dgvAllClients.ThemeStyle.HeaderStyle.Height = 45;
            dgvAllClients.ColumnHeadersHeight = 45;

            dgvAllClients.ThemeStyle.HeaderStyle.BackColor = Color.White;
            dgvAllClients.ThemeStyle.HeaderStyle.ForeColor = Color.Black;

            dgvAllClients.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvAllClients.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvAllClients.ColumnHeadersDefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Bold);

            dgvAllClients.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // الصفوف
            dgvAllClients.ThemeStyle.RowsStyle.Height = 45;
            dgvAllClients.RowTemplate.Height = 45;

            dgvAllClients.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvAllClients.DefaultCellStyle.BackColor = Color.White;

            dgvAllClients.ThemeStyle.RowsStyle.ForeColor =
                Color.FromArgb(35, 35, 35);

            dgvAllClients.DefaultCellStyle.ForeColor =
                Color.FromArgb(35, 35, 35);

            dgvAllClients.DefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Regular);

            dgvAllClients.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // alternating rows
            dgvAllClients.ThemeStyle.AlternatingRowsStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            dgvAllClients.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            // التحديد
            dgvAllClients.ThemeStyle.RowsStyle.SelectionBackColor =
                Color.FromArgb(230, 226, 255);

            dgvAllClients.ThemeStyle.RowsStyle.SelectionForeColor =
                Color.FromArgb(35, 35, 35);

            dgvAllClients.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 226, 255);

            dgvAllClients.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(35, 35, 35);

            // إعدادات إضافية
            dgvAllClients.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvAllClients.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAllClients.RowHeadersVisible = false;

            dgvAllClients.MultiSelect = false;

            dgvAllClients.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAllClients.AllowUserToAddRows = false;
            dgvAllClients.AllowUserToResizeRows = false;
            dgvAllClients.AllowUserToResizeColumns = false;

            dgvAllClients.ReadOnly = true;

            dgvAllClients.RightToLeft = RightToLeft.Yes;
        }

        private void _StyleContractsGrid() 
        {
            dgvContracts.RightToLeft = RightToLeft.Yes;
            dgvContracts.EnableHeadersVisualStyles = false;

            // الشكل العام
            dgvContracts.BorderStyle = BorderStyle.None;
            dgvContracts.BackgroundColor = Color.White;
            dgvContracts.GridColor = Color.FromArgb(230, 230, 230);
            dgvContracts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvContracts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvContracts.RowHeadersVisible = false;

            // الهيدر
            dgvContracts.ColumnHeadersHeight = 45;
            dgvContracts.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvContracts.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvContracts.ColumnHeadersDefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Bold);
            dgvContracts.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // الصفوف
            dgvContracts.RowTemplate.Height = 50;
            dgvContracts.DefaultCellStyle.BackColor = Color.White;
            dgvContracts.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvContracts.DefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Regular);
            dgvContracts.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // الصف المتناوب
            dgvContracts.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            // التحديد
            dgvContracts.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 245, 255);
            dgvContracts.DefaultCellStyle.SelectionForeColor = Color.Black;

            // الحجم
            dgvContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContracts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContracts.MultiSelect = false;
            dgvContracts.AllowUserToAddRows = false;
            dgvContracts.AllowUserToResizeRows = false;
        }
        private void _CreateColumns()
        {
            dgvContracts.Columns.Clear();

            dgvContracts.Columns.Add("ContractID", "رقم العقد");
            dgvContracts.Columns.Add("TenantName", "المستأجر");
            dgvContracts.Columns.Add("ContractDuration", "مدة العقد");
            dgvContracts.Columns.Add("Amount", "المبلغ المستحق");
            dgvContracts.Columns.Add("PaymentStatus", "حالة التسديد");
        }
        private void _FillContractsGrid()
        {
            dgvContracts.Rows.Clear();

            dgvContracts.Rows.Add(
                333453,
                "محمد 2",
                "12.0 شهر",
                "7,500",
                "مدفوع"
            );

            dgvContracts.Rows.Add(
                1186,
                "سامر ل",
                "12.0 شهر",
                "10,000",
                "مدفوع"
            );

            dgvContracts.Rows.Add(
                333577,
                "امل",
                "2.0 شهر",
                "2,000",
                "غير مدفوع"
            );

            dgvContracts.Rows.Add(
                1140,
                "إيهاب د",
                "3.0 شهر",
                "2,000",
                "مدفوع"
            );


            dgvContracts.Rows.Add(
                333453,
                "محمد 2",
                "12.0 شهر",
                "7,500",
                "مدفوع"
            );

            dgvContracts.Rows.Add(
                333453,
                "محمد 2",
                "12.0 شهر",
                "7,500",
                "مدفوع"
            );

            dgvContracts.Rows.Add(
                333453,
                "محمد 2",
                "12.0 شهر",
                "7,500",
                "مدفوع"
            );
        }
        private void _SetColumnsSize()
        {
            dgvAllClients.Columns["colClientName"].Width = 190;
            dgvAllClients.Columns["colPhoneNumber"].Width = 130;
            dgvAllClients.Columns["colClientType"].Width = 110;
            dgvAllClients.Columns["colNationalNo"].Width = 130;

            dgvAllClients.Columns["colEdit"].Width = 55;
            dgvAllClients.Columns["colDelete"].Width = 55;

            dgvAllClients.Columns["colClientName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private frmAddEditClient _CreateAddClientForm()
        {
            return new frmAddEditClient(this._deps.AddEditClientDeps);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {

            frmAddEditClient frm = _CreateAddClientForm();
            frm.ShowDialog();

        }
        private void _RefreshDashboardCounts()
        {
            lblClientsCount.Text = _deps.DashboardStatisticsService.GetClientsCount().ToString();
            lblTenantsCount.Text = _deps.DashboardStatisticsService.GetTenantsCount().ToString();
            lblOwnersCounts.Text = _deps.DashboardStatisticsService.GetOwnersCount().ToString();
        }
        private void _SubscribeToEvents()
        {
            _deps.ClientService.ClientAdded += _RefreshDashboardCounts;
            _deps.TenantService.TenantAdded += _RefreshDashboardCounts;
            _deps.OwnerService.OwnerAdded += _RefreshDashboardCounts;
        }
        private void WebView21_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            guna2WinProgressIndicator1.Visible = false;
        }
        private async void frmMain_Load(object sender, EventArgs e)
        {
            _SubscribeToEvents();
            _RefreshDashboardCounts();

            _PrepareDataGridView();
            _StyleDataGridView();
            _SetColumnsSize();

            // Bage 2
            _CreateColumns();
            _StyleContractsGrid();
            _FillContractsGrid();
            await _LoadAllClientsAsync();

            // Load Map
            guna2WinProgressIndicator1.Visible = true;

            await webView21.EnsureCoreWebView2Async();

            webView21.Source =
                new Uri("https://www.google.com/maps/place/Turkey");

            webView21.NavigationCompleted += WebView21_NavigationCompleted;
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            frmLeaseContracts frm = new frmLeaseContracts();
            frm.ShowDialog();

        }

        private void btnAddNewProperty_Click(object sender, EventArgs e)
        {
            frmAddNewProperty frm = new frmAddNewProperty(_deps.AddNewPropertyDeps);
            frm.ShowDialog();
        }
    }
} 

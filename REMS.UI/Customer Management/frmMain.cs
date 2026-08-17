using Guna.UI2.WinForms;
using Interfaces;
using Microsoft.Web.WebView2.Core;
using Models;
using Models.DTOs;
using Models.Events;
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
        private BindingList<TenantListDTO> _Tenants = new BindingList<TenantListDTO>();  
        private BindingList<OwnersListDTO> _Owners = new BindingList<OwnersListDTO>(); 
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
        private void _TenantsDataGridView() 
        {
            dgvAllTenants.AutoGenerateColumns = false;

            dgvAllTenants.Columns["colTenantName"].DataPropertyName = "TenantFullName";
            dgvAllTenants.Columns["colTenantNationalNo"].DataPropertyName = "TenantNationalNo";
            dgvAllTenants.Columns["colTenantPhoneNumber"].DataPropertyName = "TenantPhoneNumber"; 
            dgvAllTenants.Columns["colTenantOpeningBalance"].DataPropertyName = "TenantOpeningBalance";


            if (!dgvAllTenants.Columns.Contains("colEdit"))
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
                editColumn.Name = "colEdit";
                editColumn.HeaderText = "تعديل";
                editColumn.Text = "تعديل";
                editColumn.UseColumnTextForButtonValue = true;
                editColumn.Width = 90;
                dgvAllTenants.Columns.Add(editColumn);
            }

            if (!dgvAllTenants.Columns.Contains("colDelete"))
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "colDelete";
                deleteColumn.HeaderText = "حذف";
                deleteColumn.Text = "حذف";
                deleteColumn.UseColumnTextForButtonValue = true;
                deleteColumn.Width = 90;
                dgvAllTenants.Columns.Add(deleteColumn); 
            }

            dgvAllTenants.Columns["colTenantName"].DisplayIndex = 0;
            dgvAllTenants.Columns["colTenantPhoneNumber"].DisplayIndex = 1;
            dgvAllTenants.Columns["colTenantNationalNo"].DisplayIndex = 2;
            dgvAllTenants.Columns["colTenantOpeningBalance"].DisplayIndex = 3; 
            dgvAllTenants.Columns["colEdit"].DisplayIndex = 4;
            dgvAllTenants.Columns["colDelete"].DisplayIndex = 5;

            dgvAllTenants.Columns["colDelete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAllTenants.Columns["colEdit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAllTenants.Columns["colEdit"].Width = 70;
            dgvAllTenants.Columns["colDelete"].Width = 70;
        }
        private void _OwnersDataGridView()
        {
            dgvAllOwners.AutoGenerateColumns = false;

            dgvAllOwners.Columns["colOwnerName"].DataPropertyName = "OwnerFullName";
            dgvAllOwners.Columns["colOwnerNationalNo"].DataPropertyName = "OwnerNationalNo";
            dgvAllOwners.Columns["colOwnerPhoneNumber"].DataPropertyName = "OwnerPhoneNumber";
            dgvAllOwners.Columns["colOwnerOpeningBalance"].DataPropertyName = "OwnerOpeningBalance"; 


            if (!dgvAllOwners.Columns.Contains("colEdit"))
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
                editColumn.Name = "colEdit";
                editColumn.HeaderText = "تعديل";
                editColumn.Text = "تعديل";
                editColumn.UseColumnTextForButtonValue = true;
                editColumn.Width = 90;
                dgvAllOwners.Columns.Add(editColumn);
            }

            if (!dgvAllOwners.Columns.Contains("colDelete"))
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "colDelete";
                deleteColumn.HeaderText = "حذف";
                deleteColumn.Text = "حذف";
                deleteColumn.UseColumnTextForButtonValue = true;
                deleteColumn.Width = 90;
                dgvAllOwners.Columns.Add(deleteColumn);
            }

            dgvAllOwners.Columns["colOwnerName"].DisplayIndex = 0;
            dgvAllOwners.Columns["colOwnerPhoneNumber"].DisplayIndex = 1;
            dgvAllOwners.Columns["colOwnerNationalNo"].DisplayIndex = 2;
            dgvAllOwners.Columns["colOwnerOpeningBalance"].DisplayIndex = 3;
            dgvAllOwners.Columns["colEdit"].DisplayIndex = 4;
            dgvAllOwners.Columns["colDelete"].DisplayIndex = 5;

            dgvAllOwners.Columns["colDelete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAllOwners.Columns["colEdit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAllOwners.Columns["colEdit"].Width = 70;
            dgvAllOwners.Columns["colDelete"].Width = 70;
        } 

        private async Task _LoadAllClientsAsync()
        {
            _clients = await Task.Run(() =>
                _deps.RoleService.GetAllClientsList());

            dgvAllClients.DataSource = _clients;
        }
        private async Task _LoadAllTenantsAsync()
        {
            this._Tenants = await Task.Run(() =>
                _deps.TenantService.GetTenantList());

            dgvAllTenants.DataSource = this._Tenants;
        }
        private async Task _LoadAllOwnersAsync() 
        {
            this._Owners = await Task.Run(() =>
                _deps.OwnerService.GetAllOwnersList());

            dgvAllOwners.DataSource = this._Owners; 
        }
        private void _UpdatedgvAllClients(string NationalNo)
        {
            ClientListDTO clientListDTO = this._deps.AddEditClientDeps.ClientRoleService.GetClientItemInfoByNationalNo(NationalNo);

            this._clients.Add(clientListDTO);
        }
        private void _StyleDataGridViewTenants() 
        {
            // الشكل العام
            dgvAllTenants.BorderStyle = BorderStyle.None;

            dgvAllTenants.BackgroundColor = Color.White;
            dgvAllTenants.GridColor = Color.FromArgb(235, 235, 235);

            dgvAllTenants.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvAllTenants.EnableHeadersVisualStyles = false;

            // الهيدر
            dgvAllTenants.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;

            dgvAllTenants.ThemeStyle.HeaderStyle.Height = 45;
            dgvAllTenants.ColumnHeadersHeight = 45;

            dgvAllTenants.ThemeStyle.HeaderStyle.BackColor = Color.White;
            dgvAllTenants.ThemeStyle.HeaderStyle.ForeColor = Color.Black;

            dgvAllTenants.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvAllTenants.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvAllTenants.ColumnHeadersDefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Bold);

            dgvAllTenants.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // الصفوف
            dgvAllTenants.ThemeStyle.RowsStyle.Height = 45;
            dgvAllTenants.RowTemplate.Height = 45;

            dgvAllTenants.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvAllTenants.DefaultCellStyle.BackColor = Color.White;

            dgvAllTenants.ThemeStyle.RowsStyle.ForeColor =
                Color.FromArgb(35, 35, 35);

            dgvAllTenants.DefaultCellStyle.ForeColor =
                Color.FromArgb(35, 35, 35);

            dgvAllTenants.DefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Regular);

            dgvAllTenants.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // alternating rows
            dgvAllTenants.ThemeStyle.AlternatingRowsStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            dgvAllTenants.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            // التحديد
            dgvAllTenants.ThemeStyle.RowsStyle.SelectionBackColor =
                Color.FromArgb(230, 226, 255);

            dgvAllTenants.ThemeStyle.RowsStyle.SelectionForeColor =
                Color.FromArgb(35, 35, 35);

            dgvAllTenants.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 226, 255);

            dgvAllTenants.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(35, 35, 35);

            // إعدادات إضافية
            dgvAllTenants.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvAllTenants.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAllTenants.RowHeadersVisible = false;

            dgvAllTenants.MultiSelect = false;

            dgvAllTenants.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAllTenants.AllowUserToAddRows = false;
            dgvAllTenants.AllowUserToResizeRows = false;
            dgvAllTenants.AllowUserToResizeColumns = false;

            dgvAllTenants.ReadOnly = true;

            dgvAllTenants.RightToLeft = RightToLeft.Yes;
        }

        private void _StyleDataGridViewOwners()
        {
            // الشكل العام
            dgvAllOwners.BorderStyle = BorderStyle.None;

            dgvAllOwners.BackgroundColor = Color.White;
            dgvAllOwners.GridColor = Color.FromArgb(235, 235, 235);

            dgvAllOwners.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvAllOwners.EnableHeadersVisualStyles = false;

            // الهيدر
            dgvAllOwners.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;

            dgvAllOwners.ThemeStyle.HeaderStyle.Height = 45;
            dgvAllOwners.ColumnHeadersHeight = 45;

            dgvAllOwners.ThemeStyle.HeaderStyle.BackColor = Color.White;
            dgvAllOwners.ThemeStyle.HeaderStyle.ForeColor = Color.Black;

            dgvAllOwners.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvAllOwners.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvAllOwners.ColumnHeadersDefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Bold);

            dgvAllOwners.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // الصفوف
            dgvAllOwners.ThemeStyle.RowsStyle.Height = 45;
            dgvAllOwners.RowTemplate.Height = 45;

            dgvAllOwners.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvAllOwners.DefaultCellStyle.BackColor = Color.White;

            dgvAllOwners.ThemeStyle.RowsStyle.ForeColor =
                Color.FromArgb(35, 35, 35);

            dgvAllOwners.DefaultCellStyle.ForeColor =
                Color.FromArgb(35, 35, 35);

            dgvAllOwners.DefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Regular);

            dgvAllOwners.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // alternating rows
            dgvAllOwners.ThemeStyle.AlternatingRowsStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            dgvAllOwners.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            // التحديد
            dgvAllOwners.ThemeStyle.RowsStyle.SelectionBackColor =
                Color.FromArgb(230, 226, 255);

            dgvAllOwners.ThemeStyle.RowsStyle.SelectionForeColor =
                Color.FromArgb(35, 35, 35);

            dgvAllOwners.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(230, 226, 255);

            dgvAllOwners.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(35, 35, 35);

            // إعدادات إضافية
            dgvAllOwners.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvAllOwners.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAllOwners.RowHeadersVisible = false;

            dgvAllOwners.MultiSelect = false;

            dgvAllOwners.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAllOwners.AllowUserToAddRows = false;
            dgvAllOwners.AllowUserToResizeRows = false;
            dgvAllOwners.AllowUserToResizeColumns = false;

            dgvAllOwners.ReadOnly = true;

            dgvAllOwners.RightToLeft = RightToLeft.Yes;
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

        private void _SetColumnsSizedgvTenants() 
        {
            dgvAllTenants.Columns["colTenantName"].Width = 190;
            dgvAllTenants.Columns["colTenantPhoneNumber"].Width = 130;
            dgvAllTenants.Columns["colTenantOpeningBalance"].Width = 110;
            dgvAllTenants.Columns["colTenantNationalNo"].Width = 130;

            dgvAllTenants.Columns["colEdit"].Width = 55;
            dgvAllTenants.Columns["colDelete"].Width = 55;

            dgvAllTenants.Columns["colTenantName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
        }
        private void _SetColumnsSizedgvOwners()
        {
            dgvAllOwners.Columns["colOwnerName"].Width = 190;
            dgvAllOwners.Columns["colOwnerPhoneNumber"].Width = 130;
            dgvAllOwners.Columns["colOwnerOpeningBalance"].Width = 110;
            dgvAllOwners.Columns["colOwnerNationalNo"].Width = 130;

            dgvAllOwners.Columns["colEdit"].Width = 55;
            dgvAllOwners.Columns["colDelete"].Width = 55; 

            dgvAllOwners.Columns["colOwnerName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
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
        } // Letar Handling 
        private void OnTenantRegistered(object sender, TenantRegisteredEventArgs e)
        {
            this._Tenants.Add(e.Tenant);

            _UpdatedgvAllClients(e.Tenant.TenantNationalNo);

            lblTenantsCount.Text = _deps.DashboardStatisticsService.GetTenantsCount().ToString();
        }

        private void OnOwnerRegistered(object sender, OwnerRegisteredEventArgs e)
        {
            this._Owners.Add(e.ownersListDTO);

            _UpdatedgvAllClients(e.ownersListDTO.OwnerNationalNo);

            lblOwnersCounts.Text = _deps.DashboardStatisticsService.GetOwnersCount().ToString(); 
        }
        private void _SubscribeToEvents()
        {
            _deps.ClientService.ClientAdded += _RefreshDashboardCounts;
            _deps.AddEditClientDeps.TenantApplicationService.TenantRegistered += OnTenantRegistered;
            _deps.AddEditClientDeps.OwnerApplicationService.OwnerRegistered += OnOwnerRegistered; 

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

            // dgvAllClients.
            _PrepareDataGridView();
            _StyleDataGridView();
            _SetColumnsSize();

            // dgvAllTenants.
            _TenantsDataGridView();
            _StyleDataGridViewTenants();
            _SetColumnsSizedgvTenants();
            await _LoadAllTenantsAsync();

            // dgvAllOwners.

            _OwnersDataGridView();
            _StyleDataGridViewOwners();
            _SetColumnsSizedgvOwners();
            await _LoadAllOwnersAsync();

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

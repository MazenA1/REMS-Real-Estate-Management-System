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
using System.Windows.Forms.Design;
using Interfaces;
using Interfaces.Services;

namespace REMS.UI.Client_Roles.UnitOwner.Control
{
    public partial class ctrlPropertyUnitsSelector : UserControl
    {

        private IUnitService _unitService;
    
        private int _propertyID = -1;

        private List<UnitSelectionDTO> _allUnits =
            new List<UnitSelectionDTO>();


        // ========================================
        // Selected Unit
        // ========================================

        public UnitSelectionDTO SelectedUnit { get; private set; }

        public int SelectedUnitID
        {
            get
            {
                return this.SelectedUnit?.UnitID ?? -1;
            }
        }

        // ========================================
        // Event
        // ========================================

        public event EventHandler<UnitSelectedEventArgs> UnitSelected;


        public ctrlPropertyUnitsSelector()
        {
            InitializeComponent();

            _InitializeControl();
        }

        public ctrlPropertyUnitsSelector(IUnitService unitService) : this()
        {
            _unitService = unitService;
        }

        // ========================================
        // Dependency Injection
        // ========================================

        public void SetUnitService(IUnitService unitService)
        {
            _unitService = unitService;
        }


        // ========================================
        // Initialization
        // ========================================

        private void _InitializeControl()
        {
            _CreateColumns();

            _StyleUnitsGrid();

            _WireEvents();

            dgvUnits.ClearSelection();
        }


        // ========================================
        // Events Wiring
        // ========================================

        private void _WireEvents()
        {
            dgvUnits.CellContentClick += dgvUnits_CellContentClick;

            dgvUnits.CellDoubleClick += dgvUnits_CellDoubleClick;

            dgvUnits.CellFormatting += dgvUnits_CellFormatting;
        }


        // ========================================
        // Create Columns
        // ========================================

        private void _CreateColumns()
        {
            dgvUnits.Columns.Clear();

            dgvUnits.AutoGenerateColumns = false;


            // UnitID
            DataGridViewTextBoxColumn colUnitID =
                new DataGridViewTextBoxColumn();

            colUnitID.Name = "colUnitID";
            colUnitID.HeaderText = "معرّف الوحدة";
            colUnitID.DataPropertyName = "UnitID";
            colUnitID.Visible = false;

            dgvUnits.Columns.Add(colUnitID);


            // Unit Number
            DataGridViewTextBoxColumn colUnitNumber =
                new DataGridViewTextBoxColumn();

            colUnitNumber.Name = "colUnitNumber";
            colUnitNumber.HeaderText = "رقم الوحدة";
            colUnitNumber.DataPropertyName = "UnitNumber";

            dgvUnits.Columns.Add(colUnitNumber);


            // Unit Type
            DataGridViewTextBoxColumn colUnitType =
                new DataGridViewTextBoxColumn();

            colUnitType.Name = "colUnitType";
            colUnitType.HeaderText = "نوع الوحدة";
            colUnitType.DataPropertyName = "UnitTypeName";

            dgvUnits.Columns.Add(colUnitType);


            // Building Number
            DataGridViewTextBoxColumn colBuildingNumber =
                new DataGridViewTextBoxColumn();

            colBuildingNumber.Name = "colBuildingNumber";
            colBuildingNumber.HeaderText = "رقم المبنى";
            colBuildingNumber.DataPropertyName = "BuildingNumber";

            dgvUnits.Columns.Add(colBuildingNumber);


            // Building Name
            DataGridViewTextBoxColumn colBuildingName =
                new DataGridViewTextBoxColumn();

            colBuildingName.Name = "colBuildingName";
            colBuildingName.HeaderText = "اسم المبنى";
            colBuildingName.DataPropertyName = "BuildingName";

            dgvUnits.Columns.Add(colBuildingName);


            // Floor
            DataGridViewTextBoxColumn colFloor =
                new DataGridViewTextBoxColumn();

            colFloor.Name = "colFloor";
            colFloor.HeaderText = "الطابق";
            colFloor.DataPropertyName = "FloorNumber";

            dgvUnits.Columns.Add(colFloor);


            // Area
            DataGridViewTextBoxColumn colArea =
                new DataGridViewTextBoxColumn();

            colArea.Name = "colArea";
            colArea.HeaderText = "المساحة";
            colArea.DataPropertyName = "Area";

            dgvUnits.Columns.Add(colArea);


            // ========================================
            // Select Button
            // ========================================

            DataGridViewButtonColumn colSelect =
                new DataGridViewButtonColumn();

            colSelect.Name = "colSelectUnit";
            colSelect.HeaderText = "اختيار";

            colSelect.Text = "اختيار";

            colSelect.UseColumnTextForButtonValue = true;

            colSelect.FlatStyle = FlatStyle.Flat;

            colSelect.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            colSelect.DefaultCellStyle.Padding =
                new Padding(8, 7, 8, 7);

            colSelect.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.None;

            colSelect.Width = 100;

            colSelect.MinimumWidth = 95;

            colSelect.SortMode =
                DataGridViewColumnSortMode.NotSortable;

            dgvUnits.Columns.Add(colSelect);
        }


        // ========================================
        // Grid Style
        // ========================================

        private void _StyleUnitsGrid()
        {
            dgvUnits.RightToLeft = RightToLeft.Yes;

            dgvUnits.EnableHeadersVisualStyles = false;

            dgvUnits.BorderStyle = BorderStyle.None;

            dgvUnits.BackgroundColor = Color.White;

            dgvUnits.GridColor =
                Color.FromArgb(230, 230, 230);

            dgvUnits.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvUnits.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;

            dgvUnits.RowHeadersVisible = false;


            // ========================================
            // Header
            // ========================================

            dgvUnits.ColumnHeadersHeight = 45;

            dgvUnits.ColumnHeadersDefaultCellStyle.BackColor =
                Color.White;

            dgvUnits.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.Black;

            dgvUnits.ColumnHeadersDefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Bold);

            dgvUnits.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvUnits.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.White;

            dgvUnits.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                Color.Black;


            // ========================================
            // Rows
            // ========================================

            dgvUnits.RowTemplate.Height = 52;

            dgvUnits.DefaultCellStyle.BackColor =
                Color.White;

            dgvUnits.DefaultCellStyle.ForeColor =
                Color.FromArgb(50, 50, 50);

            dgvUnits.DefaultCellStyle.Font =
                new Font("Cairo", 10, FontStyle.Regular);

            dgvUnits.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            // Alternate Row
            dgvUnits.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 248, 248);


            // ========================================
            // Selection
            // ========================================

            dgvUnits.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 245, 255);

            dgvUnits.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvUnits.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvUnits.MultiSelect = false;


            // ========================================
            // Behaviour
            // ========================================

            dgvUnits.ReadOnly = true;

            dgvUnits.AllowUserToAddRows = false;

            dgvUnits.AllowUserToDeleteRows = false;

            dgvUnits.AllowUserToResizeRows = false;

            dgvUnits.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            // نخلي زر اختيار بحجم ثابت
            dgvUnits.Columns["colSelectUnit"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.None;

            dgvUnits.Columns["colSelectUnit"].Width = 100;
        }


        // ========================================
        // Load Units
        // ========================================

        public void LoadUnitsByPropertyID(int propertyID)
        {
            if (propertyID <= 0)
            {
                Clear();

                return;
            }


            if (_unitService == null)
            {
                throw new InvalidOperationException(
                    "UnitService has not been initialized.");
            }


            this._propertyID = propertyID;


            List<UnitSelectionDTO> units =
                _unitService.GetUnitsByPropertyID(propertyID);


            this._allUnits =
                units ?? new List<UnitSelectionDTO>();


            _BindUnits(_allUnits);
        }


        // ========================================
        // Bind
        // ========================================

        private void _BindUnits(
            IEnumerable<UnitSelectionDTO> units)
        {
            List<UnitSelectionDTO> list =
                units.ToList();


            dgvUnits.DataSource =
                new BindingList<UnitSelectionDTO>(list);


            // لا تختار أول Row أوتوماتيك
            dgvUnits.ClearSelection();


            SelectedUnit = null;
        }


        // ========================================
        // Button Formatting
        // ========================================

        private void dgvUnits_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;


            if (dgvUnits.Columns[e.ColumnIndex].Name !=
                "colSelectUnit")
            {
                return;
            }


            e.CellStyle.BackColor =
                Color.FromArgb(57, 61, 126);

            e.CellStyle.ForeColor =
                Color.White;

            e.CellStyle.SelectionBackColor =
                Color.FromArgb(57, 61, 126);

            e.CellStyle.SelectionForeColor =
                Color.White;

            e.CellStyle.Font =
                new Font("Cairo", 9, FontStyle.Bold);

            e.CellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }


        // ========================================
        // Select Button Click
        // ========================================

        private void dgvUnits_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||
                e.ColumnIndex < 0)
            {
                return;
            }


            if (dgvUnits.Columns[e.ColumnIndex].Name !=
                "colSelectUnit")
            {
                return;
            }


            _SelectUnitFromRow(e.RowIndex);
        }


        // ========================================
        // Double Click
        // ========================================

        private void dgvUnits_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            _SelectUnitFromRow(e.RowIndex);
        }


        // ========================================
        // Select Unit
        // ========================================

        private void _SelectUnitFromRow(int rowIndex)
        {
            if (rowIndex < 0 ||
                rowIndex >= dgvUnits.Rows.Count)
            {
                return;
            }


            UnitSelectionDTO unit =
                dgvUnits.Rows[rowIndex].DataBoundItem
                as UnitSelectionDTO;


            if (unit == null)
                return;


            SelectedUnit = unit;


            dgvUnits.ClearSelection();

            dgvUnits.Rows[rowIndex].Selected = true;


            _RaiseUnitSelected(unit);
        }


        // ========================================
        // Raise Event
        // ========================================

        private void _RaiseUnitSelected(
            UnitSelectionDTO unit)
        {
            UnitSelected?.Invoke(
                this,
                new UnitSelectedEventArgs(unit));
        }


        // ========================================
        // Search
        // ========================================

        public void Search(string searchText)
        {
            if (_allUnits == null)
                return;


            searchText =
                searchText?.Trim() ?? string.Empty;


            IEnumerable<UnitSelectionDTO> result =
                _allUnits;


            if (!string.IsNullOrWhiteSpace(searchText))
            {
                result =
                    _allUnits.Where(unit =>
                        (!string.IsNullOrWhiteSpace(unit.UnitNumber) &&
                         unit.UnitNumber.IndexOf(
                             searchText,
                             StringComparison.OrdinalIgnoreCase) >= 0)

                        ||

                        (!string.IsNullOrWhiteSpace(unit.BuildingNumber) &&
                         unit.BuildingNumber.IndexOf(
                             searchText,
                             StringComparison.OrdinalIgnoreCase) >= 0)

                        ||

                        (!string.IsNullOrWhiteSpace(unit.BuildingName) &&
                         unit.BuildingName.IndexOf(
                             searchText,
                             StringComparison.OrdinalIgnoreCase) >= 0)
                    );
            }


            _BindUnits(result);
        }


        // ========================================
        // Clear
        // ========================================

        public void Clear()
        {
            _propertyID = -1;

            SelectedUnit = null;

            _allUnits.Clear();

            dgvUnits.DataSource = null;

            dgvUnits.Rows.Clear();

            dgvUnits.ClearSelection();
        }
        private void _LoadTemporaryUnits()
        {
            dgvUnits.Rows.Clear();

            dgvUnits.Rows.Add(
                1,
                "101",
                "شقة",
                "A",
                "المبنى A"
            );

            dgvUnits.Rows.Add(
                2,
                "102",
                "شقة",
                "A",
                "المبنى A"
            );

            dgvUnits.Rows.Add(
                3,
                "201",
                "مكتب",
                "A",
                "المبنى A"
            );

            dgvUnits.Rows.Add(
                4,
                "101",
                "شقة",
                "B",
                "المبنى B"
            );

            dgvUnits.Rows.Add(
                5,
                "102",
                "مكتب",
                "B",
                "المبنى B"
            );

            dgvUnits.Rows.Add(
                6,
                "G-01",
                "محل تجاري",
                "C",
                "المبنى التجاري"
            );
        }

        private void ctrlUnitsListView_Load(object sender, EventArgs e)
        {
            _LoadTemporaryUnits();
        }

    }
}

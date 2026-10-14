namespace REMS.UI.Client_Roles.UnitOwner
{
    partial class frmManageUnitCoOwners
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainCountainer = new System.Windows.Forms.Panel();
            this.tcClientInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabAddClient = new System.Windows.Forms.TabPage();
            this.btnNextt = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.tabClientSettings = new System.Windows.Forms.TabPage();
            this.txtCreationUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtOwnershipPercentage = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pbSuccess = new Guna.UI2.WinForms.Guna2PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctrlCommonSection_Person_ClientSelector1 = new REMS.UI.Client_Roles.Owner.Control.ctrlCommonSection_Person_ClientSelector();
            this.MainCountainer.SuspendLayout();
            this.tcClientInfo.SuspendLayout();
            this.tabAddClient.SuspendLayout();
            this.tabClientSettings.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOwnershipPercentage)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuccess)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainCountainer
            // 
            this.MainCountainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.MainCountainer.Controls.Add(this.tcClientInfo);
            this.MainCountainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainCountainer.Location = new System.Drawing.Point(0, 0);
            this.MainCountainer.Name = "MainCountainer";
            this.MainCountainer.Size = new System.Drawing.Size(1477, 706);
            this.MainCountainer.TabIndex = 0;
            // 
            // tcClientInfo
            // 
            this.tcClientInfo.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcClientInfo.Controls.Add(this.tabAddClient);
            this.tcClientInfo.Controls.Add(this.tabClientSettings);
            this.tcClientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcClientInfo.ItemSize = new System.Drawing.Size(180, 40);
            this.tcClientInfo.Location = new System.Drawing.Point(0, 0);
            this.tcClientInfo.Name = "tcClientInfo";
            this.tcClientInfo.SelectedIndex = 0;
            this.tcClientInfo.Size = new System.Drawing.Size(1477, 706);
            this.tcClientInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcClientInfo.TabButtonHoverState.FillColor = System.Drawing.Color.Empty;
            this.tcClientInfo.TabButtonHoverState.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Bold);
            this.tcClientInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.Black;
            this.tcClientInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.tcClientInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcClientInfo.TabButtonIdleState.FillColor = System.Drawing.Color.Transparent;
            this.tcClientInfo.TabButtonIdleState.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Bold);
            this.tcClientInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.tcClientInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.tcClientInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcClientInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tcClientInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Bold);
            this.tcClientInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.tcClientInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.tcClientInfo.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcClientInfo.TabIndex = 2;
            this.tcClientInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            // 
            // tabAddClient
            // 
            this.tabAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tabAddClient.Controls.Add(this.btnNextt);
            this.tabAddClient.Controls.Add(this.ctrlCommonSection_Person_ClientSelector1);
            this.tabAddClient.Controls.Add(this.btnSave);
            this.tabAddClient.Controls.Add(this.btnNext);
            this.tabAddClient.Location = new System.Drawing.Point(184, 4);
            this.tabAddClient.Name = "tabAddClient";
            this.tabAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddClient.Size = new System.Drawing.Size(1289, 698);
            this.tabAddClient.TabIndex = 0;
            this.tabAddClient.Text = "اختيار العميل";
            // 
            // btnNextt
            // 
            this.btnNextt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNextt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(63)))));
            this.btnNextt.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNextt.ForeColor = System.Drawing.Color.White;
            this.btnNextt.Location = new System.Drawing.Point(3, 650);
            this.btnNextt.Name = "btnNextt";
            this.btnNextt.Size = new System.Drawing.Size(1283, 45);
            this.btnNextt.TabIndex = 6;
            this.btnNextt.Text = "التالي";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 5;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.btnSave.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.btnSave.Image = global::REMS.UI.Properties.Resources.icons8_save_30__2_;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(6, 754);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(1183, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفظ";
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 5;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Enabled = false;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.btnNext.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.btnNext.Image = global::REMS.UI.Properties.Resources.icons8_arrow_30__1_;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNext.Location = new System.Drawing.Point(8, 807);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(1183, 45);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "التالي";
            // 
            // tabClientSettings
            // 
            this.tabClientSettings.BackColor = System.Drawing.Color.White;
            this.tabClientSettings.Controls.Add(this.guna2GroupBox1);
            this.tabClientSettings.Controls.Add(this.HeaderPanel);
            this.tabClientSettings.Location = new System.Drawing.Point(184, 4);
            this.tabClientSettings.Name = "tabClientSettings";
            this.tabClientSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientSettings.Size = new System.Drawing.Size(1289, 698);
            this.tabClientSettings.TabIndex = 1;
            this.tabClientSettings.Text = "بيانات مالك الوحدة";
            // 
            // txtCreationUserID
            // 
            this.txtCreationUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreationUserID.DefaultText = "";
            this.txtCreationUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCreationUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCreationUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreationUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreationUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreationUserID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCreationUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreationUserID.Location = new System.Drawing.Point(678, 76);
            this.txtCreationUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCreationUserID.Name = "txtCreationUserID";
            this.txtCreationUserID.PlaceholderText = "";
            this.txtCreationUserID.ReadOnly = true;
            this.txtCreationUserID.SelectedText = "";
            this.txtCreationUserID.Size = new System.Drawing.Size(381, 38);
            this.txtCreationUserID.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(1065, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "معرّف مستخدم";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.panel1);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1283, 55);
            this.HeaderPanel.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(1090, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "مازن الأزهر";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1281, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 55);
            this.panel1.TabIndex = 2;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Controls.Add(this.guna2Button1);
            this.guna2GroupBox1.Controls.Add(this.panel9);
            this.guna2GroupBox1.Controls.Add(this.textBox1);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.checkBox1);
            this.guna2GroupBox1.Controls.Add(this.pictureBox2);
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox2);
            this.guna2GroupBox1.Controls.Add(this.label22);
            this.guna2GroupBox1.Controls.Add(this.guna2DateTimePicker1);
            this.guna2GroupBox1.Controls.Add(this.txtOwnershipPercentage);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox1);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.txtCreationUserID);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 58);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1283, 632);
            this.guna2GroupBox1.TabIndex = 45;
            this.guna2GroupBox1.Text = "البيانات الرئيسيه";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(508, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "معرّف مستخدم";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(121, 76);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(381, 38);
            this.guna2TextBox1.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(1065, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "رقم الصك";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(678, 234);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(381, 36);
            this.guna2DateTimePicker1.TabIndex = 49;
            this.guna2DateTimePicker1.Value = new System.DateTime(2026, 5, 25, 20, 45, 33, 825);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(1065, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 48;
            this.label5.Text = "تاريخ الصك";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(678, 155);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.ReadOnly = true;
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(381, 38);
            this.guna2TextBox2.TabIndex = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::REMS.UI.Properties.Resources.icons8_percentage_302;
            this.pictureBox2.Location = new System.Drawing.Point(442, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Gray;
            this.label22.Location = new System.Drawing.Point(508, 155);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 29);
            this.label22.TabIndex = 48;
            this.label22.Text = "نسبة الملكية";
            // 
            // txtOwnershipPercentage
            // 
            this.txtOwnershipPercentage.BackColor = System.Drawing.Color.Transparent;
            this.txtOwnershipPercentage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOwnershipPercentage.DecimalPlaces = 2;
            this.txtOwnershipPercentage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOwnershipPercentage.Location = new System.Drawing.Point(121, 155);
            this.txtOwnershipPercentage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOwnershipPercentage.Name = "txtOwnershipPercentage";
            this.txtOwnershipPercentage.Size = new System.Drawing.Size(381, 38);
            this.txtOwnershipPercentage.TabIndex = 47;
            this.txtOwnershipPercentage.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Gray;
            this.checkBox1.Location = new System.Drawing.Point(361, 237);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(141, 33);
            this.checkBox1.TabIndex = 51;
            this.checkBox1.Text = "المالك الأساسي";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(1065, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 29);
            this.label6.TabIndex = 52;
            this.label6.Text = "تاريخ الصك";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 318);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(938, 141);
            this.textBox1.TabIndex = 53;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pbSuccess);
            this.panel9.Controls.Add(this.linkLabel1);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(3, 462);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1210, 106);
            this.panel9.TabIndex = 54;
            // 
            // pbSuccess
            // 
            this.pbSuccess.Image = global::REMS.UI.Properties.Resources.icons8_success_25;
            this.pbSuccess.ImageRotate = 0F;
            this.pbSuccess.Location = new System.Drawing.Point(550, 75);
            this.pbSuccess.Name = "pbSuccess";
            this.pbSuccess.Size = new System.Drawing.Size(26, 25);
            this.pbSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSuccess.TabIndex = 5;
            this.pbSuccess.TabStop = false;
            this.pbSuccess.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(577, 70);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(173, 29);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اضغط هنا لتحميل الملف";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel10.Controls.Add(this.panel2);
            this.panel10.Controls.Add(this.label27);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(0, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1208, 55);
            this.panel10.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Cairo Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label27.Location = new System.Drawing.Point(1090, 15);
            this.label27.Name = "label27";
            this.label27.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label27.Size = new System.Drawing.Size(95, 24);
            this.label27.TabIndex = 3;
            this.label27.Text = "   صوره الصك";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.panel11.Location = new System.Drawing.Point(1277, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(2, 55);
            this.panel11.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.guna2Button1.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(0, 587);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(1283, 45);
            this.guna2Button1.TabIndex = 55;
            this.guna2Button1.Text = "اختيار";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.panel2.Location = new System.Drawing.Point(1206, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 55);
            this.panel2.TabIndex = 56;
            // 
            // ctrlCommonSection_Person_ClientSelector1
            // 
            this.ctrlCommonSection_Person_ClientSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlCommonSection_Person_ClientSelector1.Location = new System.Drawing.Point(3, 3);
            this.ctrlCommonSection_Person_ClientSelector1.Name = "ctrlCommonSection_Person_ClientSelector1";
            this.ctrlCommonSection_Person_ClientSelector1.Size = new System.Drawing.Size(1283, 641);
            this.ctrlCommonSection_Person_ClientSelector1.TabIndex = 5;
            this.ctrlCommonSection_Person_ClientSelector1.Load += new System.EventHandler(this.ctrlCommonSection_Person_ClientSelector1_Load);
            // 
            // frmManageUnitCoOwners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 706);
            this.Controls.Add(this.MainCountainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageUnitCoOwners";
            this.Text = "frmManageUnitCoOwners";
            this.MainCountainer.ResumeLayout(false);
            this.tcClientInfo.ResumeLayout(false);
            this.tabAddClient.ResumeLayout(false);
            this.tabClientSettings.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOwnershipPercentage)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuccess)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainCountainer;
        private Guna.UI2.WinForms.Guna2TabControl tcClientInfo;
        private System.Windows.Forms.TabPage tabAddClient;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.TabPage tabClientSettings;
        private Owner.Control.ctrlCommonSection_Person_ClientSelector ctrlCommonSection_Person_Client1;
        private Owner.Control.ctrlCommonSection_Person_ClientSelector ctrlCommonSection_Person_ClientSelector1;
        private Guna.UI2.WinForms.Guna2Button btnNextt;
        private Guna.UI2.WinForms.Guna2TextBox txtCreationUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label22;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtOwnershipPercentage;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2PictureBox pbSuccess;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel11;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel2;
    }
}
namespace REMS.UI.RealEstateAndUnits
{
    partial class frmAddPropertyOwnerships
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pbSuccess = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LlAddDeedImage = new System.Windows.Forms.LinkLabel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtOwnershipPercentage = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gbInstrumentCondition = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtbDateOfInstrument = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPlotNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtInstrumentNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFindOwner = new Guna.UI2.WinForms.Guna2Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOwnerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuccess)).BeginInit();
            this.panel10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOwnershipPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.guna2GroupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 575);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.btnAdd.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 530);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(1231, 45);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "اضافه";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.panel9);
            this.guna2GroupBox1.Controls.Add(this.groupBox1);
            this.guna2GroupBox1.Controls.Add(this.label21);
            this.guna2GroupBox1.Controls.Add(this.label22);
            this.guna2GroupBox1.Controls.Add(this.txtOwnershipPercentage);
            this.guna2GroupBox1.Controls.Add(this.guna2Button1);
            this.guna2GroupBox1.Controls.Add(this.gbInstrumentCondition);
            this.guna2GroupBox1.Controls.Add(this.dtbDateOfInstrument);
            this.guna2GroupBox1.Controls.Add(this.label18);
            this.guna2GroupBox1.Controls.Add(this.txtPlotNumber);
            this.guna2GroupBox1.Controls.Add(this.label19);
            this.guna2GroupBox1.Controls.Add(this.txtInstrumentNumber);
            this.guna2GroupBox1.Controls.Add(this.label17);
            this.guna2GroupBox1.Controls.Add(this.txtFindOwner);
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Controls.Add(this.txtOwnerName);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1231, 520);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "بيانات الملكيه";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pbSuccess);
            this.panel9.Controls.Add(this.LlAddDeedImage);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(291, 378);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(940, 138);
            this.panel9.TabIndex = 61;
            // 
            // pbSuccess
            // 
            this.pbSuccess.Image = global::REMS.UI.Properties.Resources.icons8_success_25;
            this.pbSuccess.ImageRotate = 0F;
            this.pbSuccess.Location = new System.Drawing.Point(361, 87);
            this.pbSuccess.Name = "pbSuccess";
            this.pbSuccess.Size = new System.Drawing.Size(26, 25);
            this.pbSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSuccess.TabIndex = 5;
            this.pbSuccess.TabStop = false;
            this.pbSuccess.Visible = false;
            // 
            // LlAddDeedImage
            // 
            this.LlAddDeedImage.AutoSize = true;
            this.LlAddDeedImage.LinkColor = System.Drawing.Color.Black;
            this.LlAddDeedImage.Location = new System.Drawing.Point(393, 83);
            this.LlAddDeedImage.Name = "LlAddDeedImage";
            this.LlAddDeedImage.Size = new System.Drawing.Size(173, 29);
            this.LlAddDeedImage.TabIndex = 4;
            this.LlAddDeedImage.TabStop = true;
            this.LlAddDeedImage.Text = "اضغط هنا لتحميل الملف";
            this.LlAddDeedImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlAddDeedImage_LinkClicked);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel10.Controls.Add(this.label27);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(940, 55);
            this.panel10.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Cairo Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label27.Location = new System.Drawing.Point(413, 14);
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
            this.panel11.Location = new System.Drawing.Point(1181, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(2, 55);
            this.panel11.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel7);
            this.groupBox1.Controls.Add(this.guna2PictureBox7);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(278, 380);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات الشخصيه";
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Font = new System.Drawing.Font("Cairo Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.linkLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel7.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.linkLabel7.Location = new System.Drawing.Point(111, 230);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.linkLabel7.Size = new System.Drawing.Size(49, 24);
            this.linkLabel7.TabIndex = 20;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "المزيد";
            this.linkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2PictureBox7
            // 
            this.guna2PictureBox7.Image = global::REMS.UI.Properties.Resources.icons8_person_48__1_;
            this.guna2PictureBox7.ImageRotate = 0F;
            this.guna2PictureBox7.Location = new System.Drawing.Point(59, 85);
            this.guna2PictureBox7.Name = "guna2PictureBox7";
            this.guna2PictureBox7.Size = new System.Drawing.Size(152, 131);
            this.guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox7.TabIndex = 19;
            this.guna2PictureBox7.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Gray;
            this.label21.Location = new System.Drawing.Point(673, 219);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 29);
            this.label21.TabIndex = 59;
            this.label21.Text = "حاله الصك";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Gray;
            this.label22.Location = new System.Drawing.Point(1126, 309);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 29);
            this.label22.TabIndex = 58;
            this.label22.Text = "نسبة الملكية";
            // 
            // txtOwnershipPercentage
            // 
            this.txtOwnershipPercentage.BackColor = System.Drawing.Color.Transparent;
            this.txtOwnershipPercentage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOwnershipPercentage.DecimalPlaces = 2;
            this.txtOwnershipPercentage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOwnershipPercentage.Location = new System.Drawing.Point(784, 300);
            this.txtOwnershipPercentage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOwnershipPercentage.Name = "txtOwnershipPercentage";
            this.txtOwnershipPercentage.Size = new System.Drawing.Size(335, 38);
            this.txtOwnershipPercentage.TabIndex = 57;
            this.txtOwnershipPercentage.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.txtOwnershipPercentage.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::REMS.UI.Properties.Resources.icons8_more_info_40;
            this.guna2Button1.Location = new System.Drawing.Point(12, 66);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(41, 38);
            this.guna2Button1.TabIndex = 56;
            // 
            // gbInstrumentCondition
            // 
            this.gbInstrumentCondition.BackColor = System.Drawing.Color.Transparent;
            this.gbInstrumentCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gbInstrumentCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gbInstrumentCondition.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gbInstrumentCondition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gbInstrumentCondition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbInstrumentCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gbInstrumentCondition.ItemHeight = 30;
            this.gbInstrumentCondition.Location = new System.Drawing.Point(332, 212);
            this.gbInstrumentCondition.Name = "gbInstrumentCondition";
            this.gbInstrumentCondition.Size = new System.Drawing.Size(335, 36);
            this.gbInstrumentCondition.TabIndex = 55;
            // 
            // dtbDateOfInstrument
            // 
            this.dtbDateOfInstrument.Checked = true;
            this.dtbDateOfInstrument.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.dtbDateOfInstrument.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtbDateOfInstrument.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtbDateOfInstrument.Location = new System.Drawing.Point(332, 142);
            this.dtbDateOfInstrument.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtbDateOfInstrument.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtbDateOfInstrument.Name = "dtbDateOfInstrument";
            this.dtbDateOfInstrument.Size = new System.Drawing.Size(335, 36);
            this.dtbDateOfInstrument.TabIndex = 54;
            this.dtbDateOfInstrument.Value = new System.DateTime(2026, 5, 25, 20, 45, 33, 825);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(673, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 29);
            this.label18.TabIndex = 49;
            this.label18.Text = "تاريخ الصك";
            // 
            // txtPlotNumber
            // 
            this.txtPlotNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlotNumber.DefaultText = "";
            this.txtPlotNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlotNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlotNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlotNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlotNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlotNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPlotNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlotNumber.Location = new System.Drawing.Point(784, 221);
            this.txtPlotNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlotNumber.Name = "txtPlotNumber";
            this.txtPlotNumber.PlaceholderText = "";
            this.txtPlotNumber.SelectedText = "";
            this.txtPlotNumber.Size = new System.Drawing.Size(335, 38);
            this.txtPlotNumber.TabIndex = 52;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Gray;
            this.label19.Location = new System.Drawing.Point(1126, 210);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 58);
            this.label19.TabIndex = 50;
            this.label19.Text = "رقم الارض\r\n العقار";
            // 
            // txtInstrumentNumber
            // 
            this.txtInstrumentNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstrumentNumber.DefaultText = "";
            this.txtInstrumentNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstrumentNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInstrumentNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstrumentNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstrumentNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstrumentNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInstrumentNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstrumentNumber.Location = new System.Drawing.Point(784, 140);
            this.txtInstrumentNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInstrumentNumber.Name = "txtInstrumentNumber";
            this.txtInstrumentNumber.PlaceholderText = "";
            this.txtInstrumentNumber.SelectedText = "";
            this.txtInstrumentNumber.Size = new System.Drawing.Size(335, 38);
            this.txtInstrumentNumber.TabIndex = 53;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(1125, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 29);
            this.label17.TabIndex = 51;
            this.label17.Text = "رقم الصك";
            // 
            // txtFindOwner
            // 
            this.txtFindOwner.BorderRadius = 2;
            this.txtFindOwner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFindOwner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtFindOwner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtFindOwner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtFindOwner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.txtFindOwner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFindOwner.ForeColor = System.Drawing.Color.White;
            this.txtFindOwner.Location = new System.Drawing.Point(59, 66);
            this.txtFindOwner.Name = "txtFindOwner";
            this.txtFindOwner.Size = new System.Drawing.Size(41, 38);
            this.txtFindOwner.TabIndex = 48;
            this.txtFindOwner.Text = "+";
            this.txtFindOwner.Click += new System.EventHandler(this.txtFindOwner_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(1125, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 29);
            this.label12.TabIndex = 47;
            this.label12.Text = "المالك";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOwnerName.DefaultText = "";
            this.txtOwnerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOwnerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOwnerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOwnerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOwnerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOwnerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOwnerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOwnerName.Location = new System.Drawing.Point(106, 66);
            this.txtOwnerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.PlaceholderText = "";
            this.txtOwnerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOwnerName.SelectedText = "";
            this.txtOwnerName.Size = new System.Drawing.Size(1013, 38);
            this.txtOwnerName.TabIndex = 46;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddPropertyOwnerships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 575);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddPropertyOwnerships";
            this.Text = "frmAddPropertyOwnerships";
            this.panel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuccess)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOwnershipPercentage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label22;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtOwnershipPercentage;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox gbInstrumentCondition;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtbDateOfInstrument;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox txtPlotNumber;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2TextBox txtInstrumentNumber;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2Button txtFindOwner;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtOwnerName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox7;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2PictureBox pbSuccess;
        private System.Windows.Forms.LinkLabel LlAddDeedImage;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel11;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
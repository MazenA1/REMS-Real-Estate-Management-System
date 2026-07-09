namespace REMS.UI.Person.Control
{
    partial class ctrlPersonCard
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCountry = new Guna.UI2.WinForms.Guna2TextBox();
            this.llkl = new System.Windows.Forms.Label();
            this.txtPhone2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.LiEdit = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTaxNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PbClientImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNationalID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPersonID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNameEnglish = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            guna2GroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbClientImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.BorderColor = System.Drawing.Color.White;
            guna2GroupBox1.Controls.Add(this.panel2);
            guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 60, 0, 0);
            guna2GroupBox1.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.Size = new System.Drawing.Size(1207, 477);
            guna2GroupBox1.TabIndex = 5;
            guna2GroupBox1.Text = "المعلومات الشخصيه";
            guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCountry);
            this.panel2.Controls.Add(this.llkl);
            this.panel2.Controls.Add(this.txtPhone2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.LiEdit);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtTaxNumber);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.PbClientImage);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPhoneNumber1);
            this.panel2.Controls.Add(this.txtNationalID);
            this.panel2.Controls.Add(this.txtFullName);
            this.panel2.Controls.Add(this.txtPersonID);
            this.panel2.Controls.Add(this.txtNameEnglish);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Location = new System.Drawing.Point(-15, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 455);
            this.panel2.TabIndex = 18;
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCountry.DefaultText = "";
            this.txtCountry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCountry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCountry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCountry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCountry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCountry.Location = new System.Drawing.Point(314, 149);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PlaceholderText = "";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.SelectedText = "";
            this.txtCountry.Size = new System.Drawing.Size(303, 38);
            this.txtCountry.TabIndex = 34;
            // 
            // llkl
            // 
            this.llkl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llkl.AutoSize = true;
            this.llkl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.llkl.Location = new System.Drawing.Point(1091, 269);
            this.llkl.Name = "llkl";
            this.llkl.Size = new System.Drawing.Size(84, 29);
            this.llkl.TabIndex = 32;
            this.llkl.Text = "رقم اضافي";
            // 
            // txtPhone2
            // 
            this.txtPhone2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone2.DefaultText = "";
            this.txtPhone2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone2.Location = new System.Drawing.Point(786, 269);
            this.txtPhone2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.PlaceholderText = "";
            this.txtPhone2.ReadOnly = true;
            this.txtPhone2.SelectedText = "";
            this.txtPhone2.Size = new System.Drawing.Size(303, 38);
            this.txtPhone2.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.label11.Location = new System.Drawing.Point(623, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 29);
            this.label11.TabIndex = 30;
            this.label11.Text = "بريد إلكتروني";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(314, 89);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(303, 38);
            this.txtEmail.TabIndex = 31;
            // 
            // LiEdit
            // 
            this.LiEdit.AutoSize = true;
            this.LiEdit.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LiEdit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.LiEdit.Location = new System.Drawing.Point(95, 257);
            this.LiEdit.Name = "LiEdit";
            this.LiEdit.Size = new System.Drawing.Size(58, 32);
            this.LiEdit.TabIndex = 28;
            this.LiEdit.TabStop = true;
            this.LiEdit.Text = "تعديل";
            this.LiEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LiEdit_LinkClicked);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.label7.Location = new System.Drawing.Point(1091, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "الرقم الضريبي";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.label2.Location = new System.Drawing.Point(1091, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم الهاتف";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(1091, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "الرقم الوطني";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.label4.Location = new System.Drawing.Point(1091, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "الاسم الكامل";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(1095, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم الشخص";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.label10.Location = new System.Drawing.Point(623, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "الجنسية";
            // 
            // txtTaxNumber
            // 
            this.txtTaxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaxNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaxNumber.DefaultText = "";
            this.txtTaxNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaxNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaxNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaxNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaxNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaxNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaxNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaxNumber.Location = new System.Drawing.Point(786, 327);
            this.txtTaxNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaxNumber.Name = "txtTaxNumber";
            this.txtTaxNumber.PlaceholderText = "";
            this.txtTaxNumber.ReadOnly = true;
            this.txtTaxNumber.SelectedText = "";
            this.txtTaxNumber.Size = new System.Drawing.Size(303, 38);
            this.txtTaxNumber.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.label8.Location = new System.Drawing.Point(623, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "الاسم بالانجليزي";
            // 
            // PbClientImage
            // 
            this.PbClientImage.Image = global::REMS.UI.Properties.Resources.icons8_person_48__1_;
            this.PbClientImage.ImageRotate = 0F;
            this.PbClientImage.Location = new System.Drawing.Point(21, 38);
            this.PbClientImage.Name = "PbClientImage";
            this.PbClientImage.Size = new System.Drawing.Size(215, 200);
            this.PbClientImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbClientImage.TabIndex = 22;
            this.PbClientImage.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.label6.Location = new System.Drawing.Point(623, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "تاريخ الميلاد";
            // 
            // txtPhoneNumber1
            // 
            this.txtPhoneNumber1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber1.DefaultText = "";
            this.txtPhoneNumber1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneNumber1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber1.Location = new System.Drawing.Point(786, 209);
            this.txtPhoneNumber1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber1.Name = "txtPhoneNumber1";
            this.txtPhoneNumber1.PlaceholderText = "";
            this.txtPhoneNumber1.ReadOnly = true;
            this.txtPhoneNumber1.SelectedText = "";
            this.txtPhoneNumber1.Size = new System.Drawing.Size(303, 38);
            this.txtPhoneNumber1.TabIndex = 15;
            // 
            // txtNationalID
            // 
            this.txtNationalID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNationalID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalID.DefaultText = "";
            this.txtNationalID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationalID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationalID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNationalID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalID.Location = new System.Drawing.Point(786, 149);
            this.txtNationalID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.PlaceholderText = "";
            this.txtNationalID.ReadOnly = true;
            this.txtNationalID.SelectedText = "";
            this.txtNationalID.Size = new System.Drawing.Size(303, 38);
            this.txtNationalID.TabIndex = 14;
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Location = new System.Drawing.Point(786, 89);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(303, 38);
            this.txtFullName.TabIndex = 13;
            // 
            // txtPersonID
            // 
            this.txtPersonID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonID.DefaultText = "?????";
            this.txtPersonID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPersonID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPersonID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPersonID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPersonID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPersonID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPersonID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPersonID.Location = new System.Drawing.Point(786, 29);
            this.txtPersonID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.PlaceholderText = "";
            this.txtPersonID.ReadOnly = true;
            this.txtPersonID.SelectedText = "";
            this.txtPersonID.Size = new System.Drawing.Size(303, 38);
            this.txtPersonID.TabIndex = 12;
            // 
            // txtNameEnglish
            // 
            this.txtNameEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameEnglish.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameEnglish.DefaultText = "";
            this.txtNameEnglish.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameEnglish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameEnglish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameEnglish.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameEnglish.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameEnglish.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameEnglish.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameEnglish.Location = new System.Drawing.Point(314, 29);
            this.txtNameEnglish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameEnglish.Name = "txtNameEnglish";
            this.txtNameEnglish.PlaceholderText = "";
            this.txtNameEnglish.ReadOnly = true;
            this.txtNameEnglish.SelectedText = "";
            this.txtNameEnglish.Size = new System.Drawing.Size(303, 38);
            this.txtNameEnglish.TabIndex = 13;
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = true;
            this.dtpDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDate.Location = new System.Drawing.Point(314, 205);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(303, 38);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.Value = new System.DateTime(2026, 3, 23, 17, 2, 56, 340);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Cairo", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.rbFemale.Location = new System.Drawing.Point(949, 438);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbFemale.Size = new System.Drawing.Size(55, 28);
            this.rbFemale.TabIndex = 26;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "أنثى";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Cairo", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.rbMale.Location = new System.Drawing.Point(1023, 438);
            this.rbMale.Name = "rbMale";
            this.rbMale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbMale.Size = new System.Drawing.Size(51, 28);
            this.rbMale.TabIndex = 25;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "ذكر";
            this.rbMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(guna2GroupBox1);
            this.Name = "ctrlPersonCard";
            this.Size = new System.Drawing.Size(1206, 480);
            guna2GroupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbClientImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label llkl;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone2;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.LinkLabel LiEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtTaxNumber;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2PictureBox PbClientImage;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber1;
        private Guna.UI2.WinForms.Guna2TextBox txtNationalID;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtPersonID;
        private Guna.UI2.WinForms.Guna2TextBox txtNameEnglish;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private Guna.UI2.WinForms.Guna2TextBox txtCountry;
    }
}

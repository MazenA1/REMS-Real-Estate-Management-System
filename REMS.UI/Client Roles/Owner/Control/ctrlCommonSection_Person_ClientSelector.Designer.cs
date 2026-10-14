namespace REMS.UI.Client_Roles.Owner.Control
{
    partial class ctrlCommonSection_Person_ClientSelector
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
            this.CountainerPanel = new System.Windows.Forms.Panel();
            this.btnAddClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPerson = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindeData = new Guna.UI2.WinForms.Guna2Button();
            this.CbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFinde = new Guna.UI2.WinForms.Guna2TextBox();
            this.tcClientInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabAddClient = new System.Windows.Forms.TabPage();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.tabClientSettings = new System.Windows.Forms.TabPage();
            this.ClientPageInfoPanel = new System.Windows.Forms.Panel();
            this.ctrlPersonCard1 = new REMS.UI.Person.Control.ctrlPersonCard();
            this.ctrlClientCardInfo1 = new REMS.UI.Customer_Management.Control.ctrlClientCardInfo();
            this.CountainerPanel.SuspendLayout();
            this.tcClientInfo.SuspendLayout();
            this.tabAddClient.SuspendLayout();
            this.tabClientSettings.SuspendLayout();
            this.ClientPageInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountainerPanel
            // 
            this.CountainerPanel.BackColor = System.Drawing.Color.White;
            this.CountainerPanel.Controls.Add(this.btnAddClient);
            this.CountainerPanel.Controls.Add(this.btnAddPerson);
            this.CountainerPanel.Controls.Add(this.btnFindeData);
            this.CountainerPanel.Controls.Add(this.CbType);
            this.CountainerPanel.Controls.Add(this.txtFinde);
            this.CountainerPanel.Controls.Add(this.tcClientInfo);
            this.CountainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountainerPanel.Location = new System.Drawing.Point(0, 0);
            this.CountainerPanel.Name = "CountainerPanel";
            this.CountainerPanel.Size = new System.Drawing.Size(1220, 642);
            this.CountainerPanel.TabIndex = 0;
            // 
            // btnAddClient
            // 
            this.btnAddClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.btnAddClient.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(0, 546);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(1220, 45);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "إضافة عميل";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPerson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddPerson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.btnAddPerson.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.Location = new System.Drawing.Point(0, 597);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(1220, 45);
            this.btnAddPerson.TabIndex = 6;
            this.btnAddPerson.Text = "إضافة شخص";
            // 
            // btnFindeData
            // 
            this.btnFindeData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindeData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindeData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindeData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindeData.FillColor = System.Drawing.Color.White;
            this.btnFindeData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindeData.ForeColor = System.Drawing.Color.White;
            this.btnFindeData.Image = global::REMS.UI.Properties.Resources.icons8_find_user_male_30;
            this.btnFindeData.ImageSize = new System.Drawing.Size(35, 35);
            this.btnFindeData.Location = new System.Drawing.Point(1145, 7);
            this.btnFindeData.Name = "btnFindeData";
            this.btnFindeData.Size = new System.Drawing.Size(45, 36);
            this.btnFindeData.TabIndex = 5;
            this.btnFindeData.Click += new System.EventHandler(this.btnFindeData_Click);
            // 
            // CbType
            // 
            this.CbType.BackColor = System.Drawing.Color.Transparent;
            this.CbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbType.Font = new System.Drawing.Font("Cairo Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.CbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbType.ItemHeight = 30;
            this.CbType.Items.AddRange(new object[] {
            "معرف الشخص",
            "الرقم الوطني"});
            this.CbType.Location = new System.Drawing.Point(543, 7);
            this.CbType.Name = "CbType";
            this.CbType.Size = new System.Drawing.Size(290, 36);
            this.CbType.TabIndex = 4;
            this.CbType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFinde
            // 
            this.txtFinde.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFinde.DefaultText = "";
            this.txtFinde.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFinde.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFinde.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinde.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinde.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFinde.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinde.Location = new System.Drawing.Point(845, 7);
            this.txtFinde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFinde.Name = "txtFinde";
            this.txtFinde.PlaceholderText = "";
            this.txtFinde.SelectedText = "";
            this.txtFinde.Size = new System.Drawing.Size(290, 44);
            this.txtFinde.TabIndex = 3;
            // 
            // tcClientInfo
            // 
            this.tcClientInfo.Controls.Add(this.tabAddClient);
            this.tcClientInfo.Controls.Add(this.tabClientSettings);
            this.tcClientInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcClientInfo.ItemSize = new System.Drawing.Size(180, 40);
            this.tcClientInfo.Location = new System.Drawing.Point(0, 0);
            this.tcClientInfo.Name = "tcClientInfo";
            this.tcClientInfo.SelectedIndex = 0;
            this.tcClientInfo.Size = new System.Drawing.Size(1220, 535);
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
            this.tcClientInfo.TabMenuBackColor = System.Drawing.Color.White;
            this.tcClientInfo.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabAddClient
            // 
            this.tabAddClient.BackColor = System.Drawing.Color.White;
            this.tabAddClient.Controls.Add(this.ctrlPersonCard1);
            this.tabAddClient.Controls.Add(this.btnSave);
            this.tabAddClient.Controls.Add(this.btnNext);
            this.tabAddClient.Location = new System.Drawing.Point(4, 44);
            this.tabAddClient.Name = "tabAddClient";
            this.tabAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddClient.Size = new System.Drawing.Size(1212, 487);
            this.tabAddClient.TabIndex = 0;
            this.tabAddClient.Text = "المعلومات الشخصية";
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
            this.tabClientSettings.Controls.Add(this.ClientPageInfoPanel);
            this.tabClientSettings.Location = new System.Drawing.Point(4, 44);
            this.tabClientSettings.Name = "tabClientSettings";
            this.tabClientSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientSettings.Size = new System.Drawing.Size(1212, 487);
            this.tabClientSettings.TabIndex = 1;
            this.tabClientSettings.Text = "معلومات العميل";
            // 
            // ClientPageInfoPanel
            // 
            this.ClientPageInfoPanel.Controls.Add(this.ctrlClientCardInfo1);
            this.ClientPageInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientPageInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.ClientPageInfoPanel.Name = "ClientPageInfoPanel";
            this.ClientPageInfoPanel.Size = new System.Drawing.Size(1206, 481);
            this.ClientPageInfoPanel.TabIndex = 0;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(1206, 480);
            this.ctrlPersonCard1.TabIndex = 5;
            // 
            // ctrlClientCardInfo1
            // 
            this.ctrlClientCardInfo1.AutoSize = true;
            this.ctrlClientCardInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlClientCardInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlClientCardInfo1.Name = "ctrlClientCardInfo1";
            this.ctrlClientCardInfo1.Size = new System.Drawing.Size(1206, 481);
            this.ctrlClientCardInfo1.TabIndex = 0;
            // 
            // ctrlCommonSection_Person_ClientSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CountainerPanel);
            this.Name = "ctrlCommonSection_Person_ClientSelector";
            this.Size = new System.Drawing.Size(1220, 642);
            this.CountainerPanel.ResumeLayout(false);
            this.tcClientInfo.ResumeLayout(false);
            this.tabAddClient.ResumeLayout(false);
            this.tabClientSettings.ResumeLayout(false);
            this.ClientPageInfoPanel.ResumeLayout(false);
            this.ClientPageInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CountainerPanel;
        private Guna.UI2.WinForms.Guna2TabControl tcClientInfo;
        private System.Windows.Forms.TabPage tabAddClient;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.TabPage tabClientSettings;
        private Person.Control.ctrlPersonCard ctrlPersonCard1;
        private Guna.UI2.WinForms.Guna2Button btnFindeData;
        private Guna.UI2.WinForms.Guna2ComboBox CbType;
        private Guna.UI2.WinForms.Guna2TextBox txtFinde;
        private System.Windows.Forms.Panel ClientPageInfoPanel;
        private Customer_Management.Control.ctrlClientCardInfo ctrlClientCardInfo1;
        private Guna.UI2.WinForms.Guna2Button btnAddPerson;
        private Guna.UI2.WinForms.Guna2Button btnAddClient;
    }
}

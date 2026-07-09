namespace REMS.UI.Client_Roles.Owner.Control
{
    partial class ctrlFindOwnerWhithFilter
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
            this.components = new System.ComponentModel.Container();
            this.GBFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFinde = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddPerson = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindePerson = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlOwnerInfoCard1 = new REMS.UI.Client_Roles.Owner.Control.ctrlOwnerInfoCard();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GBFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBFilter
            // 
            this.GBFilter.Controls.Add(this.panel4);
            this.GBFilter.Controls.Add(this.panel3);
            this.GBFilter.Controls.Add(this.panel1);
            this.GBFilter.Controls.Add(this.btnAddPerson);
            this.GBFilter.Controls.Add(this.btnFindePerson);
            this.GBFilter.Controls.Add(this.CbType);
            this.GBFilter.Controls.Add(this.txtFinde);
            this.GBFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.GBFilter.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.GBFilter.ForeColor = System.Drawing.Color.White;
            this.GBFilter.Location = new System.Drawing.Point(0, 0);
            this.GBFilter.Name = "GBFilter";
            this.GBFilter.Size = new System.Drawing.Size(1349, 110);
            this.GBFilter.TabIndex = 31;
            this.GBFilter.Text = "ابحث";
            this.GBFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(1301, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 48);
            this.panel4.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(1173, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 48);
            this.panel3.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(1238, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 48);
            this.panel1.TabIndex = 35;
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
            this.CbType.Location = new System.Drawing.Point(570, 58);
            this.CbType.Name = "CbType";
            this.CbType.Size = new System.Drawing.Size(290, 36);
            this.CbType.TabIndex = 1;
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
            this.txtFinde.Location = new System.Drawing.Point(866, 58);
            this.txtFinde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFinde.Name = "txtFinde";
            this.txtFinde.PlaceholderText = "";
            this.txtFinde.SelectedText = "";
            this.txtFinde.Size = new System.Drawing.Size(290, 43);
            this.txtFinde.TabIndex = 0;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPerson.FillColor = System.Drawing.Color.White;
            this.btnAddPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.Image = global::REMS.UI.Properties.Resources.icons8_add_male_user_30;
            this.btnAddPerson.ImageSize = new System.Drawing.Size(39, 39);
            this.btnAddPerson.Location = new System.Drawing.Point(1244, 58);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(51, 43);
            this.btnAddPerson.TabIndex = 3;
            // 
            // btnFindePerson
            // 
            this.btnFindePerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindePerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindePerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindePerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindePerson.FillColor = System.Drawing.Color.White;
            this.btnFindePerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindePerson.ForeColor = System.Drawing.Color.White;
            this.btnFindePerson.Image = global::REMS.UI.Properties.Resources.icons8_find_user_male_30;
            this.btnFindePerson.ImageSize = new System.Drawing.Size(35, 35);
            this.btnFindePerson.Location = new System.Drawing.Point(1181, 58);
            this.btnFindePerson.Name = "btnFindePerson";
            this.btnFindePerson.Size = new System.Drawing.Size(51, 43);
            this.btnFindePerson.TabIndex = 2;
            this.btnFindePerson.Click += new System.EventHandler(this.btnFindePerson_Click);
            // 
            // ctrlOwnerInfoCard1
            // 
            this.ctrlOwnerInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlOwnerInfoCard1.Location = new System.Drawing.Point(-1, 108);
            this.ctrlOwnerInfoCard1.Name = "ctrlOwnerInfoCard1";
            this.ctrlOwnerInfoCard1.Size = new System.Drawing.Size(1350, 507);
            this.ctrlOwnerInfoCard1.TabIndex = 32;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlFindOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlOwnerInfoCard1);
            this.Controls.Add(this.GBFilter);
            this.Name = "ctrlFindOwner";
            this.Size = new System.Drawing.Size(1349, 614);
            this.GBFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GBFilter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddPerson;
        private Guna.UI2.WinForms.Guna2Button btnFindePerson;
        private Guna.UI2.WinForms.Guna2ComboBox CbType;
        private Guna.UI2.WinForms.Guna2TextBox txtFinde;
        private ctrlOwnerInfoCard ctrlOwnerInfoCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

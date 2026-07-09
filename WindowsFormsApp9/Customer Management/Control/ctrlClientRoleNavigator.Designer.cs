namespace REMS.UI.Customer_Management.Control
{
    partial class ctrlClientRoleNavigator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInvestor = new Guna.UI2.WinForms.Guna2Button();
            this.btnSup_Owner = new Guna.UI2.WinForms.Guna2Button();
            this.btnOwner_alone = new Guna.UI2.WinForms.Guna2Button();
            this.btnOwner = new Guna.UI2.WinForms.Guna2Button();
            this.btnServicesProvider = new Guna.UI2.WinForms.Guna2Button();
            this.btnTenant = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInvestor);
            this.panel1.Controls.Add(this.btnSup_Owner);
            this.panel1.Controls.Add(this.btnOwner_alone);
            this.panel1.Controls.Add(this.btnOwner);
            this.panel1.Controls.Add(this.btnServicesProvider);
            this.panel1.Controls.Add(this.btnTenant);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 203);
            this.panel1.TabIndex = 0;
            // 
            // btnInvestor
            // 
            this.btnInvestor.BorderRadius = 5;
            this.btnInvestor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInvestor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInvestor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInvestor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInvestor.Enabled = false;
            this.btnInvestor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.btnInvestor.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInvestor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.btnInvestor.Image = global::REMS.UI.Properties.Resources.icons8_investor_35;
            this.btnInvestor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnInvestor.ImageSize = new System.Drawing.Size(60, 60);
            this.btnInvestor.Location = new System.Drawing.Point(18, 12);
            this.btnInvestor.Name = "btnInvestor";
            this.btnInvestor.Size = new System.Drawing.Size(261, 86);
            this.btnInvestor.TabIndex = 7;
            this.btnInvestor.Text = "مستثمر";
            this.btnInvestor.Click += new System.EventHandler(this.btnInvestor_Click);
            // 
            // btnSup_Owner
            // 
            this.btnSup_Owner.BorderRadius = 5;
            this.btnSup_Owner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSup_Owner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSup_Owner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSup_Owner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSup_Owner.Enabled = false;
            this.btnSup_Owner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.btnSup_Owner.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSup_Owner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.btnSup_Owner.Image = global::REMS.UI.Properties.Resources.icons8_landlord_35__1_;
            this.btnSup_Owner.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSup_Owner.ImageSize = new System.Drawing.Size(60, 60);
            this.btnSup_Owner.Location = new System.Drawing.Point(285, 12);
            this.btnSup_Owner.Name = "btnSup_Owner";
            this.btnSup_Owner.Size = new System.Drawing.Size(261, 86);
            this.btnSup_Owner.TabIndex = 8;
            this.btnSup_Owner.Text = "مالك فرعي";
            this.btnSup_Owner.Click += new System.EventHandler(this.btnSup_Owner_Click);
            // 
            // btnOwner_alone
            // 
            this.btnOwner_alone.BorderRadius = 5;
            this.btnOwner_alone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOwner_alone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOwner_alone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOwner_alone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOwner_alone.Enabled = false;
            this.btnOwner_alone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.btnOwner_alone.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOwner_alone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.btnOwner_alone.Image = global::REMS.UI.Properties.Resources.icons8_landlord_35__2_;
            this.btnOwner_alone.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnOwner_alone.ImageSize = new System.Drawing.Size(50, 50);
            this.btnOwner_alone.Location = new System.Drawing.Point(552, 104);
            this.btnOwner_alone.Name = "btnOwner_alone";
            this.btnOwner_alone.Size = new System.Drawing.Size(261, 86);
            this.btnOwner_alone.TabIndex = 9;
            this.btnOwner_alone.Text = "مالك وحده";
            this.btnOwner_alone.Click += new System.EventHandler(this.btnOwner_alone_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.BorderRadius = 5;
            this.btnOwner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOwner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOwner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOwner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOwner.Enabled = false;
            this.btnOwner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.btnOwner.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.btnOwner.Image = global::REMS.UI.Properties.Resources.icons8_landlord_35;
            this.btnOwner.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnOwner.ImageSize = new System.Drawing.Size(50, 50);
            this.btnOwner.Location = new System.Drawing.Point(552, 12);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(261, 86);
            this.btnOwner.TabIndex = 10;
            this.btnOwner.Text = "مالك";
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // btnServicesProvider
            // 
            this.btnServicesProvider.BorderRadius = 5;
            this.btnServicesProvider.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServicesProvider.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnServicesProvider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServicesProvider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnServicesProvider.Enabled = false;
            this.btnServicesProvider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.btnServicesProvider.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnServicesProvider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.btnServicesProvider.Image = global::REMS.UI.Properties.Resources.icons8_services_35;
            this.btnServicesProvider.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnServicesProvider.ImageSize = new System.Drawing.Size(50, 50);
            this.btnServicesProvider.Location = new System.Drawing.Point(819, 104);
            this.btnServicesProvider.Name = "btnServicesProvider";
            this.btnServicesProvider.Size = new System.Drawing.Size(261, 86);
            this.btnServicesProvider.TabIndex = 11;
            this.btnServicesProvider.Text = "مزود خدمات";
            this.btnServicesProvider.Click += new System.EventHandler(this.btnServicesProvider_Click);
            // 
            // btnTenant
            // 
            this.btnTenant.BorderRadius = 5;
            this.btnTenant.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTenant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTenant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTenant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTenant.Enabled = false;
            this.btnTenant.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.btnTenant.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTenant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.btnTenant.Image = global::REMS.UI.Properties.Resources.icons8_tenant_35__2_;
            this.btnTenant.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTenant.ImageSize = new System.Drawing.Size(50, 50);
            this.btnTenant.Location = new System.Drawing.Point(819, 12);
            this.btnTenant.Name = "btnTenant";
            this.btnTenant.Size = new System.Drawing.Size(261, 86);
            this.btnTenant.TabIndex = 12;
            this.btnTenant.Text = "مستاجر";
            this.btnTenant.Click += new System.EventHandler(this.btnTenant_Click);
            // 
            // ctrlClientRoleNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ctrlClientRoleNavigator";
            this.Size = new System.Drawing.Size(1095, 203);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnInvestor;
        private Guna.UI2.WinForms.Guna2Button btnSup_Owner;
        private Guna.UI2.WinForms.Guna2Button btnOwner_alone;
        private Guna.UI2.WinForms.Guna2Button btnOwner;
        private Guna.UI2.WinForms.Guna2Button btnServicesProvider;
        private Guna.UI2.WinForms.Guna2Button btnTenant;
    }
}

namespace REMS.UI.Customer_Management.Control
{
    partial class ctrlClientCardInfo
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
            this.ctrlCreatedByUser1 = new REMS.UI.Users_Management.Control.ctrlCreatedByUser();
            this.tglIsActive = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtCreationDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientTypeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.CountainerPanel = new System.Windows.Forms.Panel();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            guna2GroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.CountainerPanel.SuspendLayout();
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
            guna2GroupBox1.Location = new System.Drawing.Point(0, 1);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.Size = new System.Drawing.Size(1207, 477);
            guna2GroupBox1.TabIndex = 6;
            guna2GroupBox1.Text = "معلومات العميل";
            guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ctrlCreatedByUser1);
            this.panel2.Controls.Add(this.tglIsActive);
            this.panel2.Controls.Add(this.txtNotes);
            this.panel2.Controls.Add(this.txtCreationDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtClientTypeName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtClientID);
            this.panel2.Location = new System.Drawing.Point(-15, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 475);
            this.panel2.TabIndex = 18;
            // 
            // ctrlCreatedByUser1
            // 
            this.ctrlCreatedByUser1.AutoSize = true;
            this.ctrlCreatedByUser1.Location = new System.Drawing.Point(15, 101);
            this.ctrlCreatedByUser1.Name = "ctrlCreatedByUser1";
            this.ctrlCreatedByUser1.Size = new System.Drawing.Size(554, 260);
            this.ctrlCreatedByUser1.TabIndex = 32;
            // 
            // tglIsActive
            // 
            this.tglIsActive.Checked = true;
            this.tglIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(199)))), ((int)(((byte)(178)))));
            this.tglIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(199)))), ((int)(((byte)(178)))));
            this.tglIsActive.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglIsActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tglIsActive.Location = new System.Drawing.Point(91, 36);
            this.tglIsActive.Name = "tglIsActive";
            this.tglIsActive.Size = new System.Drawing.Size(49, 22);
            this.tglIsActive.TabIndex = 31;
            this.tglIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglIsActive.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglIsActive.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.White;
            this.txtNotes.Location = new System.Drawing.Point(620, 240);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(485, 122);
            this.txtNotes.TabIndex = 30;
            // 
            // txtCreationDate
            // 
            this.txtCreationDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreationDate.DefaultText = "";
            this.txtCreationDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCreationDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCreationDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreationDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreationDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCreationDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreationDate.Location = new System.Drawing.Point(620, 172);
            this.txtCreationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCreationDate.Name = "txtCreationDate";
            this.txtCreationDate.PlaceholderText = "";
            this.txtCreationDate.ReadOnly = true;
            this.txtCreationDate.SelectedText = "";
            this.txtCreationDate.Size = new System.Drawing.Size(485, 38);
            this.txtCreationDate.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.label5.Location = new System.Drawing.Point(171, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "فعّال";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.label4.Location = new System.Drawing.Point(1111, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "ملحوظات";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(1111, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "تاريخ الإنشاء";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.label2.Location = new System.Drawing.Point(1111, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "نوع العميل";
            // 
            // txtClientTypeName
            // 
            this.txtClientTypeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientTypeName.DefaultText = "";
            this.txtClientTypeName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClientTypeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClientTypeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientTypeName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientTypeName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientTypeName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClientTypeName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientTypeName.Location = new System.Drawing.Point(620, 101);
            this.txtClientTypeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClientTypeName.Name = "txtClientTypeName";
            this.txtClientTypeName.PlaceholderText = "";
            this.txtClientTypeName.ReadOnly = true;
            this.txtClientTypeName.SelectedText = "";
            this.txtClientTypeName.Size = new System.Drawing.Size(485, 38);
            this.txtClientTypeName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(1111, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "معرِّف العميل";
            // 
            // txtClientID
            // 
            this.txtClientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientID.DefaultText = "?????";
            this.txtClientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientID.Location = new System.Drawing.Point(263, 29);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.PlaceholderText = "";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.SelectedText = "";
            this.txtClientID.Size = new System.Drawing.Size(842, 38);
            this.txtClientID.TabIndex = 12;
            // 
            // CountainerPanel
            // 
            this.CountainerPanel.BackColor = System.Drawing.Color.White;
            this.CountainerPanel.Controls.Add(guna2GroupBox1);
            this.CountainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountainerPanel.Location = new System.Drawing.Point(0, 0);
            this.CountainerPanel.Name = "CountainerPanel";
            this.CountainerPanel.Size = new System.Drawing.Size(1207, 430);
            this.CountainerPanel.TabIndex = 0;
            // 
            // ctrlClientCardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CountainerPanel);
            this.Name = "ctrlClientCardInfo";
            this.Size = new System.Drawing.Size(1207, 430);
            guna2GroupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CountainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CountainerPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtClientID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtClientTypeName;
        private System.Windows.Forms.TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtCreationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tglIsActive;
        private System.Windows.Forms.Label label5;
        private Users_Management.Control.ctrlCreatedByUser ctrlCreatedByUser1;
    }
}

namespace REMS.UI.RealEstateAndUnits.Control
{
    partial class ctrlPropertyCardBasicInfoWhithFilter
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
            this.Countainer = new System.Windows.Forms.Panel();
            this.ctrlpanel = new System.Windows.Forms.Panel();
            this.ctrlPropertyCardBasicInfo1 = new REMS.UI.RealEstateAndUnits.Control.ctrlPropertyCardBasicInfo();
            this.FilterCountainer = new System.Windows.Forms.Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Countainer.SuspendLayout();
            this.ctrlpanel.SuspendLayout();
            this.FilterCountainer.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Countainer
            // 
            this.Countainer.Controls.Add(this.ctrlpanel);
            this.Countainer.Controls.Add(this.FilterCountainer);
            this.Countainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Countainer.Location = new System.Drawing.Point(0, 0);
            this.Countainer.Name = "Countainer";
            this.Countainer.Size = new System.Drawing.Size(1462, 805);
            this.Countainer.TabIndex = 0;
            // 
            // ctrlpanel
            // 
            this.ctrlpanel.BackColor = System.Drawing.Color.White;
            this.ctrlpanel.Controls.Add(this.ctrlPropertyCardBasicInfo1);
            this.ctrlpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlpanel.Location = new System.Drawing.Point(0, 119);
            this.ctrlpanel.Name = "ctrlpanel";
            this.ctrlpanel.Size = new System.Drawing.Size(1462, 686);
            this.ctrlpanel.TabIndex = 1;
            // 
            // ctrlPropertyCardBasicInfo1
            // 
            this.ctrlPropertyCardBasicInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlPropertyCardBasicInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPropertyCardBasicInfo1.Name = "ctrlPropertyCardBasicInfo1";
            this.ctrlPropertyCardBasicInfo1.Size = new System.Drawing.Size(1462, 710);
            this.ctrlPropertyCardBasicInfo1.TabIndex = 0;
            // 
            // FilterCountainer
            // 
            this.FilterCountainer.Controls.Add(this.guna2GroupBox1);
            this.FilterCountainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterCountainer.Location = new System.Drawing.Point(0, 0);
            this.FilterCountainer.Name = "FilterCountainer";
            this.FilterCountainer.Size = new System.Drawing.Size(1462, 119);
            this.FilterCountainer.TabIndex = 0;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.button2);
            this.guna2GroupBox1.Controls.Add(this.btnSearch);
            this.guna2GroupBox1.Controls.Add(this.txtFilterValue);
            this.guna2GroupBox1.Controls.Add(this.cbFilterBy);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1462, 119);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "ابحث";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Image = global::REMS.UI.Properties.Resources.icons8_create_document_442;
            this.button2.Location = new System.Drawing.Point(1398, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 61);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::REMS.UI.Properties.Resources.icons8_search_442;
            this.btnSearch.Location = new System.Drawing.Point(1331, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 61);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Location = new System.Drawing.Point(1076, 60);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PlaceholderText = "";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(249, 45);
            this.txtFilterValue.TabIndex = 0;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Location = new System.Drawing.Point(874, 60);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(196, 36);
            this.cbFilterBy.TabIndex = 1;
            // 
            // ctrlPropertyCardBasicInfoWhithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Countainer);
            this.Name = "ctrlPropertyCardBasicInfoWhithFilter";
            this.Size = new System.Drawing.Size(1462, 805);
            this.Countainer.ResumeLayout(false);
            this.ctrlpanel.ResumeLayout(false);
            this.FilterCountainer.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Countainer;
        private System.Windows.Forms.Panel FilterCountainer;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Panel ctrlpanel;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button2;
        private ctrlPropertyCardBasicInfo ctrlPropertyCardBasicInfo1;
    }
}

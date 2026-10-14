namespace REMS.UI.RealEstateAndUnits
{
    partial class frmFindPropertyBasicInfo
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
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabProperty = new System.Windows.Forms.TabPage();
            this.ctrlPropertyCardBasicInfoWhithFilter1 = new REMS.UI.RealEstateAndUnits.Control.ctrlPropertyCardBasicInfoWhithFilter();
            this.tabUnits = new System.Windows.Forms.TabPage();
            this.UnitsContainer = new System.Windows.Forms.Panel();
            this.ctrlUnitsListView1 = new REMS.UI.Client_Roles.UnitOwner.Control.ctrlPropertyUnitsSelector();
            this.btnCompleated = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.tabProperty.SuspendLayout();
            this.tabUnits.SuspendLayout();
            this.UnitsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2TabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1477, 871);
            this.panel1.TabIndex = 0;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabProperty);
            this.guna2TabControl1.Controls.Add(this.tabUnits);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1477, 871);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.Transparent;
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.guna2TabControl1.SelectedIndexChanged += new System.EventHandler(this.guna2TabControl1_SelectedIndexChanged);
            // 
            // tabProperty
            // 
            this.tabProperty.Controls.Add(this.ctrlPropertyCardBasicInfoWhithFilter1);
            this.tabProperty.Location = new System.Drawing.Point(4, 44);
            this.tabProperty.Name = "tabProperty";
            this.tabProperty.Padding = new System.Windows.Forms.Padding(3);
            this.tabProperty.Size = new System.Drawing.Size(1469, 823);
            this.tabProperty.TabIndex = 0;
            this.tabProperty.Text = "العقار";
            this.tabProperty.UseVisualStyleBackColor = true;
            // 
            // ctrlPropertyCardBasicInfoWhithFilter1
            // 
            this.ctrlPropertyCardBasicInfoWhithFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPropertyCardBasicInfoWhithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPropertyCardBasicInfoWhithFilter1.Name = "ctrlPropertyCardBasicInfoWhithFilter1";
            this.ctrlPropertyCardBasicInfoWhithFilter1.Size = new System.Drawing.Size(1463, 817);
            this.ctrlPropertyCardBasicInfoWhithFilter1.TabIndex = 0;
            // 
            // tabUnits
            // 
            this.tabUnits.Controls.Add(this.UnitsContainer);
            this.tabUnits.Location = new System.Drawing.Point(4, 44);
            this.tabUnits.Name = "tabUnits";
            this.tabUnits.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnits.Size = new System.Drawing.Size(1469, 823);
            this.tabUnits.TabIndex = 1;
            this.tabUnits.Text = "الوحدات";
            this.tabUnits.UseVisualStyleBackColor = true;
            // 
            // UnitsContainer
            // 
            this.UnitsContainer.BackColor = System.Drawing.Color.White;
            this.UnitsContainer.Controls.Add(this.ctrlUnitsListView1);
            this.UnitsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitsContainer.Location = new System.Drawing.Point(3, 3);
            this.UnitsContainer.Name = "UnitsContainer";
            this.UnitsContainer.Size = new System.Drawing.Size(1463, 817);
            this.UnitsContainer.TabIndex = 0;
            // 
            // ctrlUnitsListView1
            // 
            this.ctrlUnitsListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlUnitsListView1.Location = new System.Drawing.Point(0, 0);
            this.ctrlUnitsListView1.Name = "ctrlUnitsListView1";
            this.ctrlUnitsListView1.Size = new System.Drawing.Size(1463, 817);
            this.ctrlUnitsListView1.TabIndex = 0;
            // 
            // btnCompleated
            // 
            this.btnCompleated.BorderRadius = 5;
            this.btnCompleated.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompleated.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompleated.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompleated.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompleated.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCompleated.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.btnCompleated.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.btnCompleated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.btnCompleated.Image = global::REMS.UI.Properties.Resources.icons8_arrow_30__1_;
            this.btnCompleated.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCompleated.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCompleated.Location = new System.Drawing.Point(0, 869);
            this.btnCompleated.Name = "btnCompleated";
            this.btnCompleated.Size = new System.Drawing.Size(1477, 46);
            this.btnCompleated.TabIndex = 5;
            this.btnCompleated.Text = "تم";
            this.btnCompleated.Click += new System.EventHandler(this.btnCompleated_Click);
            // 
            // frmFindPropertyBasicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1477, 915);
            this.Controls.Add(this.btnCompleated);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFindPropertyBasicInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFindPropertyBasicInfo";
            this.panel1.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabProperty.ResumeLayout(false);
            this.tabUnits.ResumeLayout(false);
            this.UnitsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnCompleated;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabProperty;
        private System.Windows.Forms.TabPage tabUnits;
        private Control.ctrlPropertyCardBasicInfoWhithFilter ctrlPropertyCardBasicInfoWhithFilter1;
        private System.Windows.Forms.Panel UnitsContainer;
        private Client_Roles.UnitOwner.Control.ctrlPropertyUnitsSelector ctrlUnitsListView1;
    }
}
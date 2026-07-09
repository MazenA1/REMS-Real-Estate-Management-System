namespace REMS.UI.Client_Roles.Owner
{
    partial class frmFindOwner
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
            this.btnChoose = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlFindOwnerWhithFilter1 = new REMS.UI.Client_Roles.Owner.Control.ctrlFindOwnerWhithFilter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ctrlFindOwnerWhithFilter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 674);
            this.panel1.TabIndex = 0;
            // 
            // btnChoose
            // 
            this.btnChoose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.btnChoose.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Location = new System.Drawing.Point(0, 622);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(1351, 45);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "اختيار";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // ctrlFindOwnerWhithFilter1
            // 
            this.ctrlFindOwnerWhithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlFindOwnerWhithFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlFindOwnerWhithFilter1.FilterEnabled = true;
            this.ctrlFindOwnerWhithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlFindOwnerWhithFilter1.Name = "ctrlFindOwnerWhithFilter1";
            this.ctrlFindOwnerWhithFilter1.Size = new System.Drawing.Size(1351, 616);
            this.ctrlFindOwnerWhithFilter1.TabIndex = 0;
            // 
            // frmFindOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1351, 674);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFindOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFindOwner";
            this.Load += new System.EventHandler(this.frmFindOwner_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnChoose;
        private Control.ctrlFindOwnerWhithFilter ctrlFindOwnerWhithFilter1;
    }
}
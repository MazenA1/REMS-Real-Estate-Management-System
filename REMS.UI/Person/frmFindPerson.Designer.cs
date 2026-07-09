namespace REMS.UI.Person
{
    partial class frmFindPerson
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
            this.ctrlPersonCardWhithFilter1 = new REMS.UI.Person.Control.ctrlPersonCardWhithFilter();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ctrlPersonCardWhithFilter1
            // 
            this.ctrlPersonCardWhithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWhithFilter1.Location = new System.Drawing.Point(0, -1);
            this.ctrlPersonCardWhithFilter1.Name = "ctrlPersonCardWhithFilter1";
            this.ctrlPersonCardWhithFilter1.Size = new System.Drawing.Size(1208, 583);
            this.ctrlPersonCardWhithFilter1.TabIndex = 0;
            // 
            // guna2Button7
            // 
            this.guna2Button7.BorderRadius = 5;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(126)))));
            this.guna2Button7.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.guna2Button7.Image = global::REMS.UI.Properties.Resources.icons8_arrow_30__1_;
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button7.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button7.Location = new System.Drawing.Point(12, 588);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(1183, 45);
            this.guna2Button7.TabIndex = 3;
            this.guna2Button7.Text = "التالي";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1207, 636);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.ctrlPersonCardWhithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFindPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFindPerson";
            this.ResumeLayout(false);

        }

        #endregion

        private Control.ctrlPersonCardWhithFilter ctrlPersonCardWhithFilter1;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
    }
}
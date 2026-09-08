namespace REMS.UI.Client_Roles.UnitOwner
{
    partial class frmUnitsListView
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
            this.Countainer = new System.Windows.Forms.Panel();
            this.ctrlUnitsListView1 = new REMS.UI.Client_Roles.UnitOwner.Control.ctrlPropertyUnitsSelector();
            this.Countainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Countainer
            // 
            this.Countainer.BackColor = System.Drawing.Color.White;
            this.Countainer.Controls.Add(this.ctrlUnitsListView1);
            this.Countainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Countainer.Location = new System.Drawing.Point(0, 0);
            this.Countainer.Name = "Countainer";
            this.Countainer.Size = new System.Drawing.Size(1448, 672);
            this.Countainer.TabIndex = 0;
            // 
            // ctrlUnitsListView1
            // 
            this.ctrlUnitsListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlUnitsListView1.Location = new System.Drawing.Point(0, 0);
            this.ctrlUnitsListView1.Name = "ctrlUnitsListView1";
            this.ctrlUnitsListView1.Size = new System.Drawing.Size(1448, 672);
            this.ctrlUnitsListView1.TabIndex = 0;
            // 
            // frmUnitsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 672);
            this.Controls.Add(this.Countainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUnitsListView";
            this.Text = "frmUnitsListView";
            this.Countainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Countainer;
        private Control.ctrlPropertyUnitsSelector ctrlUnitsListView1;
    }
}
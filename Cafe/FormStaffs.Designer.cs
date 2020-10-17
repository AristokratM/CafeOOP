namespace Cafe
{
    partial class FormStaffs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaffs));
            this.btnStaffInfo = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.lblAllStaffs = new System.Windows.Forms.Label();
            this.lbStaffs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStaffInfo
            // 
            resources.ApplyResources(this.btnStaffInfo, "btnStaffInfo");
            this.btnStaffInfo.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnStaffInfo.Name = "btnStaffInfo";
            this.btnStaffInfo.UseVisualStyleBackColor = false;
            // 
            // btnAddStaff
            // 
            resources.ApplyResources(this.btnAddStaff, "btnAddStaff");
            this.btnAddStaff.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            // 
            // lblAllStaffs
            // 
            resources.ApplyResources(this.lblAllStaffs, "lblAllStaffs");
            this.lblAllStaffs.BackColor = System.Drawing.Color.Transparent;
            this.lblAllStaffs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAllStaffs.Name = "lblAllStaffs";
            // 
            // lbStaffs
            // 
            resources.ApplyResources(this.lbStaffs, "lbStaffs");
            this.lbStaffs.FormattingEnabled = true;
            this.lbStaffs.Name = "lbStaffs";
            // 
            // FormStaffs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStaffInfo);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.lblAllStaffs);
            this.Controls.Add(this.lbStaffs);
            this.Name = "FormStaffs";
            this.Load += new System.EventHandler(this.FormStaffs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStaffInfo;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Label lblAllStaffs;
        private System.Windows.Forms.ListBox lbStaffs;
    }
}
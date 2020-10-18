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
            this.lblAllStaffs = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.lbStaffs = new System.Windows.Forms.ListBox();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnRemoveStaff = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStaffInfo
            // 
            this.btnStaffInfo.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnStaffInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnStaffInfo, "btnStaffInfo");
            this.btnStaffInfo.Name = "btnStaffInfo";
            this.btnStaffInfo.UseVisualStyleBackColor = false;
            this.btnStaffInfo.Click += new System.EventHandler(this.btnStaffInfo_Click);
            // 
            // lblAllStaffs
            // 
            resources.ApplyResources(this.lblAllStaffs, "lblAllStaffs");
            this.lblAllStaffs.BackColor = System.Drawing.Color.Transparent;
            this.lblAllStaffs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAllStaffs.Name = "lblAllStaffs";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.DarkSalmon;
            resources.ApplyResources(this.btnAddStaff, "btnAddStaff");
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // lbStaffs
            // 
            this.lbStaffs.FormattingEnabled = true;
            resources.ApplyResources(this.lbStaffs, "lbStaffs");
            this.lbStaffs.Name = "lbStaffs";
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.BackColor = System.Drawing.Color.DarkSalmon;
            resources.ApplyResources(this.btnEditStaff, "btnEditStaff");
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.UseVisualStyleBackColor = false;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnRemoveStaff
            // 
            this.btnRemoveStaff.BackColor = System.Drawing.Color.DarkSalmon;
            resources.ApplyResources(this.btnRemoveStaff, "btnRemoveStaff");
            this.btnRemoveStaff.Name = "btnRemoveStaff";
            this.btnRemoveStaff.UseVisualStyleBackColor = false;
            this.btnRemoveStaff.Click += new System.EventHandler(this.btnRemoveStaff_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Moccasin;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormStaffs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveStaff);
            this.Controls.Add(this.btnEditStaff);
            this.Controls.Add(this.btnStaffInfo);
            this.Controls.Add(this.lblAllStaffs);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.lbStaffs);
            this.Name = "FormStaffs";
            this.Load += new System.EventHandler(this.FormStaffs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStaffInfo;
        private System.Windows.Forms.Label lblAllStaffs;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.ListBox lbStaffs;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Button btnRemoveStaff;
        private System.Windows.Forms.Button btnExit;
    }
}
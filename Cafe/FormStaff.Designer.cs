namespace Cafe
{
    partial class FormStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaff));
            this.rtbStaffInfo = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStaffInfo = new System.Windows.Forms.Label();
            this.lblStaffDescription = new System.Windows.Forms.Label();
            this.tbStaffDescription = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbStaffInfo
            // 
            this.rtbStaffInfo.Location = new System.Drawing.Point(406, 103);
            this.rtbStaffInfo.Name = "rtbStaffInfo";
            this.rtbStaffInfo.Size = new System.Drawing.Size(481, 236);
            this.rtbStaffInfo.TabIndex = 0;
            this.rtbStaffInfo.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Moccasin;
            this.btnExit.Location = new System.Drawing.Point(645, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 27);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStaffInfo
            // 
            this.lblStaffInfo.AutoSize = true;
            this.lblStaffInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStaffInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStaffInfo.Location = new System.Drawing.Point(583, 54);
            this.lblStaffInfo.Name = "lblStaffInfo";
            this.lblStaffInfo.Size = new System.Drawing.Size(128, 32);
            this.lblStaffInfo.TabIndex = 3;
            this.lblStaffInfo.Text = "Staff Info";
            // 
            // lblStaffDescription
            // 
            this.lblStaffDescription.AutoSize = true;
            this.lblStaffDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStaffDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStaffDescription.Location = new System.Drawing.Point(13, 88);
            this.lblStaffDescription.Name = "lblStaffDescription";
            this.lblStaffDescription.Size = new System.Drawing.Size(104, 24);
            this.lblStaffDescription.TabIndex = 33;
            this.lblStaffDescription.Text = "Description";
            // 
            // tbStaffDescription
            // 
            this.tbStaffDescription.Location = new System.Drawing.Point(132, 88);
            this.tbStaffDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStaffDescription.Name = "tbStaffDescription";
            this.tbStaffDescription.Size = new System.Drawing.Size(100, 22);
            this.tbStaffDescription.TabIndex = 32;
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStaffName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStaffName.Location = new System.Drawing.Point(13, 59);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(61, 24);
            this.lblStaffName.TabIndex = 31;
            this.lblStaffName.Text = "Name";
            // 
            // tbStaffName
            // 
            this.tbStaffName.Location = new System.Drawing.Point(132, 57);
            this.tbStaffName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.Size = new System.Drawing.Size(100, 22);
            this.tbStaffName.TabIndex = 30;
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnApplyChanges.Location = new System.Drawing.Point(107, 326);
            this.btnApplyChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(125, 36);
            this.btnApplyChanges.TabIndex = 51;
            this.btnApplyChanges.Text = "Apply Changes";
            this.btnApplyChanges.UseVisualStyleBackColor = false;
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 507);
            this.Controls.Add(this.btnApplyChanges);
            this.Controls.Add(this.lblStaffDescription);
            this.Controls.Add(this.tbStaffDescription);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.tbStaffName);
            this.Controls.Add(this.lblStaffInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtbStaffInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStaff";
            this.Text = "Staff Info";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbStaffInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStaffInfo;
        private System.Windows.Forms.Label lblStaffDescription;
        private System.Windows.Forms.TextBox tbStaffDescription;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.Button btnApplyChanges;
    }
}
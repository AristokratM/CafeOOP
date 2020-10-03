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
            this.lblFormInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbStaffInfo
            // 
            this.rtbStaffInfo.Location = new System.Drawing.Point(136, 98);
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
            // lblFormInfo
            // 
            this.lblFormInfo.AutoSize = true;
            this.lblFormInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblFormInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormInfo.Location = new System.Drawing.Point(313, 49);
            this.lblFormInfo.Name = "lblFormInfo";
            this.lblFormInfo.Size = new System.Drawing.Size(128, 32);
            this.lblFormInfo.TabIndex = 3;
            this.lblFormInfo.Text = "Staff Info";
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFormInfo);
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
        private System.Windows.Forms.Label lblFormInfo;
    }
}
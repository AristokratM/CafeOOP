namespace Cafe
{
    partial class FormWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorker));
            this.lblWorkerInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.rtbWorkerInfo = new System.Windows.Forms.RichTextBox();
            this.cbWorkerStaff = new System.Windows.Forms.ComboBox();
            this.lblWorkerStaff = new System.Windows.Forms.Label();
            this.tbWorkerSalary = new System.Windows.Forms.TextBox();
            this.lblWorkerSalary = new System.Windows.Forms.Label();
            this.lblWorkerGender = new System.Windows.Forms.Label();
            this.lblWorkerBirthday = new System.Windows.Forms.Label();
            this.lblWorkerPName = new System.Windows.Forms.Label();
            this.lblWorkerSName = new System.Windows.Forms.Label();
            this.cbWorkerGender = new System.Windows.Forms.ComboBox();
            this.dtpWorkerBirthday = new System.Windows.Forms.DateTimePicker();
            this.tbWorkerPName = new System.Windows.Forms.TextBox();
            this.tbWorkerSName = new System.Windows.Forms.TextBox();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.tbWorkerName = new System.Windows.Forms.TextBox();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWorkerInfo
            // 
            this.lblWorkerInfo.AutoSize = true;
            this.lblWorkerInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWorkerInfo.Location = new System.Drawing.Point(620, 44);
            this.lblWorkerInfo.Name = "lblWorkerInfo";
            this.lblWorkerInfo.Size = new System.Drawing.Size(159, 32);
            this.lblWorkerInfo.TabIndex = 6;
            this.lblWorkerInfo.Text = "Worker Info";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Moccasin;
            this.btnExit.Location = new System.Drawing.Point(684, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtbWorkerInfo
            // 
            this.rtbWorkerInfo.Location = new System.Drawing.Point(443, 93);
            this.rtbWorkerInfo.Name = "rtbWorkerInfo";
            this.rtbWorkerInfo.Size = new System.Drawing.Size(481, 236);
            this.rtbWorkerInfo.TabIndex = 4;
            this.rtbWorkerInfo.Text = "";
            // 
            // cbWorkerStaff
            // 
            this.cbWorkerStaff.FormattingEnabled = true;
            this.cbWorkerStaff.Location = new System.Drawing.Point(154, 259);
            this.cbWorkerStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbWorkerStaff.Name = "cbWorkerStaff";
            this.cbWorkerStaff.Size = new System.Drawing.Size(121, 24);
            this.cbWorkerStaff.TabIndex = 49;
            // 
            // lblWorkerStaff
            // 
            this.lblWorkerStaff.AutoSize = true;
            this.lblWorkerStaff.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerStaff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWorkerStaff.Location = new System.Drawing.Point(26, 256);
            this.lblWorkerStaff.Name = "lblWorkerStaff";
            this.lblWorkerStaff.Size = new System.Drawing.Size(44, 24);
            this.lblWorkerStaff.TabIndex = 48;
            this.lblWorkerStaff.Text = "Staff";
            // 
            // tbWorkerSalary
            // 
            this.tbWorkerSalary.Location = new System.Drawing.Point(154, 307);
            this.tbWorkerSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWorkerSalary.Name = "tbWorkerSalary";
            this.tbWorkerSalary.Size = new System.Drawing.Size(121, 22);
            this.tbWorkerSalary.TabIndex = 47;
            // 
            // lblWorkerSalary
            // 
            this.lblWorkerSalary.AutoSize = true;
            this.lblWorkerSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerSalary.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWorkerSalary.Location = new System.Drawing.Point(26, 305);
            this.lblWorkerSalary.Name = "lblWorkerSalary";
            this.lblWorkerSalary.Size = new System.Drawing.Size(61, 24);
            this.lblWorkerSalary.TabIndex = 46;
            this.lblWorkerSalary.Text = "Salary";
            // 
            // lblWorkerGender
            // 
            this.lblWorkerGender.AutoSize = true;
            this.lblWorkerGender.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerGender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWorkerGender.Location = new System.Drawing.Point(26, 205);
            this.lblWorkerGender.Name = "lblWorkerGender";
            this.lblWorkerGender.Size = new System.Drawing.Size(74, 24);
            this.lblWorkerGender.TabIndex = 45;
            this.lblWorkerGender.Text = "Gender";
            // 
            // lblWorkerBirthday
            // 
            this.lblWorkerBirthday.AutoSize = true;
            this.lblWorkerBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerBirthday.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWorkerBirthday.Location = new System.Drawing.Point(26, 154);
            this.lblWorkerBirthday.Name = "lblWorkerBirthday";
            this.lblWorkerBirthday.Size = new System.Drawing.Size(77, 24);
            this.lblWorkerBirthday.TabIndex = 44;
            this.lblWorkerBirthday.Text = "Birthday";
            // 
            // lblWorkerPName
            // 
            this.lblWorkerPName.AutoSize = true;
            this.lblWorkerPName.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerPName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWorkerPName.Location = new System.Drawing.Point(26, 116);
            this.lblWorkerPName.Name = "lblWorkerPName";
            this.lblWorkerPName.Size = new System.Drawing.Size(117, 24);
            this.lblWorkerPName.TabIndex = 43;
            this.lblWorkerPName.Text = "Parent name";
            // 
            // lblWorkerSName
            // 
            this.lblWorkerSName.AutoSize = true;
            this.lblWorkerSName.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerSName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWorkerSName.Location = new System.Drawing.Point(26, 79);
            this.lblWorkerSName.Name = "lblWorkerSName";
            this.lblWorkerSName.Size = new System.Drawing.Size(87, 24);
            this.lblWorkerSName.TabIndex = 42;
            this.lblWorkerSName.Text = "Surname";
            // 
            // cbWorkerGender
            // 
            this.cbWorkerGender.FormattingEnabled = true;
            this.cbWorkerGender.Location = new System.Drawing.Point(154, 206);
            this.cbWorkerGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbWorkerGender.Name = "cbWorkerGender";
            this.cbWorkerGender.Size = new System.Drawing.Size(121, 24);
            this.cbWorkerGender.TabIndex = 41;
            // 
            // dtpWorkerBirthday
            // 
            this.dtpWorkerBirthday.Location = new System.Drawing.Point(154, 152);
            this.dtpWorkerBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpWorkerBirthday.Name = "dtpWorkerBirthday";
            this.dtpWorkerBirthday.Size = new System.Drawing.Size(200, 22);
            this.dtpWorkerBirthday.TabIndex = 40;
            // 
            // tbWorkerPName
            // 
            this.tbWorkerPName.Location = new System.Drawing.Point(154, 114);
            this.tbWorkerPName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWorkerPName.Name = "tbWorkerPName";
            this.tbWorkerPName.Size = new System.Drawing.Size(100, 22);
            this.tbWorkerPName.TabIndex = 39;
            // 
            // tbWorkerSName
            // 
            this.tbWorkerSName.Location = new System.Drawing.Point(154, 77);
            this.tbWorkerSName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWorkerSName.Name = "tbWorkerSName";
            this.tbWorkerSName.Size = new System.Drawing.Size(100, 22);
            this.tbWorkerSName.TabIndex = 38;
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWorkerName.Location = new System.Drawing.Point(26, 47);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(61, 24);
            this.lblWorkerName.TabIndex = 37;
            this.lblWorkerName.Text = "Name";
            // 
            // tbWorkerName
            // 
            this.tbWorkerName.Location = new System.Drawing.Point(154, 40);
            this.tbWorkerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWorkerName.Name = "tbWorkerName";
            this.tbWorkerName.Size = new System.Drawing.Size(100, 22);
            this.tbWorkerName.TabIndex = 36;
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnApplyChanges.Location = new System.Drawing.Point(141, 378);
            this.btnApplyChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(125, 36);
            this.btnApplyChanges.TabIndex = 50;
            this.btnApplyChanges.Text = "Apply Changes";
            this.btnApplyChanges.UseVisualStyleBackColor = false;
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 505);
            this.Controls.Add(this.btnApplyChanges);
            this.Controls.Add(this.cbWorkerStaff);
            this.Controls.Add(this.lblWorkerStaff);
            this.Controls.Add(this.tbWorkerSalary);
            this.Controls.Add(this.lblWorkerSalary);
            this.Controls.Add(this.lblWorkerGender);
            this.Controls.Add(this.lblWorkerBirthday);
            this.Controls.Add(this.lblWorkerPName);
            this.Controls.Add(this.lblWorkerSName);
            this.Controls.Add(this.cbWorkerGender);
            this.Controls.Add(this.dtpWorkerBirthday);
            this.Controls.Add(this.tbWorkerPName);
            this.Controls.Add(this.tbWorkerSName);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.tbWorkerName);
            this.Controls.Add(this.lblWorkerInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtbWorkerInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWorker";
            this.Text = "Worker Info";
            this.Load += new System.EventHandler(this.FormWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWorkerInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbWorkerInfo;
        private System.Windows.Forms.ComboBox cbWorkerStaff;
        private System.Windows.Forms.Label lblWorkerStaff;
        private System.Windows.Forms.TextBox tbWorkerSalary;
        private System.Windows.Forms.Label lblWorkerSalary;
        private System.Windows.Forms.Label lblWorkerGender;
        private System.Windows.Forms.Label lblWorkerBirthday;
        private System.Windows.Forms.Label lblWorkerPName;
        private System.Windows.Forms.Label lblWorkerSName;
        private System.Windows.Forms.ComboBox cbWorkerGender;
        private System.Windows.Forms.DateTimePicker dtpWorkerBirthday;
        private System.Windows.Forms.TextBox tbWorkerPName;
        private System.Windows.Forms.TextBox tbWorkerSName;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.TextBox tbWorkerName;
        private System.Windows.Forms.Button btnApplyChanges;
    }
}
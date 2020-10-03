namespace Cafe
{
    partial class FormWorkers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkers));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAllWorkers = new System.Windows.Forms.Label();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.tbWorkerName = new System.Windows.Forms.TextBox();
            this.lbWorkers = new System.Windows.Forms.ListBox();
            this.tbWorkerSName = new System.Windows.Forms.TextBox();
            this.tbWorkerPName = new System.Windows.Forms.TextBox();
            this.dtpWorkerBirthday = new System.Windows.Forms.DateTimePicker();
            this.cbWorkerGender = new System.Windows.Forms.ComboBox();
            this.lblWorkerSName = new System.Windows.Forms.Label();
            this.lblWorkerPName = new System.Windows.Forms.Label();
            this.lblWorkerBirthday = new System.Windows.Forms.Label();
            this.lblWorkerGender = new System.Windows.Forms.Label();
            this.lbStaffs = new System.Windows.Forms.ListBox();
            this.lblAllStaffs = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.lblStaffDescription = new System.Windows.Forms.Label();
            this.tbStaffDescription = new System.Windows.Forms.TextBox();
            this.btnStaffInfo = new System.Windows.Forms.Button();
            this.btnWorkerInfo = new System.Windows.Forms.Button();
            this.lblWorkerSalary = new System.Windows.Forms.Label();
            this.tbWorkerSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Moccasin;
            this.btnExit.Location = new System.Drawing.Point(878, 431);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 27);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAllWorkers
            // 
            this.lblAllWorkers.AutoSize = true;
            this.lblAllWorkers.BackColor = System.Drawing.Color.Transparent;
            this.lblAllWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllWorkers.Location = new System.Drawing.Point(859, 26);
            this.lblAllWorkers.Name = "lblAllWorkers";
            this.lblAllWorkers.Size = new System.Drawing.Size(171, 20);
            this.lblAllWorkers.TabIndex = 13;
            this.lblAllWorkers.Text = "Список працівників";
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerName.Location = new System.Drawing.Point(494, 28);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(53, 20);
            this.lblWorkerName.TabIndex = 12;
            this.lblWorkerName.Text = "Name";
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAddWorker.Location = new System.Drawing.Point(615, 295);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(126, 36);
            this.btnAddWorker.TabIndex = 11;
            this.btnAddWorker.Text = "Add Worker";
            this.btnAddWorker.UseVisualStyleBackColor = false;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // tbWorkerName
            // 
            this.tbWorkerName.Location = new System.Drawing.Point(621, 21);
            this.tbWorkerName.Name = "tbWorkerName";
            this.tbWorkerName.Size = new System.Drawing.Size(100, 22);
            this.tbWorkerName.TabIndex = 10;
            // 
            // lbWorkers
            // 
            this.lbWorkers.FormattingEnabled = true;
            this.lbWorkers.ItemHeight = 16;
            this.lbWorkers.Location = new System.Drawing.Point(862, 58);
            this.lbWorkers.Name = "lbWorkers";
            this.lbWorkers.Size = new System.Drawing.Size(168, 148);
            this.lbWorkers.TabIndex = 9;
            // 
            // tbWorkerSName
            // 
            this.tbWorkerSName.Location = new System.Drawing.Point(621, 58);
            this.tbWorkerSName.Name = "tbWorkerSName";
            this.tbWorkerSName.Size = new System.Drawing.Size(100, 22);
            this.tbWorkerSName.TabIndex = 14;
            // 
            // tbWorkerPName
            // 
            this.tbWorkerPName.Location = new System.Drawing.Point(621, 95);
            this.tbWorkerPName.Name = "tbWorkerPName";
            this.tbWorkerPName.Size = new System.Drawing.Size(100, 22);
            this.tbWorkerPName.TabIndex = 15;
            // 
            // dtpWorkerBirthday
            // 
            this.dtpWorkerBirthday.Location = new System.Drawing.Point(621, 133);
            this.dtpWorkerBirthday.Name = "dtpWorkerBirthday";
            this.dtpWorkerBirthday.Size = new System.Drawing.Size(200, 22);
            this.dtpWorkerBirthday.TabIndex = 16;
            // 
            // cbWorkerGender
            // 
            this.cbWorkerGender.FormattingEnabled = true;
            this.cbWorkerGender.Location = new System.Drawing.Point(621, 187);
            this.cbWorkerGender.Name = "cbWorkerGender";
            this.cbWorkerGender.Size = new System.Drawing.Size(121, 24);
            this.cbWorkerGender.TabIndex = 18;
            // 
            // lblWorkerSName
            // 
            this.lblWorkerSName.AutoSize = true;
            this.lblWorkerSName.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerSName.Location = new System.Drawing.Point(494, 60);
            this.lblWorkerSName.Name = "lblWorkerSName";
            this.lblWorkerSName.Size = new System.Drawing.Size(76, 20);
            this.lblWorkerSName.TabIndex = 19;
            this.lblWorkerSName.Text = "Surname";
            // 
            // lblWorkerPName
            // 
            this.lblWorkerPName.AutoSize = true;
            this.lblWorkerPName.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerPName.Location = new System.Drawing.Point(494, 97);
            this.lblWorkerPName.Name = "lblWorkerPName";
            this.lblWorkerPName.Size = new System.Drawing.Size(104, 20);
            this.lblWorkerPName.TabIndex = 20;
            this.lblWorkerPName.Text = "Parent name";
            // 
            // lblWorkerBirthday
            // 
            this.lblWorkerBirthday.AutoSize = true;
            this.lblWorkerBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerBirthday.Location = new System.Drawing.Point(494, 135);
            this.lblWorkerBirthday.Name = "lblWorkerBirthday";
            this.lblWorkerBirthday.Size = new System.Drawing.Size(71, 20);
            this.lblWorkerBirthday.TabIndex = 21;
            this.lblWorkerBirthday.Text = "Birthday";
            // 
            // lblWorkerGender
            // 
            this.lblWorkerGender.AutoSize = true;
            this.lblWorkerGender.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerGender.Location = new System.Drawing.Point(494, 186);
            this.lblWorkerGender.Name = "lblWorkerGender";
            this.lblWorkerGender.Size = new System.Drawing.Size(64, 20);
            this.lblWorkerGender.TabIndex = 22;
            this.lblWorkerGender.Text = "Gender";
            // 
            // lbStaffs
            // 
            this.lbStaffs.FormattingEnabled = true;
            this.lbStaffs.ItemHeight = 16;
            this.lbStaffs.Location = new System.Drawing.Point(265, 58);
            this.lbStaffs.Name = "lbStaffs";
            this.lbStaffs.Size = new System.Drawing.Size(168, 148);
            this.lbStaffs.TabIndex = 23;
            // 
            // lblAllStaffs
            // 
            this.lblAllStaffs.AutoSize = true;
            this.lblAllStaffs.BackColor = System.Drawing.Color.Transparent;
            this.lblAllStaffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllStaffs.Location = new System.Drawing.Point(261, 28);
            this.lblAllStaffs.Name = "lblAllStaffs";
            this.lblAllStaffs.Size = new System.Drawing.Size(132, 20);
            this.lblAllStaffs.TabIndex = 24;
            this.lblAllStaffs.Text = "Список штатів";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStaffName.Location = new System.Drawing.Point(12, 34);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(53, 20);
            this.lblStaffName.TabIndex = 26;
            this.lblStaffName.Text = "Name";
            // 
            // tbStaffName
            // 
            this.tbStaffName.Location = new System.Drawing.Point(130, 32);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.Size = new System.Drawing.Size(100, 22);
            this.tbStaffName.TabIndex = 25;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAddStaff.Location = new System.Drawing.Point(9, 295);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(126, 36);
            this.btnAddStaff.TabIndex = 27;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // lblStaffDescription
            // 
            this.lblStaffDescription.AutoSize = true;
            this.lblStaffDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStaffDescription.Location = new System.Drawing.Point(12, 63);
            this.lblStaffDescription.Name = "lblStaffDescription";
            this.lblStaffDescription.Size = new System.Drawing.Size(95, 20);
            this.lblStaffDescription.TabIndex = 29;
            this.lblStaffDescription.Text = "Description";
            // 
            // tbStaffDescription
            // 
            this.tbStaffDescription.Location = new System.Drawing.Point(130, 63);
            this.tbStaffDescription.Name = "tbStaffDescription";
            this.tbStaffDescription.Size = new System.Drawing.Size(100, 22);
            this.tbStaffDescription.TabIndex = 28;
            // 
            // btnStaffInfo
            // 
            this.btnStaffInfo.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnStaffInfo.Location = new System.Drawing.Point(145, 295);
            this.btnStaffInfo.Name = "btnStaffInfo";
            this.btnStaffInfo.Size = new System.Drawing.Size(126, 36);
            this.btnStaffInfo.TabIndex = 30;
            this.btnStaffInfo.Text = "Staff info";
            this.btnStaffInfo.UseVisualStyleBackColor = false;
            this.btnStaffInfo.Click += new System.EventHandler(this.btnStaffInfo_Click);
            // 
            // btnWorkerInfo
            // 
            this.btnWorkerInfo.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnWorkerInfo.Location = new System.Drawing.Point(753, 295);
            this.btnWorkerInfo.Name = "btnWorkerInfo";
            this.btnWorkerInfo.Size = new System.Drawing.Size(126, 36);
            this.btnWorkerInfo.TabIndex = 31;
            this.btnWorkerInfo.Text = "Worker info";
            this.btnWorkerInfo.UseVisualStyleBackColor = false;
            this.btnWorkerInfo.Click += new System.EventHandler(this.btnWorkerInfo_Click);
            // 
            // lblWorkerSalary
            // 
            this.lblWorkerSalary.AutoSize = true;
            this.lblWorkerSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerSalary.Location = new System.Drawing.Point(494, 250);
            this.lblWorkerSalary.Name = "lblWorkerSalary";
            this.lblWorkerSalary.Size = new System.Drawing.Size(56, 20);
            this.lblWorkerSalary.TabIndex = 32;
            this.lblWorkerSalary.Text = "Salary";
            // 
            // tbWorkerSalary
            // 
            this.tbWorkerSalary.Location = new System.Drawing.Point(621, 248);
            this.tbWorkerSalary.Name = "tbWorkerSalary";
            this.tbWorkerSalary.Size = new System.Drawing.Size(100, 22);
            this.tbWorkerSalary.TabIndex = 33;
            // 
            // FormWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 520);
            this.Controls.Add(this.tbWorkerSalary);
            this.Controls.Add(this.lblWorkerSalary);
            this.Controls.Add(this.btnWorkerInfo);
            this.Controls.Add(this.btnStaffInfo);
            this.Controls.Add(this.lblStaffDescription);
            this.Controls.Add(this.tbStaffDescription);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.tbStaffName);
            this.Controls.Add(this.lblAllStaffs);
            this.Controls.Add(this.lbStaffs);
            this.Controls.Add(this.lblWorkerGender);
            this.Controls.Add(this.lblWorkerBirthday);
            this.Controls.Add(this.lblWorkerPName);
            this.Controls.Add(this.lblWorkerSName);
            this.Controls.Add(this.cbWorkerGender);
            this.Controls.Add(this.dtpWorkerBirthday);
            this.Controls.Add(this.tbWorkerPName);
            this.Controls.Add(this.tbWorkerSName);
            this.Controls.Add(this.lblAllWorkers);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.tbWorkerName);
            this.Controls.Add(this.lbWorkers);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWorkers";
            this.Text = "Workers Management";
            this.Load += new System.EventHandler(this.FormWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAllWorkers;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.TextBox tbWorkerName;
        private System.Windows.Forms.ListBox lbWorkers;
        private System.Windows.Forms.TextBox tbWorkerSName;
        private System.Windows.Forms.TextBox tbWorkerPName;
        private System.Windows.Forms.DateTimePicker dtpWorkerBirthday;
        private System.Windows.Forms.ComboBox cbWorkerGender;
        private System.Windows.Forms.Label lblWorkerSName;
        private System.Windows.Forms.Label lblWorkerPName;
        private System.Windows.Forms.Label lblWorkerBirthday;
        private System.Windows.Forms.Label lblWorkerGender;
        private System.Windows.Forms.ListBox lbStaffs;
        private System.Windows.Forms.Label lblAllStaffs;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Label lblStaffDescription;
        private System.Windows.Forms.TextBox tbStaffDescription;
        private System.Windows.Forms.Button btnStaffInfo;
        private System.Windows.Forms.Button btnWorkerInfo;
        private System.Windows.Forms.Label lblWorkerSalary;
        private System.Windows.Forms.TextBox tbWorkerSalary;
    }
}
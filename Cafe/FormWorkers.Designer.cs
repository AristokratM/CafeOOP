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
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.lbWorkers = new System.Windows.Forms.ListBox();
            this.btnWorkerInfo = new System.Windows.Forms.Button();
            this.btnEditWorker = new System.Windows.Forms.Button();
            this.btnRemoveWorker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Moccasin;
            this.btnExit.Location = new System.Drawing.Point(544, 428);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblAllWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllWorkers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAllWorkers.Location = new System.Drawing.Point(84, 25);
            this.lblAllWorkers.Name = "lblAllWorkers";
            this.lblAllWorkers.Size = new System.Drawing.Size(80, 24);
            this.lblAllWorkers.TabIndex = 13;
            this.lblAllWorkers.Text = "Workers";
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAddWorker.Location = new System.Drawing.Point(294, 126);
            this.btnAddWorker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(125, 36);
            this.btnAddWorker.TabIndex = 11;
            this.btnAddWorker.Text = "Add Worker";
            this.btnAddWorker.UseVisualStyleBackColor = false;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // lbWorkers
            // 
            this.lbWorkers.FormattingEnabled = true;
            this.lbWorkers.ItemHeight = 16;
            this.lbWorkers.Location = new System.Drawing.Point(12, 51);
            this.lbWorkers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbWorkers.Name = "lbWorkers";
            this.lbWorkers.Size = new System.Drawing.Size(252, 404);
            this.lbWorkers.TabIndex = 9;
            // 
            // btnWorkerInfo
            // 
            this.btnWorkerInfo.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnWorkerInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWorkerInfo.Location = new System.Drawing.Point(294, 60);
            this.btnWorkerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWorkerInfo.Name = "btnWorkerInfo";
            this.btnWorkerInfo.Size = new System.Drawing.Size(125, 36);
            this.btnWorkerInfo.TabIndex = 31;
            this.btnWorkerInfo.Text = "Worker Info";
            this.btnWorkerInfo.UseVisualStyleBackColor = false;
            this.btnWorkerInfo.Click += new System.EventHandler(this.btnWorkerInfo_Click);
            // 
            // btnEditWorker
            // 
            this.btnEditWorker.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEditWorker.Location = new System.Drawing.Point(294, 198);
            this.btnEditWorker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditWorker.Name = "btnEditWorker";
            this.btnEditWorker.Size = new System.Drawing.Size(125, 36);
            this.btnEditWorker.TabIndex = 32;
            this.btnEditWorker.Text = "Edit Worker";
            this.btnEditWorker.UseVisualStyleBackColor = false;
            this.btnEditWorker.Click += new System.EventHandler(this.btnEditWorker_Click);
            // 
            // btnRemoveWorker
            // 
            this.btnRemoveWorker.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnRemoveWorker.Location = new System.Drawing.Point(294, 265);
            this.btnRemoveWorker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveWorker.Name = "btnRemoveWorker";
            this.btnRemoveWorker.Size = new System.Drawing.Size(125, 36);
            this.btnRemoveWorker.TabIndex = 33;
            this.btnRemoveWorker.Text = "Remove Worker";
            this.btnRemoveWorker.UseVisualStyleBackColor = false;
            this.btnRemoveWorker.Click += new System.EventHandler(this.btnRemoveWorker_Click);
            // 
            // FormWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 509);
            this.Controls.Add(this.btnRemoveWorker);
            this.Controls.Add(this.btnEditWorker);
            this.Controls.Add(this.btnWorkerInfo);
            this.Controls.Add(this.lblAllWorkers);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.lbWorkers);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormWorkers";
            this.Text = "Workers Management";
            this.Load += new System.EventHandler(this.FormWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAllWorkers;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.ListBox lbWorkers;
        private System.Windows.Forms.Button btnWorkerInfo;
        private System.Windows.Forms.Button btnEditWorker;
        private System.Windows.Forms.Button btnRemoveWorker;
    }
}
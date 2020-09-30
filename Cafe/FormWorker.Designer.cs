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
            this.SuspendLayout();
            // 
            // lblWorkerInfo
            // 
            this.lblWorkerInfo.AutoSize = true;
            this.lblWorkerInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerInfo.Location = new System.Drawing.Point(326, 56);
            this.lblWorkerInfo.Name = "lblWorkerInfo";
            this.lblWorkerInfo.Size = new System.Drawing.Size(159, 32);
            this.lblWorkerInfo.TabIndex = 6;
            this.lblWorkerInfo.Text = "Worker Info";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Moccasin;
            this.btnExit.Location = new System.Drawing.Point(658, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtbWorkerInfo
            // 
            this.rtbWorkerInfo.Location = new System.Drawing.Point(149, 105);
            this.rtbWorkerInfo.Name = "rtbWorkerInfo";
            this.rtbWorkerInfo.Size = new System.Drawing.Size(481, 236);
            this.rtbWorkerInfo.TabIndex = 4;
            this.rtbWorkerInfo.Text = "";
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 477);
            this.Controls.Add(this.lblWorkerInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtbWorkerInfo);
            this.Name = "FormWorker";
            this.Text = "FormWorker";
            this.Load += new System.EventHandler(this.FormWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWorkerInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbWorkerInfo;
    }
}
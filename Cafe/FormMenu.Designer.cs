namespace Cafe
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.lblMenuInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.rtbMenuInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblMenuInfo
            // 
            this.lblMenuInfo.AutoSize = true;
            this.lblMenuInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMenuInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMenuInfo.Location = new System.Drawing.Point(265, 43);
            this.lblMenuInfo.Name = "lblMenuInfo";
            this.lblMenuInfo.Size = new System.Drawing.Size(140, 32);
            this.lblMenuInfo.TabIndex = 6;
            this.lblMenuInfo.Text = "Menu Info";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Moccasin;
            this.btnExit.Location = new System.Drawing.Point(597, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtbMenuInfo
            // 
            this.rtbMenuInfo.Location = new System.Drawing.Point(88, 92);
            this.rtbMenuInfo.Name = "rtbMenuInfo";
            this.rtbMenuInfo.Size = new System.Drawing.Size(481, 236);
            this.rtbMenuInfo.TabIndex = 4;
            this.rtbMenuInfo.Text = "";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMenuInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtbMenuInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Menu Info";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbMenuInfo;
    }
}
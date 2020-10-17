namespace Cafe
{
    partial class FormDish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDish));
            this.tbDishWeight = new System.Windows.Forms.TextBox();
            this.tbDishPrice = new System.Windows.Forms.TextBox();
            this.lbDishWeight = new System.Windows.Forms.Label();
            this.lbDishPrice = new System.Windows.Forms.Label();
            this.lbDishName = new System.Windows.Forms.Label();
            this.tbDishName = new System.Windows.Forms.TextBox();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.lblDishInfo = new System.Windows.Forms.Label();
            this.rtbDishInfo = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDishWeight
            // 
            this.tbDishWeight.Location = new System.Drawing.Point(97, 143);
            this.tbDishWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDishWeight.Name = "tbDishWeight";
            this.tbDishWeight.Size = new System.Drawing.Size(120, 22);
            this.tbDishWeight.TabIndex = 37;
            // 
            // tbDishPrice
            // 
            this.tbDishPrice.Location = new System.Drawing.Point(97, 91);
            this.tbDishPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDishPrice.Name = "tbDishPrice";
            this.tbDishPrice.Size = new System.Drawing.Size(120, 22);
            this.tbDishPrice.TabIndex = 36;
            // 
            // lbDishWeight
            // 
            this.lbDishWeight.AutoSize = true;
            this.lbDishWeight.BackColor = System.Drawing.Color.Transparent;
            this.lbDishWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDishWeight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDishWeight.Location = new System.Drawing.Point(22, 143);
            this.lbDishWeight.Name = "lbDishWeight";
            this.lbDishWeight.Size = new System.Drawing.Size(69, 24);
            this.lbDishWeight.TabIndex = 35;
            this.lbDishWeight.Text = "Weight";
            // 
            // lbDishPrice
            // 
            this.lbDishPrice.AutoSize = true;
            this.lbDishPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbDishPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDishPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDishPrice.Location = new System.Drawing.Point(22, 91);
            this.lbDishPrice.Name = "lbDishPrice";
            this.lbDishPrice.Size = new System.Drawing.Size(53, 24);
            this.lbDishPrice.TabIndex = 34;
            this.lbDishPrice.Text = "Price";
            // 
            // lbDishName
            // 
            this.lbDishName.AutoSize = true;
            this.lbDishName.BackColor = System.Drawing.Color.Transparent;
            this.lbDishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDishName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDishName.Location = new System.Drawing.Point(22, 38);
            this.lbDishName.Name = "lbDishName";
            this.lbDishName.Size = new System.Drawing.Size(61, 24);
            this.lbDishName.TabIndex = 33;
            this.lbDishName.Text = "Name";
            // 
            // tbDishName
            // 
            this.tbDishName.Location = new System.Drawing.Point(97, 37);
            this.tbDishName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDishName.Name = "tbDishName";
            this.tbDishName.Size = new System.Drawing.Size(120, 22);
            this.tbDishName.TabIndex = 32;
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnApplyChanges.Location = new System.Drawing.Point(93, 207);
            this.btnApplyChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(124, 32);
            this.btnApplyChanges.TabIndex = 38;
            this.btnApplyChanges.Text = "Apply Changes";
            this.btnApplyChanges.UseVisualStyleBackColor = false;
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // lblDishInfo
            // 
            this.lblDishInfo.AutoSize = true;
            this.lblDishInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblDishInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDishInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDishInfo.Location = new System.Drawing.Point(611, 31);
            this.lblDishInfo.Name = "lblDishInfo";
            this.lblDishInfo.Size = new System.Drawing.Size(126, 32);
            this.lblDishInfo.TabIndex = 40;
            this.lblDishInfo.Text = "Dish Info";
            // 
            // rtbDishInfo
            // 
            this.rtbDishInfo.Location = new System.Drawing.Point(416, 91);
            this.rtbDishInfo.Name = "rtbDishInfo";
            this.rtbDishInfo.Size = new System.Drawing.Size(481, 236);
            this.rtbDishInfo.TabIndex = 39;
            this.rtbDishInfo.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Moccasin;
            this.btnExit.Location = new System.Drawing.Point(782, 357);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 27);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 429);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDishInfo);
            this.Controls.Add(this.rtbDishInfo);
            this.Controls.Add(this.btnApplyChanges);
            this.Controls.Add(this.tbDishWeight);
            this.Controls.Add(this.tbDishPrice);
            this.Controls.Add(this.lbDishWeight);
            this.Controls.Add(this.lbDishPrice);
            this.Controls.Add(this.lbDishName);
            this.Controls.Add(this.tbDishName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDish";
            this.Text = "Dish Info";
            this.Load += new System.EventHandler(this.FormDish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDishWeight;
        private System.Windows.Forms.TextBox tbDishPrice;
        private System.Windows.Forms.Label lbDishWeight;
        private System.Windows.Forms.Label lbDishPrice;
        private System.Windows.Forms.Label lbDishName;
        private System.Windows.Forms.TextBox tbDishName;
        private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.Label lblDishInfo;
        private System.Windows.Forms.RichTextBox rtbDishInfo;
        private System.Windows.Forms.Button btnExit;
    }
}
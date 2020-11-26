namespace Cafe
{
    partial class FormFindMenuByDish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindMenuByDish));
            this.lbDish = new System.Windows.Forms.ListBox();
            this.lbMenues = new System.Windows.Forms.ListBox();
            this.tbDishCount = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFindMenu = new System.Windows.Forms.Button();
            this.lblDishes = new System.Windows.Forms.Label();
            this.lblFindedMenues = new System.Windows.Forms.Label();
            this.lblDishCount = new System.Windows.Forms.Label();
            this.btnMenuInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDish
            // 
            this.lbDish.FormattingEnabled = true;
            this.lbDish.ItemHeight = 16;
            this.lbDish.Location = new System.Drawing.Point(28, 78);
            this.lbDish.Name = "lbDish";
            this.lbDish.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDish.Size = new System.Drawing.Size(181, 276);
            this.lbDish.TabIndex = 0;
            // 
            // lbMenues
            // 
            this.lbMenues.FormattingEnabled = true;
            this.lbMenues.ItemHeight = 16;
            this.lbMenues.Location = new System.Drawing.Point(558, 78);
            this.lbMenues.Name = "lbMenues";
            this.lbMenues.Size = new System.Drawing.Size(181, 276);
            this.lbMenues.TabIndex = 1;
            // 
            // tbDishCount
            // 
            this.tbDishCount.Location = new System.Drawing.Point(240, 78);
            this.tbDishCount.Name = "tbDishCount";
            this.tbDishCount.Size = new System.Drawing.Size(100, 22);
            this.tbDishCount.TabIndex = 2;
            this.tbDishCount.Text = "0";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Moccasin;
            this.btnExit.Location = new System.Drawing.Point(736, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFindMenu
            // 
            this.btnFindMenu.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnFindMenu.Location = new System.Drawing.Point(240, 117);
            this.btnFindMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFindMenu.Name = "btnFindMenu";
            this.btnFindMenu.Size = new System.Drawing.Size(100, 37);
            this.btnFindMenu.TabIndex = 30;
            this.btnFindMenu.Text = "Find";
            this.btnFindMenu.UseVisualStyleBackColor = false;
            this.btnFindMenu.Click += new System.EventHandler(this.btnFindMenu_Click);
            // 
            // lblDishes
            // 
            this.lblDishes.AutoSize = true;
            this.lblDishes.BackColor = System.Drawing.Color.Transparent;
            this.lblDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDishes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDishes.Location = new System.Drawing.Point(85, 36);
            this.lblDishes.Name = "lblDishes";
            this.lblDishes.Size = new System.Drawing.Size(67, 24);
            this.lblDishes.TabIndex = 31;
            this.lblDishes.Text = "Dishes";
            // 
            // lblFindedMenues
            // 
            this.lblFindedMenues.AutoSize = true;
            this.lblFindedMenues.BackColor = System.Drawing.Color.Transparent;
            this.lblFindedMenues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFindedMenues.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFindedMenues.Location = new System.Drawing.Point(575, 36);
            this.lblFindedMenues.Name = "lblFindedMenues";
            this.lblFindedMenues.Size = new System.Drawing.Size(144, 24);
            this.lblFindedMenues.TabIndex = 32;
            this.lblFindedMenues.Text = "Finded Menues";
            // 
            // lblDishCount
            // 
            this.lblDishCount.AutoSize = true;
            this.lblDishCount.BackColor = System.Drawing.Color.Transparent;
            this.lblDishCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDishCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDishCount.Location = new System.Drawing.Point(236, 36);
            this.lblDishCount.Name = "lblDishCount";
            this.lblDishCount.Size = new System.Drawing.Size(315, 24);
            this.lblDishCount.TabIndex = 33;
            this.lblDishCount.Text = "Minimum number of selected dishes";
            // 
            // btnMenuInfo
            // 
            this.btnMenuInfo.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnMenuInfo.Location = new System.Drawing.Point(757, 78);
            this.btnMenuInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuInfo.Name = "btnMenuInfo";
            this.btnMenuInfo.Size = new System.Drawing.Size(100, 37);
            this.btnMenuInfo.TabIndex = 34;
            this.btnMenuInfo.Text = "Menu Info";
            this.btnMenuInfo.UseVisualStyleBackColor = false;
            this.btnMenuInfo.Click += new System.EventHandler(this.btnMenuInfo_Click);
            // 
            // FormFindMenuByDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 510);
            this.Controls.Add(this.btnMenuInfo);
            this.Controls.Add(this.lblDishCount);
            this.Controls.Add(this.lblFindedMenues);
            this.Controls.Add(this.lblDishes);
            this.Controls.Add(this.btnFindMenu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbDishCount);
            this.Controls.Add(this.lbMenues);
            this.Controls.Add(this.lbDish);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFindMenuByDish";
            this.Text = "FormFindMenuByDish";
            this.Load += new System.EventHandler(this.FormFindMenuByDish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDish;
        private System.Windows.Forms.ListBox lbMenues;
        private System.Windows.Forms.TextBox tbDishCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFindMenu;
        private System.Windows.Forms.Label lblDishes;
        private System.Windows.Forms.Label lblFindedMenues;
        private System.Windows.Forms.Label lblDishCount;
        private System.Windows.Forms.Button btnMenuInfo;
    }
}
namespace Cafe
{
    partial class FormDishes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDishes));
            this.lblAllDishes = new System.Windows.Forms.Label();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.lbDishes = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDishInfo = new System.Windows.Forms.Button();
            this.btnEditDish = new System.Windows.Forms.Button();
            this.btnRemoveDish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAllDishes
            // 
            this.lblAllDishes.AutoSize = true;
            this.lblAllDishes.BackColor = System.Drawing.Color.Transparent;
            this.lblAllDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllDishes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAllDishes.Location = new System.Drawing.Point(75, 34);
            this.lblAllDishes.Name = "lblAllDishes";
            this.lblAllDishes.Size = new System.Drawing.Size(67, 24);
            this.lblAllDishes.TabIndex = 27;
            this.lblAllDishes.Text = "Dishes";
            // 
            // btnAddDish
            // 
            this.btnAddDish.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAddDish.Location = new System.Drawing.Point(254, 137);
            this.btnAddDish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(124, 32);
            this.btnAddDish.TabIndex = 25;
            this.btnAddDish.Text = "Add Dish";
            this.btnAddDish.UseVisualStyleBackColor = false;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // lbDishes
            // 
            this.lbDishes.FormattingEnabled = true;
            this.lbDishes.ItemHeight = 16;
            this.lbDishes.Location = new System.Drawing.Point(12, 71);
            this.lbDishes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbDishes.Name = "lbDishes";
            this.lbDishes.Size = new System.Drawing.Size(207, 356);
            this.lbDishes.TabIndex = 23;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Moccasin;
            this.btnExit.Location = new System.Drawing.Point(607, 384);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 27);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDishInfo
            // 
            this.btnDishInfo.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDishInfo.Location = new System.Drawing.Point(254, 71);
            this.btnDishInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDishInfo.Name = "btnDishInfo";
            this.btnDishInfo.Size = new System.Drawing.Size(124, 32);
            this.btnDishInfo.TabIndex = 29;
            this.btnDishInfo.Text = "Dish Info";
            this.btnDishInfo.UseVisualStyleBackColor = false;
            this.btnDishInfo.Click += new System.EventHandler(this.btnDishInfo_Click);
            // 
            // btnEditDish
            // 
            this.btnEditDish.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEditDish.Location = new System.Drawing.Point(254, 199);
            this.btnEditDish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditDish.Name = "btnEditDish";
            this.btnEditDish.Size = new System.Drawing.Size(124, 32);
            this.btnEditDish.TabIndex = 30;
            this.btnEditDish.Text = "Edit Dish";
            this.btnEditDish.UseVisualStyleBackColor = false;
            this.btnEditDish.Click += new System.EventHandler(this.btnEditDish_Click);
            // 
            // btnRemoveDish
            // 
            this.btnRemoveDish.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnRemoveDish.Location = new System.Drawing.Point(254, 263);
            this.btnRemoveDish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveDish.Name = "btnRemoveDish";
            this.btnRemoveDish.Size = new System.Drawing.Size(124, 32);
            this.btnRemoveDish.TabIndex = 31;
            this.btnRemoveDish.Text = "Remove Dish";
            this.btnRemoveDish.UseVisualStyleBackColor = false;
            this.btnRemoveDish.Click += new System.EventHandler(this.btnRemoveDish_Click);
            // 
            // FormDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveDish);
            this.Controls.Add(this.btnEditDish);
            this.Controls.Add(this.btnDishInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAllDishes);
            this.Controls.Add(this.btnAddDish);
            this.Controls.Add(this.lbDishes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDishes";
            this.Text = "Dishes Managment";
            this.Load += new System.EventHandler(this.FormDishes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAllDishes;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.ListBox lbDishes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDishInfo;
        private System.Windows.Forms.Button btnEditDish;
        private System.Windows.Forms.Button btnRemoveDish;
    }
}
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lbAllDishes = new System.Windows.Forms.Label();
            this.lbDishName = new System.Windows.Forms.Label();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.tbDishName = new System.Windows.Forms.TextBox();
            this.lbDishes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.tbMenuName = new System.Windows.Forms.TextBox();
            this.lbMenus = new System.Windows.Forms.ListBox();
            this.lbDishPrice = new System.Windows.Forms.Label();
            this.lbDishWeight = new System.Windows.Forms.Label();
            this.tbDishPrice = new System.Windows.Forms.TextBox();
            this.tbDishWeight = new System.Windows.Forms.TextBox();
            this.btnMenuDishes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Moccasin;
            this.btnExit.Location = new System.Drawing.Point(609, 305);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 22);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbAllDishes
            // 
            this.lbAllDishes.AutoSize = true;
            this.lbAllDishes.BackColor = System.Drawing.Color.Transparent;
            this.lbAllDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAllDishes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAllDishes.Location = new System.Drawing.Point(615, 44);
            this.lbAllDishes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAllDishes.Name = "lbAllDishes";
            this.lbAllDishes.Size = new System.Drawing.Size(54, 18);
            this.lbAllDishes.TabIndex = 13;
            this.lbAllDishes.Text = "Dishes";
            // 
            // lbDishName
            // 
            this.lbDishName.AutoSize = true;
            this.lbDishName.BackColor = System.Drawing.Color.Transparent;
            this.lbDishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDishName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDishName.Location = new System.Drawing.Point(382, 43);
            this.lbDishName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDishName.Name = "lbDishName";
            this.lbDishName.Size = new System.Drawing.Size(48, 18);
            this.lbDishName.TabIndex = 12;
            this.lbDishName.Text = "Name";
            // 
            // btnAddDish
            // 
            this.btnAddDish.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAddDish.Location = new System.Drawing.Point(385, 238);
            this.btnAddDish.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(93, 26);
            this.btnAddDish.TabIndex = 11;
            this.btnAddDish.Text = "Add Dish";
            this.btnAddDish.UseVisualStyleBackColor = false;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // tbDishName
            // 
            this.tbDishName.Location = new System.Drawing.Point(438, 42);
            this.tbDishName.Margin = new System.Windows.Forms.Padding(2);
            this.tbDishName.Name = "tbDishName";
            this.tbDishName.Size = new System.Drawing.Size(91, 20);
            this.tbDishName.TabIndex = 10;
            // 
            // lbDishes
            // 
            this.lbDishes.FormattingEnabled = true;
            this.lbDishes.Location = new System.Drawing.Point(562, 72);
            this.lbDishes.Margin = new System.Windows.Forms.Padding(2);
            this.lbDishes.Name = "lbDishes";
            this.lbDishes.Size = new System.Drawing.Size(156, 134);
            this.lbDishes.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(203, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Menus";
            // 
            // lblMenuName
            // 
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMenuName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMenuName.Location = new System.Drawing.Point(10, 39);
            this.lblMenuName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(48, 18);
            this.lblMenuName.TabIndex = 17;
            this.lblMenuName.Text = "Name";
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAddMenu.Location = new System.Drawing.Point(11, 238);
            this.btnAddMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(93, 26);
            this.btnAddMenu.TabIndex = 16;
            this.btnAddMenu.Text = "AddMenu";
            this.btnAddMenu.UseVisualStyleBackColor = false;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // tbMenuName
            // 
            this.tbMenuName.Location = new System.Drawing.Point(62, 40);
            this.tbMenuName.Margin = new System.Windows.Forms.Padding(2);
            this.tbMenuName.Name = "tbMenuName";
            this.tbMenuName.Size = new System.Drawing.Size(76, 20);
            this.tbMenuName.TabIndex = 15;
            // 
            // lbMenus
            // 
            this.lbMenus.FormattingEnabled = true;
            this.lbMenus.Location = new System.Drawing.Point(145, 72);
            this.lbMenus.Margin = new System.Windows.Forms.Padding(2);
            this.lbMenus.Name = "lbMenus";
            this.lbMenus.Size = new System.Drawing.Size(169, 134);
            this.lbMenus.TabIndex = 14;
            // 
            // lbDishPrice
            // 
            this.lbDishPrice.AutoSize = true;
            this.lbDishPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbDishPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDishPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDishPrice.Location = new System.Drawing.Point(382, 86);
            this.lbDishPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDishPrice.Name = "lbDishPrice";
            this.lbDishPrice.Size = new System.Drawing.Size(42, 18);
            this.lbDishPrice.TabIndex = 19;
            this.lbDishPrice.Text = "Price";
            // 
            // lbDishWeight
            // 
            this.lbDishWeight.AutoSize = true;
            this.lbDishWeight.BackColor = System.Drawing.Color.Transparent;
            this.lbDishWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDishWeight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDishWeight.Location = new System.Drawing.Point(382, 128);
            this.lbDishWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDishWeight.Name = "lbDishWeight";
            this.lbDishWeight.Size = new System.Drawing.Size(54, 18);
            this.lbDishWeight.TabIndex = 20;
            this.lbDishWeight.Text = "Weight";
            // 
            // tbDishPrice
            // 
            this.tbDishPrice.Location = new System.Drawing.Point(438, 86);
            this.tbDishPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbDishPrice.Name = "tbDishPrice";
            this.tbDishPrice.Size = new System.Drawing.Size(91, 20);
            this.tbDishPrice.TabIndex = 21;
            // 
            // tbDishWeight
            // 
            this.tbDishWeight.Location = new System.Drawing.Point(438, 128);
            this.tbDishWeight.Margin = new System.Windows.Forms.Padding(2);
            this.tbDishWeight.Name = "tbDishWeight";
            this.tbDishWeight.Size = new System.Drawing.Size(91, 20);
            this.tbDishWeight.TabIndex = 22;
            // 
            // btnMenuDishes
            // 
            this.btnMenuDishes.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnMenuDishes.Location = new System.Drawing.Point(122, 238);
            this.btnMenuDishes.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuDishes.Name = "btnMenuDishes";
            this.btnMenuDishes.Size = new System.Drawing.Size(93, 26);
            this.btnMenuDishes.TabIndex = 23;
            this.btnMenuDishes.Text = "Dishes";
            this.btnMenuDishes.UseVisualStyleBackColor = false;
            this.btnMenuDishes.Click += new System.EventHandler(this.btnMenuDishes_Click);
            // 
            // FormDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 366);
            this.Controls.Add(this.btnMenuDishes);
            this.Controls.Add(this.tbDishWeight);
            this.Controls.Add(this.tbDishPrice);
            this.Controls.Add(this.lbDishWeight);
            this.Controls.Add(this.lbDishPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMenuName);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.tbMenuName);
            this.Controls.Add(this.lbMenus);
            this.Controls.Add(this.lbAllDishes);
            this.Controls.Add(this.lbDishName);
            this.Controls.Add(this.btnAddDish);
            this.Controls.Add(this.tbDishName);
            this.Controls.Add(this.lbDishes);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDishes";
            this.Text = "Dishes Management";
            this.Load += new System.EventHandler(this.FormDishes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbAllDishes;
        private System.Windows.Forms.Label lbDishName;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.TextBox tbDishName;
        private System.Windows.Forms.ListBox lbDishes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.TextBox tbMenuName;
        private System.Windows.Forms.ListBox lbMenus;
        private System.Windows.Forms.Label lbDishPrice;
        private System.Windows.Forms.Label lbDishWeight;
        private System.Windows.Forms.TextBox tbDishPrice;
        private System.Windows.Forms.TextBox tbDishWeight;
        private System.Windows.Forms.Button btnMenuDishes;
    }
}
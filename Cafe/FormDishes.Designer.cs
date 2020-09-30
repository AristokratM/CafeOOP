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
            this.lbAllMenus = new System.Windows.Forms.Label();
            this.lbMenuName = new System.Windows.Forms.Label();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.tbDishName = new System.Windows.Forms.TextBox();
            this.lbDishes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(586, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 27);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbAllMenus
            // 
            this.lbAllMenus.AutoSize = true;
            this.lbAllMenus.Location = new System.Drawing.Point(229, 136);
            this.lbAllMenus.Name = "lbAllMenus";
            this.lbAllMenus.Size = new System.Drawing.Size(96, 17);
            this.lbAllMenus.TabIndex = 13;
            this.lbAllMenus.Text = "Список страв";
            // 
            // lbMenuName
            // 
            this.lbMenuName.AutoSize = true;
            this.lbMenuName.Location = new System.Drawing.Point(228, 93);
            this.lbMenuName.Name = "lbMenuName";
            this.lbMenuName.Size = new System.Drawing.Size(97, 17);
            this.lbMenuName.TabIndex = 12;
            this.lbMenuName.Text = "Назва страви";
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(329, 264);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(115, 27);
            this.btnAddMenu.TabIndex = 11;
            this.btnAddMenu.Text = "Add Dish";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // tbDishName
            // 
            this.tbDishName.Location = new System.Drawing.Point(331, 93);
            this.tbDishName.Name = "tbDishName";
            this.tbDishName.Size = new System.Drawing.Size(120, 22);
            this.tbDishName.TabIndex = 10;
            // 
            // lbDishes
            // 
            this.lbDishes.FormattingEnabled = true;
            this.lbDishes.ItemHeight = 16;
            this.lbDishes.Location = new System.Drawing.Point(331, 136);
            this.lbDishes.Name = "lbDishes";
            this.lbDishes.Size = new System.Drawing.Size(120, 84);
            this.lbDishes.TabIndex = 9;
            // 
            // FormDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbAllMenus);
            this.Controls.Add(this.lbMenuName);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.tbDishName);
            this.Controls.Add(this.lbDishes);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDishes";
            this.Text = "FormDishes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbAllMenus;
        private System.Windows.Forms.Label lbMenuName;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.TextBox tbDishName;
        private System.Windows.Forms.ListBox lbDishes;
    }
}
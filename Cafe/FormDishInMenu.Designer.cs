namespace Cafe
{
    partial class FormDishInMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDishInMenu));
            this.lblAllDishes = new System.Windows.Forms.Label();
            this.lbDishes = new System.Windows.Forms.ListBox();
            this.lblOtherDishes = new System.Windows.Forms.Label();
            this.lbOtherDishes = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAllDishes
            // 
            this.lblAllDishes.AutoSize = true;
            this.lblAllDishes.BackColor = System.Drawing.Color.Transparent;
            this.lblAllDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllDishes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAllDishes.Location = new System.Drawing.Point(97, 54);
            this.lblAllDishes.Name = "lblAllDishes";
            this.lblAllDishes.Size = new System.Drawing.Size(141, 24);
            this.lblAllDishes.TabIndex = 15;
            this.lblAllDishes.Text = "Dishes in Menu";
            // 
            // lbDishes
            // 
            this.lbDishes.FormattingEnabled = true;
            this.lbDishes.ItemHeight = 16;
            this.lbDishes.Location = new System.Drawing.Point(53, 94);
            this.lbDishes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbDishes.Name = "lbDishes";
            this.lbDishes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDishes.Size = new System.Drawing.Size(229, 356);
            this.lbDishes.TabIndex = 14;
            // 
            // lblOtherDishes
            // 
            this.lblOtherDishes.AutoSize = true;
            this.lblOtherDishes.BackColor = System.Drawing.Color.Transparent;
            this.lblOtherDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOtherDishes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOtherDishes.Location = new System.Drawing.Point(612, 54);
            this.lblOtherDishes.Name = "lblOtherDishes";
            this.lblOtherDishes.Size = new System.Drawing.Size(119, 24);
            this.lblOtherDishes.TabIndex = 17;
            this.lblOtherDishes.Text = "Other Dishes";
            // 
            // lbOtherDishes
            // 
            this.lbOtherDishes.FormattingEnabled = true;
            this.lbOtherDishes.ItemHeight = 16;
            this.lbOtherDishes.Location = new System.Drawing.Point(551, 94);
            this.lbOtherDishes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOtherDishes.Name = "lbOtherDishes";
            this.lbOtherDishes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbOtherDishes.Size = new System.Drawing.Size(233, 356);
            this.lbOtherDishes.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Moccasin;
            this.btnExit.Location = new System.Drawing.Point(808, 502);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 27);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAdd.Location = new System.Drawing.Point(352, 188);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 47);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnRemove.Location = new System.Drawing.Point(352, 266);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(128, 47);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnClear.Location = new System.Drawing.Point(352, 341);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 47);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormDishInMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 566);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOtherDishes);
            this.Controls.Add(this.lbOtherDishes);
            this.Controls.Add(this.lblAllDishes);
            this.Controls.Add(this.lbDishes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDishInMenu";
            this.Text = "Edit Menu";
            this.Load += new System.EventHandler(this.FormDishInMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAllDishes;
        private System.Windows.Forms.ListBox lbDishes;
        private System.Windows.Forms.Label lblOtherDishes;
        private System.Windows.Forms.ListBox lbOtherDishes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
    }
}
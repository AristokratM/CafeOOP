namespace Cafe
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAboutForm = new System.Windows.Forms.Button();
            this.btnWorkersForm = new System.Windows.Forms.Button();
            this.btnDishesForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Moccasin;
            this.btnExit.Location = new System.Drawing.Point(678, 399);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.okButton_Click);
            // 
            // btnAboutForm
            // 
            this.btnAboutForm.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAboutForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAboutForm.BackgroundImage")));
            this.btnAboutForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAboutForm.Location = new System.Drawing.Point(54, 371);
            this.btnAboutForm.Name = "btnAboutForm";
            this.btnAboutForm.Size = new System.Drawing.Size(213, 90);
            this.btnAboutForm.TabIndex = 4;
            this.btnAboutForm.UseVisualStyleBackColor = false;
            this.btnAboutForm.Click += new System.EventHandler(this.btnAboutForm_Click);
            // 
            // btnWorkersForm
            // 
            this.btnWorkersForm.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnWorkersForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWorkersForm.BackgroundImage")));
            this.btnWorkersForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWorkersForm.Location = new System.Drawing.Point(543, 74);
            this.btnWorkersForm.Name = "btnWorkersForm";
            this.btnWorkersForm.Size = new System.Drawing.Size(273, 255);
            this.btnWorkersForm.TabIndex = 5;
            this.btnWorkersForm.UseVisualStyleBackColor = false;
            this.btnWorkersForm.Click += new System.EventHandler(this.btnWorkersForm_Click);
            // 
            // btnDishesForm
            // 
            this.btnDishesForm.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDishesForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDishesForm.BackgroundImage")));
            this.btnDishesForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDishesForm.Location = new System.Drawing.Point(39, 74);
            this.btnDishesForm.Name = "btnDishesForm";
            this.btnDishesForm.Size = new System.Drawing.Size(273, 255);
            this.btnDishesForm.TabIndex = 6;
            this.btnDishesForm.UseVisualStyleBackColor = false;
            this.btnDishesForm.Click += new System.EventHandler(this.btnDishesForm_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 481);
            this.Controls.Add(this.btnDishesForm);
            this.Controls.Add(this.btnWorkersForm);
            this.Controls.Add(this.btnAboutForm);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Waterloo";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAboutForm;
        private System.Windows.Forms.Button btnWorkersForm;
        private System.Windows.Forms.Button btnDishesForm;
    }
}


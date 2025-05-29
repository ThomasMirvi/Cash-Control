namespace Finance
{
    partial class AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            this.txtNewCategory = new System.Windows.Forms.TextBox();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.labelVyvoj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewCategory
            // 
            this.txtNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNewCategory.Location = new System.Drawing.Point(76, 113);
            this.txtNewCategory.Name = "txtNewCategory";
            this.txtNewCategory.Size = new System.Drawing.Size(192, 28);
            this.txtNewCategory.TabIndex = 1;
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.BackColor = System.Drawing.Color.Gold;
            this.btnAddNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNewCategory.Location = new System.Drawing.Point(106, 165);
            this.btnAddNewCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(128, 36);
            this.btnAddNewCategory.TabIndex = 15;
            this.btnAddNewCategory.Text = "Vložit";
            this.btnAddNewCategory.UseVisualStyleBackColor = false;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // labelVyvoj
            // 
            this.labelVyvoj.AutoSize = true;
            this.labelVyvoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVyvoj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelVyvoj.Location = new System.Drawing.Point(26, 23);
            this.labelVyvoj.Name = "labelVyvoj";
            this.labelVyvoj.Size = new System.Drawing.Size(285, 25);
            this.labelVyvoj.TabIndex = 22;
            this.labelVyvoj.Text = "Vložte název nové kategorie";
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(340, 228);
            this.Controls.Add(this.labelVyvoj);
            this.Controls.Add(this.btnAddNewCategory);
            this.Controls.Add(this.txtNewCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCategory";
            this.Text = "CASHCONTROL - Přidat kategorii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewCategory;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Label labelVyvoj;
    }
}
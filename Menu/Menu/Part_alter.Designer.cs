
namespace Menu
{
    partial class Part_alter
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
            this.cbParameter = new System.Windows.Forms.ComboBox();
            this.lblNewVal = new System.Windows.Forms.Label();
            this.txtNewVal = new System.Windows.Forms.TextBox();
            this.btnAlter = new System.Windows.Forms.Button();
            this.partListUC1 = new Menu.PartListUC();
            this.SuspendLayout();
            // 
            // cbParameter
            // 
            this.cbParameter.FormattingEnabled = true;
            this.cbParameter.Items.AddRange(new object[] {
            "tipus",
            "darab/rekesz",
            "ár"});
            this.cbParameter.Location = new System.Drawing.Point(12, 357);
            this.cbParameter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbParameter.Name = "cbParameter";
            this.cbParameter.Size = new System.Drawing.Size(121, 24);
            this.cbParameter.TabIndex = 1;
            // 
            // lblNewVal
            // 
            this.lblNewVal.AutoSize = true;
            this.lblNewVal.Location = new System.Drawing.Point(9, 396);
            this.lblNewVal.Name = "lblNewVal";
            this.lblNewVal.Size = new System.Drawing.Size(54, 16);
            this.lblNewVal.TabIndex = 2;
            this.lblNewVal.Text = "Új érték";
            // 
            // txtNewVal
            // 
            this.txtNewVal.Location = new System.Drawing.Point(69, 396);
            this.txtNewVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewVal.Name = "txtNewVal";
            this.txtNewVal.Size = new System.Drawing.Size(159, 22);
            this.txtNewVal.TabIndex = 3;
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(12, 431);
            this.btnAlter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 4;
            this.btnAlter.Text = "Változtat";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.Alter_part);
            // 
            // partListUC1
            // 
            this.partListUC1.Location = new System.Drawing.Point(-11, -1);
            this.partListUC1.Margin = new System.Windows.Forms.Padding(5);
            this.partListUC1.Name = "partListUC1";
            this.partListUC1.Size = new System.Drawing.Size(640, 351);
            this.partListUC1.TabIndex = 5;
            // 
            // Part_alter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 478);
            this.Controls.Add(this.partListUC1);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.txtNewVal);
            this.Controls.Add(this.lblNewVal);
            this.Controls.Add(this.cbParameter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Part_alter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Part_add";
            this.Load += new System.EventHandler(this.AdatokFeltoltese);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbParameter;
        private System.Windows.Forms.Label lblNewVal;
        private System.Windows.Forms.TextBox txtNewVal;
        private System.Windows.Forms.Button btnAlter;
        private PartListUC partListUC1;
    }
}

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
            this.lbPartList = new System.Windows.Forms.ListBox();
            this.cbParameter = new System.Windows.Forms.ComboBox();
            this.lblNewVal = new System.Windows.Forms.Label();
            this.txtNewVal = new System.Windows.Forms.TextBox();
            this.btnAlter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPartList
            // 
            this.lbPartList.FormattingEnabled = true;
            this.lbPartList.ItemHeight = 16;
            this.lbPartList.Location = new System.Drawing.Point(38, 12);
            this.lbPartList.Name = "lbPartList";
            this.lbPartList.Size = new System.Drawing.Size(558, 308);
            this.lbPartList.TabIndex = 0;
            // 
            // cbParameter
            // 
            this.cbParameter.FormattingEnabled = true;
            this.cbParameter.Items.AddRange(new object[] {
            "tipus",
            "darab/rekesz",
            "ár"});
            this.cbParameter.Location = new System.Drawing.Point(605, 98);
            this.cbParameter.Name = "cbParameter";
            this.cbParameter.Size = new System.Drawing.Size(121, 24);
            this.cbParameter.TabIndex = 1;
            // 
            // lblNewVal
            // 
            this.lblNewVal.AutoSize = true;
            this.lblNewVal.Location = new System.Drawing.Point(602, 165);
            this.lblNewVal.Name = "lblNewVal";
            this.lblNewVal.Size = new System.Drawing.Size(54, 16);
            this.lblNewVal.TabIndex = 2;
            this.lblNewVal.Text = "Új érték";
            // 
            // txtNewVal
            // 
            this.txtNewVal.Location = new System.Drawing.Point(662, 159);
            this.txtNewVal.Name = "txtNewVal";
            this.txtNewVal.Size = new System.Drawing.Size(159, 22);
            this.txtNewVal.TabIndex = 3;
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(651, 235);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 4;
            this.btnAlter.Text = "Változtat";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.Alter_part);
            // 
            // Part_alter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 349);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.txtNewVal);
            this.Controls.Add(this.lblNewVal);
            this.Controls.Add(this.cbParameter);
            this.Controls.Add(this.lbPartList);
            this.Name = "Part_alter";
            this.Text = "Part_add";
            this.Load += new System.EventHandler(this.AdatokFeltoltese);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPartList;
        private System.Windows.Forms.ComboBox cbParameter;
        private System.Windows.Forms.Label lblNewVal;
        private System.Windows.Forms.TextBox txtNewVal;
        private System.Windows.Forms.Button btnAlter;
    }
}
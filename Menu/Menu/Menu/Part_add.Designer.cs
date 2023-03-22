
namespace Menu
{
    partial class Part_add
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblNumber_Rack = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPartList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(375, 59);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(42, 16);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Tipus";
            // 
            // lblNumber_Rack
            // 
            this.lblNumber_Rack.AutoSize = true;
            this.lblNumber_Rack.Location = new System.Drawing.Point(375, 105);
            this.lblNumber_Rack.Name = "lblNumber_Rack";
            this.lblNumber_Rack.Size = new System.Drawing.Size(90, 16);
            this.lblNumber_Rack.TabIndex = 1;
            this.lblNumber_Rack.Text = "Darab/rekesz";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(375, 150);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(21, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Ár";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(577, 196);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Feltöltés";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.AddingPart);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(470, 53);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(182, 22);
            this.txtType.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(470, 102);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(182, 22);
            this.txtNumber.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(470, 147);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(182, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // lbPartList
            // 
            this.lbPartList.FormattingEnabled = true;
            this.lbPartList.ItemHeight = 16;
            this.lbPartList.Location = new System.Drawing.Point(12, 53);
            this.lbPartList.Name = "lbPartList";
            this.lbPartList.Size = new System.Drawing.Size(357, 180);
            this.lbPartList.TabIndex = 7;
            // 
            // Part_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 295);
            this.Controls.Add(this.lbPartList);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNumber_Rack);
            this.Controls.Add(this.lblType);
            this.Name = "Part_add";
            this.Text = "Part_add";
            this.Load += new System.EventHandler(this.AdatokFeltoltese);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblNumber_Rack;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ListBox lbPartList;
    }
}
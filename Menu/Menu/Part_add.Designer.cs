﻿
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
            this.partListUC1 = new Menu.PartListUC();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(178, 379);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(42, 16);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Tipus";
            // 
            // lblNumber_Rack
            // 
            this.lblNumber_Rack.AutoSize = true;
            this.lblNumber_Rack.Location = new System.Drawing.Point(178, 432);
            this.lblNumber_Rack.Name = "lblNumber_Rack";
            this.lblNumber_Rack.Size = new System.Drawing.Size(90, 16);
            this.lblNumber_Rack.TabIndex = 1;
            this.lblNumber_Rack.Text = "Darab/rekesz";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(178, 477);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(21, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Ár";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(380, 523);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Feltöltés";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.AddingPart);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(272, 373);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(183, 22);
            this.txtType.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(272, 429);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(183, 22);
            this.txtNumber.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(272, 473);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(183, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // partListUC1
            // 
            this.partListUC1.Location = new System.Drawing.Point(-3, 4);
            this.partListUC1.Margin = new System.Windows.Forms.Padding(4);
            this.partListUC1.Name = "partListUC1";
            this.partListUC1.Size = new System.Drawing.Size(640, 351);
            this.partListUC1.TabIndex = 8;
            // 
            // Part_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 592);
            this.Controls.Add(this.partListUC1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNumber_Rack);
            this.Controls.Add(this.lblType);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Part_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private PartListUC partListUC1;
    }
}

namespace Menu
{
    partial class Raktarvez_GUI
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
            this.btnPartAdd = new System.Windows.Forms.Button();
            this.btnPartAlter = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPartAdd
            // 
            this.btnPartAdd.Location = new System.Drawing.Point(93, 95);
            this.btnPartAdd.Name = "btnPartAdd";
            this.btnPartAdd.Size = new System.Drawing.Size(189, 23);
            this.btnPartAdd.TabIndex = 0;
            this.btnPartAdd.Text = "Alkatrész hozzáadása";
            this.btnPartAdd.UseVisualStyleBackColor = true;
            this.btnPartAdd.Click += new System.EventHandler(this.Part_Add_Open);
            // 
            // btnPartAlter
            // 
            this.btnPartAlter.Location = new System.Drawing.Point(76, 133);
            this.btnPartAlter.Name = "btnPartAlter";
            this.btnPartAlter.Size = new System.Drawing.Size(216, 23);
            this.btnPartAlter.TabIndex = 1;
            this.btnPartAlter.Text = "Alkatrész adatának módosítása";
            this.btnPartAlter.UseVisualStyleBackColor = true;
            this.btnPartAlter.Click += new System.EventHandler(this.Part_Alter_Open);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kilépés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LogOut);
            // 
            // Raktarvez_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 384);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPartAlter);
            this.Controls.Add(this.btnPartAdd);
            this.Name = "Raktarvez_GUI";
            this.Text = "9999";
            this.Load += new System.EventHandler(this.getRaktarvezData);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPartAdd;
        private System.Windows.Forms.Button btnPartAlter;
        private System.Windows.Forms.Button button3;
    }
}
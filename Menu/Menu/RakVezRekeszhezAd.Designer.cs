namespace Menu
{
    partial class RakVezRekeszhezAd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tBAlkatresz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBMennyiseg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBSor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBOszlop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBSzint = new System.Windows.Forms.TextBox();
            this.dGVAlkatreszek = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlkatreszek)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Elhelyez";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBAlkatresz
            // 
            this.tBAlkatresz.Location = new System.Drawing.Point(615, 28);
            this.tBAlkatresz.Name = "tBAlkatresz";
            this.tBAlkatresz.Size = new System.Drawing.Size(237, 22);
            this.tBAlkatresz.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alkatrész Neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Beérkezett mennyiség:";
            // 
            // tBMennyiseg
            // 
            this.tBMennyiseg.Location = new System.Drawing.Point(615, 78);
            this.tBMennyiseg.Name = "tBMennyiseg";
            this.tBMennyiseg.Size = new System.Drawing.Size(237, 22);
            this.tBMennyiseg.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rekesz Sor:";
            // 
            // tBSor
            // 
            this.tBSor.Location = new System.Drawing.Point(615, 132);
            this.tBSor.Name = "tBSor";
            this.tBSor.Size = new System.Drawing.Size(237, 22);
            this.tBSor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rekesz Oszlop:";
            // 
            // tBOszlop
            // 
            this.tBOszlop.Location = new System.Drawing.Point(615, 179);
            this.tBOszlop.Name = "tBOszlop";
            this.tBOszlop.Size = new System.Drawing.Size(237, 22);
            this.tBOszlop.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rekesz Szint:";
            // 
            // tBSzint
            // 
            this.tBSzint.Location = new System.Drawing.Point(615, 235);
            this.tBSzint.Name = "tBSzint";
            this.tBSzint.Size = new System.Drawing.Size(237, 22);
            this.tBSzint.TabIndex = 9;
            // 
            // dGVAlkatreszek
            // 
            this.dGVAlkatreszek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAlkatreszek.Location = new System.Drawing.Point(3, 10);
            this.dGVAlkatreszek.Name = "dGVAlkatreszek";
            this.dGVAlkatreszek.RowHeadersWidth = 51;
            this.dGVAlkatreszek.RowTemplate.Height = 24;
            this.dGVAlkatreszek.Size = new System.Drawing.Size(603, 275);
            this.dGVAlkatreszek.TabIndex = 11;
            this.dGVAlkatreszek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SetAlkatresz);
            // 
            // RakVezRekeszhezAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dGVAlkatreszek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBSzint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBOszlop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBSor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBMennyiseg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBAlkatresz);
            this.Controls.Add(this.button1);
            this.Name = "RakVezRekeszhezAd";
            this.Size = new System.Drawing.Size(860, 296);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlkatreszek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tBAlkatresz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBMennyiseg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBSor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBOszlop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBSzint;
        private System.Windows.Forms.DataGridView dGVAlkatreszek;
    }
}


namespace Menu
{
    partial class SzakemberListPart
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
            this.btnFrissit = new System.Windows.Forms.Button();
            this.szakemberAlkatreszDGW = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.szakemberAlkatreszDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFrissit
            // 
            this.btnFrissit.Location = new System.Drawing.Point(198, 278);
            this.btnFrissit.Name = "btnFrissit";
            this.btnFrissit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFrissit.Size = new System.Drawing.Size(75, 23);
            this.btnFrissit.TabIndex = 1;
            this.btnFrissit.Text = "frissít";
            this.btnFrissit.UseVisualStyleBackColor = true;
            this.btnFrissit.Click += new System.EventHandler(this.btnFrissit_Click);
            // 
            // szakemberAlkatreszDGW
            // 
            this.szakemberAlkatreszDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.szakemberAlkatreszDGW.Location = new System.Drawing.Point(20, 33);
            this.szakemberAlkatreszDGW.Name = "szakemberAlkatreszDGW";
            this.szakemberAlkatreszDGW.Size = new System.Drawing.Size(342, 222);
            this.szakemberAlkatreszDGW.TabIndex = 2;
            this.szakemberAlkatreszDGW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.szakemberAlkatreszDGW_CellContentClick);
            // 
            // SzakemberListPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.szakemberAlkatreszDGW);
            this.Controls.Add(this.btnFrissit);
            this.Name = "SzakemberListPart";
            this.Size = new System.Drawing.Size(374, 322);
            this.Load += new System.EventHandler(this.SzakemberListPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.szakemberAlkatreszDGW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFrissit;
        private System.Windows.Forms.DataGridView szakemberAlkatreszDGW;
    }
}

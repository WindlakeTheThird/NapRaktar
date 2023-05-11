
namespace Menu
{
    partial class HianyzoAlkatresz
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
            this.dGVHiany = new System.Windows.Forms.DataGridView();
            this.lblVegyes = new System.Windows.Forms.Label();
            this.lblLefoglalt = new System.Windows.Forms.Label();
            this.dgwLefoglalt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHiany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLefoglalt)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVHiany
            // 
            this.dGVHiany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHiany.Location = new System.Drawing.Point(24, 43);
            this.dGVHiany.Name = "dGVHiany";
            this.dGVHiany.RowHeadersWidth = 51;
            this.dGVHiany.RowTemplate.Height = 24;
            this.dGVHiany.Size = new System.Drawing.Size(708, 201);
            this.dGVHiany.TabIndex = 0;
            // 
            // lblVegyes
            // 
            this.lblVegyes.AutoSize = true;
            this.lblVegyes.Location = new System.Drawing.Point(21, 9);
            this.lblVegyes.Name = "lblVegyes";
            this.lblVegyes.Size = new System.Drawing.Size(238, 16);
            this.lblVegyes.TabIndex = 1;
            this.lblVegyes.Text = "A lefoglalt és hiányzó elemek listázása";
            // 
            // lblLefoglalt
            // 
            this.lblLefoglalt.AutoSize = true;
            this.lblLefoglalt.Location = new System.Drawing.Point(21, 275);
            this.lblLefoglalt.Name = "lblLefoglalt";
            this.lblLefoglalt.Size = new System.Drawing.Size(171, 16);
            this.lblLefoglalt.TabIndex = 3;
            this.lblLefoglalt.Text = "A lefoglalt elemek listázása";
            // 
            // dgwLefoglalt
            // 
            this.dgwLefoglalt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLefoglalt.Location = new System.Drawing.Point(24, 310);
            this.dgwLefoglalt.Name = "dgwLefoglalt";
            this.dgwLefoglalt.RowHeadersWidth = 51;
            this.dgwLefoglalt.RowTemplate.Height = 24;
            this.dgwLefoglalt.Size = new System.Drawing.Size(708, 201);
            this.dgwLefoglalt.TabIndex = 2;
            // 
            // HianyzoAlkatresz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 512);
            this.Controls.Add(this.lblLefoglalt);
            this.Controls.Add(this.dgwLefoglalt);
            this.Controls.Add(this.lblVegyes);
            this.Controls.Add(this.dGVHiany);
            this.Name = "HianyzoAlkatresz";
            this.Text = "HianyzoAlkatreszListaz";
            ((System.ComponentModel.ISupportInitialize)(this.dGVHiany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLefoglalt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVHiany;
        private System.Windows.Forms.Label lblVegyes;
        private System.Windows.Forms.Label lblLefoglalt;
        private System.Windows.Forms.DataGridView dgwLefoglalt;
    }
}
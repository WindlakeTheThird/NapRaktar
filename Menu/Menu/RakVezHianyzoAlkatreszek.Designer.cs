
namespace Menu
{
    partial class RakVezHianyzoAlkatreszek
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
            this.dGVHiany = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHiany)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVHiany
            // 
            this.dGVHiany.AllowUserToAddRows = false;
            this.dGVHiany.AllowUserToDeleteRows = false;
            this.dGVHiany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHiany.Location = new System.Drawing.Point(4, 4);
            this.dGVHiany.Name = "dGVHiany";
            this.dGVHiany.ReadOnly = true;
            this.dGVHiany.RowHeadersWidth = 51;
            this.dGVHiany.RowTemplate.Height = 24;
            this.dGVHiany.Size = new System.Drawing.Size(827, 492);
            this.dGVHiany.TabIndex = 0;
            // 
            // RakVezHianyzoAlkatreszek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dGVHiany);
            this.Name = "RakVezHianyzoAlkatreszek";
            this.Size = new System.Drawing.Size(834, 499);
            ((System.ComponentModel.ISupportInitialize)(this.dGVHiany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVHiany;
    }
}

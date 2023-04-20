
namespace Menu
{
    partial class PartOrderUC
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
            this.dgwPartList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPartList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPartList
            // 
            this.dgwPartList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPartList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwPartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPartList.Location = new System.Drawing.Point(42, 23);
            this.dgwPartList.Name = "dgwPartList";
            this.dgwPartList.RowHeadersVisible = false;
            this.dgwPartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPartList.Size = new System.Drawing.Size(297, 109);
            this.dgwPartList.TabIndex = 0;
            // 
            // PartOrderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgwPartList);
            this.Name = "PartOrderUC";
            this.Size = new System.Drawing.Size(374, 173);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPartList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPartList;
    }
}

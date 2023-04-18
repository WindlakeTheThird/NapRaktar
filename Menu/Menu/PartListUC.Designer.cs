
namespace Menu
{
    partial class PartListUC
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
            this.lbPartList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbPartList
            // 
            this.lbPartList.FormattingEnabled = true;
            this.lbPartList.ItemHeight = 16;
            this.lbPartList.Location = new System.Drawing.Point(18, 2);
            this.lbPartList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPartList.Name = "lbPartList";
            this.lbPartList.Size = new System.Drawing.Size(601, 324);
            this.lbPartList.TabIndex = 1;
            // 
            // PartListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbPartList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PartListUC";
            this.Size = new System.Drawing.Size(640, 351);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPartList;
    }
}

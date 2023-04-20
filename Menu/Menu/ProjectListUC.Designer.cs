
namespace Menu
{
    partial class ProjectListUC
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
            this.lbListPorjects = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbListPorjects
            // 
            this.lbListPorjects.FormattingEnabled = true;
            this.lbListPorjects.Location = new System.Drawing.Point(27, 29);
            this.lbListPorjects.Name = "lbListPorjects";
            this.lbListPorjects.Size = new System.Drawing.Size(743, 251);
            this.lbListPorjects.TabIndex = 0;
            // 
            // ProjectListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbListPorjects);
            this.Name = "ProjectListUC";
            this.Size = new System.Drawing.Size(789, 297);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListPorjects;
    }
}

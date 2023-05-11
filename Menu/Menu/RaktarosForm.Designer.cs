
namespace Menu
{
    partial class RaktarosForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.projectListUC1 = new Menu.ProjectListUC();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Projektmegkezdése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projectListUC1
            // 
            this.projectListUC1.Location = new System.Drawing.Point(12, 12);
            this.projectListUC1.Name = "projectListUC1";
            this.projectListUC1.Size = new System.Drawing.Size(789, 297);
            this.projectListUC1.TabIndex = 0;
            // 
            // RaktarosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.projectListUC1);
            this.Name = "RaktarosForm";
            this.Text = "RaktarosForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ProjectListUC projectListUC1;
        private System.Windows.Forms.Button button1;
    }
}

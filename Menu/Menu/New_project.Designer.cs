
namespace Menu
{
    partial class New_project
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
            this.projectListUC1 = new Menu.ProjectListUC();
            this.projectAddUC1 = new Menu.ProjectAddUC();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectListUC1
            // 
            this.projectListUC1.Location = new System.Drawing.Point(2, -1);
            this.projectListUC1.Name = "projectListUC1";
            this.projectListUC1.Size = new System.Drawing.Size(789, 297);
            this.projectListUC1.TabIndex = 0;
            // 
            // projectAddUC1
            // 
            this.projectAddUC1.Location = new System.Drawing.Point(122, 302);
            this.projectAddUC1.Name = "projectAddUC1";
            this.projectAddUC1.Size = new System.Drawing.Size(278, 244);
            this.projectAddUC1.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(486, 415);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Létrehoz";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.ProjectLetrehozas);
            // 
            // New_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 576);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.projectAddUC1);
            this.Controls.Add(this.projectListUC1);
            this.Name = "New_project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új projekt létrehozása";
            this.ResumeLayout(false);

        }

        #endregion

        private ProjectListUC projectListUC1;
        private ProjectAddUC projectAddUC1;
        private System.Windows.Forms.Button btnUpload;
    }
}
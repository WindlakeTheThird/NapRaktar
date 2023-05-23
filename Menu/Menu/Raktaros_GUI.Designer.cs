
namespace Menu
{
    partial class Raktaros_GUI
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnStartProject = new System.Windows.Forms.Button();
            this.btnProjectPartList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(89, 202);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(56, 19);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Kilépés";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.LogOut);
            // 
            // btnStartProject
            // 
            this.btnStartProject.Location = new System.Drawing.Point(76, 56);
            this.btnStartProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartProject.Name = "btnStartProject";
            this.btnStartProject.Size = new System.Drawing.Size(93, 19);
            this.btnStartProject.TabIndex = 1;
            this.btnStartProject.Text = "Projekt Indítása";
            this.btnStartProject.UseVisualStyleBackColor = true;
            this.btnStartProject.Click += new System.EventHandler(this.ProjectStart);
            // 
            // btnProjectPartList
            // 
            this.btnProjectPartList.Location = new System.Drawing.Point(18, 88);
            this.btnProjectPartList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProjectPartList.Name = "btnProjectPartList";
            this.btnProjectPartList.Size = new System.Drawing.Size(220, 38);
            this.btnProjectPartList.TabIndex = 2;
            this.btnProjectPartList.Text = "Projekthez tartozó részek helyének listázása";
            this.btnProjectPartList.UseVisualStyleBackColor = true;
            this.btnProjectPartList.Click += new System.EventHandler(this.ProjectPartList);
            // 
            // Raktaros_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 260);
            this.Controls.Add(this.btnProjectPartList);
            this.Controls.Add(this.btnStartProject);
            this.Controls.Add(this.btnQuit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Raktaros_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raktaros_GUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnStartProject;
        private System.Windows.Forms.Button btnProjectPartList;
    }
}
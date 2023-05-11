
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
            this.btnQuit.Location = new System.Drawing.Point(119, 248);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Kilépés";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.LogOut);
            // 
            // btnStartProject
            // 
            this.btnStartProject.Location = new System.Drawing.Point(101, 69);
            this.btnStartProject.Name = "btnStartProject";
            this.btnStartProject.Size = new System.Drawing.Size(124, 23);
            this.btnStartProject.TabIndex = 1;
            this.btnStartProject.Text = "Projekt Indítása";
            this.btnStartProject.UseVisualStyleBackColor = true;
            this.btnStartProject.Click += new System.EventHandler(this.ProjectStart);
            // 
            // btnProjectPartList
            // 
            this.btnProjectPartList.Location = new System.Drawing.Point(24, 108);
            this.btnProjectPartList.Name = "btnProjectPartList";
            this.btnProjectPartList.Size = new System.Drawing.Size(293, 23);
            this.btnProjectPartList.TabIndex = 2;
            this.btnProjectPartList.Text = "Projekthez tartozó részek helyének listázása";
            this.btnProjectPartList.UseVisualStyleBackColor = true;
            this.btnProjectPartList.Click += new System.EventHandler(this.ProjectPartList);
            // 
            // Raktaros_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 320);
            this.Controls.Add(this.btnProjectPartList);
            this.Controls.Add(this.btnStartProject);
            this.Controls.Add(this.btnQuit);
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
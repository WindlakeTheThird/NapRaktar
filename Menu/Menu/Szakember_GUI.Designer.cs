
namespace Menu
{
    partial class Szakember_GUI
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnUjProjekt = new System.Windows.Forms.Button();
            this.btnKoltseg = new System.Windows.Forms.Button();
            this.btnPartToProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 284);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kilépés";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnUjProjekt
            // 
            this.btnUjProjekt.Location = new System.Drawing.Point(72, 82);
            this.btnUjProjekt.Name = "btnUjProjekt";
            this.btnUjProjekt.Size = new System.Drawing.Size(130, 23);
            this.btnUjProjekt.TabIndex = 4;
            this.btnUjProjekt.Text = "Új projekt létrehozása";
            this.btnUjProjekt.UseVisualStyleBackColor = true;
            this.btnUjProjekt.Click += new System.EventHandler(this.UjProjectOpen);
            // 
            // btnKoltseg
            // 
            this.btnKoltseg.Location = new System.Drawing.Point(72, 163);
            this.btnKoltseg.Name = "btnKoltseg";
            this.btnKoltseg.Size = new System.Drawing.Size(125, 23);
            this.btnKoltseg.TabIndex = 5;
            this.btnKoltseg.Text = "Munkadíj megadása";
            this.btnKoltseg.UseVisualStyleBackColor = true;
            this.btnKoltseg.Click += new System.EventHandler(this.ArEsKivitIdo);
            // 
            // btnPartToProject
            // 
            this.btnPartToProject.Location = new System.Drawing.Point(72, 125);
            this.btnPartToProject.Name = "btnPartToProject";
            this.btnPartToProject.Size = new System.Drawing.Size(125, 23);
            this.btnPartToProject.TabIndex = 6;
            this.btnPartToProject.Text = "Alkatrész projekthez rendelése";
            this.btnPartToProject.UseVisualStyleBackColor = true;
            this.btnPartToProject.Click += new System.EventHandler(this.AlkatreszProjektOpen);
            // 
            // Szakember_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 312);
            this.Controls.Add(this.btnPartToProject);
            this.Controls.Add(this.btnKoltseg);
            this.Controls.Add(this.btnUjProjekt);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Szakember_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szakember_GUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUjProjekt;
        private System.Windows.Forms.Button btnKoltseg;
        private System.Windows.Forms.Button btnPartToProject;
    }
}
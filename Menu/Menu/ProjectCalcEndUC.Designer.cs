
namespace Menu
{
    partial class ProjectCalcEndUC
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.projectListUC1 = new Menu.ProjectListUC();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Árukalkuláció";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 302);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 1;
            // 
            // projectListUC1
            // 
            this.projectListUC1.Location = new System.Drawing.Point(15, 3);
            this.projectListUC1.Name = "projectListUC1";
            this.projectListUC1.Size = new System.Drawing.Size(789, 292);
            this.projectListUC1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "Projekt sikeres lezárása";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 20);
            this.button3.TabIndex = 4;
            this.button3.Text = "Projekt sikertelen lezárása";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProjectCalcEndUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.projectListUC1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "ProjectCalcEndUC";
            this.Size = new System.Drawing.Size(887, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private ProjectListUC projectListUC1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

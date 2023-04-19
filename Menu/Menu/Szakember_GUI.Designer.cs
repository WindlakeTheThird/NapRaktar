
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
            this.szakemberListPart1 = new Menu.SzakemberListPart();
            this.szakemberArazas1 = new Menu.SzakemberArazas();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 499);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kilépés";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // szakemberListPart1
            // 
            this.szakemberListPart1.Location = new System.Drawing.Point(12, 135);
            this.szakemberListPart1.Name = "szakemberListPart1";
            this.szakemberListPart1.Size = new System.Drawing.Size(374, 322);
            this.szakemberListPart1.TabIndex = 4;
            // 
            // szakemberArazas1
            // 
            this.szakemberArazas1.Location = new System.Drawing.Point(416, 250);
            this.szakemberArazas1.Name = "szakemberArazas1";
            this.szakemberArazas1.Size = new System.Drawing.Size(356, 191);
            this.szakemberArazas1.TabIndex = 5;
            // 
            // Szakember_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 529);
            this.Controls.Add(this.szakemberArazas1);
            this.Controls.Add(this.szakemberListPart1);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Szakember_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szakember_GUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private SzakemberListPart szakemberListPart1;
        private SzakemberArazas szakemberArazas1;
    }
}
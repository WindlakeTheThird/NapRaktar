
namespace Menu
{
    partial class AlkatreszRekeszhezAdasaForm
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
            this.rakVezRekeszhezAd1 = new Menu.RakVezRekeszhezAd();
            this.SuspendLayout();
            // 
            // rakVezRekeszhezAd1
            // 
            this.rakVezRekeszhezAd1.Location = new System.Drawing.Point(53, 79);
            this.rakVezRekeszhezAd1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rakVezRekeszhezAd1.Name = "rakVezRekeszhezAd1";
            this.rakVezRekeszhezAd1.Size = new System.Drawing.Size(645, 240);
            this.rakVezRekeszhezAd1.TabIndex = 0;
            // 
            // AlkatreszRekeszhezAdasaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 387);
            this.Controls.Add(this.rakVezRekeszhezAd1);
            this.Name = "AlkatreszRekeszhezAdasaForm";
            this.Text = "AlkatreszRekeszhezAdasaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private RakVezRekeszhezAd rakVezRekeszhezAd1;
    }
}
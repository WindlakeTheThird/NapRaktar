
namespace Menu
{
    partial class SetPrice
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
            this.btnSetPriceAndTime = new System.Windows.Forms.Button();
            this.szakemberArazas1 = new Menu.SzakemberArazas();
            this.projectListUC1 = new Menu.ProjectListUC();
            this.SuspendLayout();
            // 
            // btnSetPriceAndTime
            // 
            this.btnSetPriceAndTime.Location = new System.Drawing.Point(47, 395);
            this.btnSetPriceAndTime.Name = "btnSetPriceAndTime";
            this.btnSetPriceAndTime.Size = new System.Drawing.Size(75, 23);
            this.btnSetPriceAndTime.TabIndex = 4;
            this.btnSetPriceAndTime.Text = "Megadás";
            this.btnSetPriceAndTime.UseVisualStyleBackColor = true;
            this.btnSetPriceAndTime.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // szakemberArazas1
            // 
            this.szakemberArazas1.Location = new System.Drawing.Point(27, 299);
            this.szakemberArazas1.Name = "szakemberArazas1";
            this.szakemberArazas1.Size = new System.Drawing.Size(241, 90);
            this.szakemberArazas1.TabIndex = 5;
            // 
            // projectListUC1
            // 
            this.projectListUC1.Location = new System.Drawing.Point(-1, 12);
            this.projectListUC1.Name = "projectListUC1";
            this.projectListUC1.Size = new System.Drawing.Size(789, 297);
            this.projectListUC1.TabIndex = 6;
            // 
            // SetPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projectListUC1);
            this.Controls.Add(this.szakemberArazas1);
            this.Controls.Add(this.btnSetPriceAndTime);
            this.Name = "SetPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetPrice";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSetPriceAndTime;
        private SzakemberArazas szakemberArazas1;
        private ProjectListUC projectListUC1;
    }
}
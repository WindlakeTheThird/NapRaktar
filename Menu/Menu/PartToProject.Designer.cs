
namespace Menu
{
    partial class PartToProject
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
            this.btnOrderPart = new System.Windows.Forms.Button();
            this.txtAmaunt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.partOrderUC1 = new Menu.PartOrderUC();
            this.projectListUC1 = new Menu.ProjectListUC();
            this.SuspendLayout();
            // 
            // btnOrderPart
            // 
            this.btnOrderPart.Location = new System.Drawing.Point(705, 431);
            this.btnOrderPart.Name = "btnOrderPart";
            this.btnOrderPart.Size = new System.Drawing.Size(75, 23);
            this.btnOrderPart.TabIndex = 2;
            this.btnOrderPart.Text = "Rendelés";
            this.btnOrderPart.UseVisualStyleBackColor = true;
            this.btnOrderPart.Click += new System.EventHandler(this.SendOrder);
            // 
            // txtAmaunt
            // 
            this.txtAmaunt.Location = new System.Drawing.Point(504, 362);
            this.txtAmaunt.Name = "txtAmaunt";
            this.txtAmaunt.Size = new System.Drawing.Size(113, 20);
            this.txtAmaunt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mennyiség";
            // 
            // partOrderUC1
            // 
            this.partOrderUC1.Location = new System.Drawing.Point(26, 303);
            this.partOrderUC1.Name = "partOrderUC1";
            this.partOrderUC1.Size = new System.Drawing.Size(657, 265);
            this.partOrderUC1.TabIndex = 1;
            // 
            // projectListUC1
            // 
            this.projectListUC1.Location = new System.Drawing.Point(0, 0);
            this.projectListUC1.Name = "projectListUC1";
            this.projectListUC1.Size = new System.Drawing.Size(789, 297);
            this.projectListUC1.TabIndex = 0;
            // 
            // PartToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmaunt);
            this.Controls.Add(this.btnOrderPart);
            this.Controls.Add(this.partOrderUC1);
            this.Controls.Add(this.projectListUC1);
            this.Name = "PartToProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartToProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectListUC projectListUC1;
        private PartOrderUC partOrderUC1;
        private System.Windows.Forms.Button btnOrderPart;
        private System.Windows.Forms.TextBox txtAmaunt;
        private System.Windows.Forms.Label label1;
    }
}
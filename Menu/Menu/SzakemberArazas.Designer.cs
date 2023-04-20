
namespace Menu
{
    partial class SzakemberArazas
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtpSetTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(23, 26);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 0;
            // 
            // dtpSetTime
            // 
            this.dtpSetTime.Location = new System.Drawing.Point(23, 52);
            this.dtpSetTime.Name = "dtpSetTime";
            this.dtpSetTime.Size = new System.Drawing.Size(200, 20);
            this.dtpSetTime.TabIndex = 1;
            // 
            // SzakemberArazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpSetTime);
            this.Controls.Add(this.txtPrice);
            this.Name = "SzakemberArazas";
            this.Size = new System.Drawing.Size(241, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtpSetTime;
    }
}

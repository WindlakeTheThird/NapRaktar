
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKoltseg = new System.Windows.Forms.TextBox();
            this.datepickerKivitelezesi_ido = new System.Windows.Forms.DateTimePicker();
            this.btnModosit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "kivetelzesi ido:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "koltseg:";
            // 
            // textBoxKoltseg
            // 
            this.textBoxKoltseg.Location = new System.Drawing.Point(111, 87);
            this.textBoxKoltseg.Name = "textBoxKoltseg";
            this.textBoxKoltseg.Size = new System.Drawing.Size(100, 20);
            this.textBoxKoltseg.TabIndex = 4;
            this.textBoxKoltseg.TextChanged += new System.EventHandler(this.textBoxKoltseg_TextChanged);
            // 
            // datepickerKivitelezesi_ido
            // 
            this.datepickerKivitelezesi_ido.Location = new System.Drawing.Point(112, 64);
            this.datepickerKivitelezesi_ido.Name = "datepickerKivitelezesi_ido";
            this.datepickerKivitelezesi_ido.Size = new System.Drawing.Size(200, 20);
            this.datepickerKivitelezesi_ido.TabIndex = 5;
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(111, 125);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(75, 23);
            this.btnModosit.TabIndex = 6;
            this.btnModosit.Text = "Modosit";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // SzakemberArazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.datepickerKivitelezesi_ido);
            this.Controls.Add(this.textBoxKoltseg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SzakemberArazas";
            this.Size = new System.Drawing.Size(356, 191);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKoltseg;
        private System.Windows.Forms.DateTimePicker datepickerKivitelezesi_ido;
        private System.Windows.Forms.Button btnModosit;
    }
}

namespace Menu
{
    partial class Login
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(40, 75);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(208, 22);
            this.txtUser.TabIndex = 0;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(40, 150);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(208, 22);
            this.txtPw.TabIndex = 1;
            this.txtPw.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(87, 193);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(119, 23);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Belépés";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.Alkalmazott_Login);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(40, 43);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(103, 16);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Felhasználónév";
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Location = new System.Drawing.Point(40, 128);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(47, 16);
            this.lblPasswd.TabIndex = 4;
            this.lblPasswd.Text = "Jelszó";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 253);
            this.Controls.Add(this.lblPasswd);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtUser);
            this.Name = "Form1";
            this.Text = "Belépés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPasswd;
    }
}


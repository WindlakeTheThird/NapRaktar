using System;
using IOFunction_lib;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class ProjectCalcEndUC : UserControl
    {
        public ProjectCalcEndUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arcalc(projectListUC1.ReturnProjectId());
            MessageBox.Show("A projekt még nem áll készen!", "Hiba", MessageBoxButtons.OK);
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if(projectListUC1.ReturnProjectAllapot() == 4)
                Success();
            else
                MessageBox.Show("A projekt még el sem kezdődött!", "Hiba", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (projectListUC1.ReturnProjectAllapot() == 4)
                Failure();
            else
                MessageBox.Show("A projekt még el sem kezdődött!", "Hiba", MessageBoxButtons.OK);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (projectListUC1.ReturnProjectAllapot() == 1)
                if(!vare())
                    toWait();
                else
                    MessageBox.Show("A projekt még meg nem érkezett alkatrészekre vár!", "Hiba", MessageBoxButtons.OK);
            else
                MessageBox.Show("A projekt nem \"draft\" állapotban van!", "Hiba", MessageBoxButtons.OK);
        }
        public void arcalc(int id)
        {
            if (projectListUC1.ReturnProjectAllapot() == 2)
            {
                double sum = 0;
                string query = $" SELECT rekesz.mennyi,alkatresz.ar from alkatresz join rekesz on alkatresz.tipus_id = rekesz.alkatresz_id where rekesz.project_id={id}";
                sum += Connector.ConnectToDatabase_read_alkatresz_arak("127.0.0.1", "3306", "root", "toor", "napelem", query);
                query = $" SELECT koltseg from projekt  where id={id}";
                sum += Connector.ConnectToDatabase_read_projekt_munka_ber("127.0.0.1", "3306", "root", "toor", "napelem", query);
                query = $"update projekt set koltseg={sum} where id={id}";
                Connector.ConnectToDatabase_update("127.0.0.1", "3306", "root", "toor", "napelem", query);
                query = $"update projekt set allapot=3 where id={id}";
                Connector.ConnectToDatabase_update("127.0.0.1", "3306", "root", "toor", "napelem", query);
                textBox1.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("A projekt nem \"wait\" állapotban van még!", "Hiba", MessageBoxButtons.OK);
            }
            tolts();
        }
        public void Success()
        {
            int id = projectListUC1.ReturnProjectId();
            if (id >= 0)
            {
                string query = $" update projekt set allapot=5 where id={id}";
                Connector.ConnectToDatabase_change_project_state("127.0.0.1", "3306", "root", "toor", "napelem", query);
                query = $" update rendeles set rendeles_allapot=2 where projekt_id={id}";
                Connector.ConnectToDatabase_change_project_koltseg("127.0.0.1", "3306", "root", "toor", "napelem", query);
                query = $" update rekesz set mennyi=0 and project_id and alkatresz_id=0 where project_id={id}";
                Connector.ConnectToDatabase_change_project_koltseg("127.0.0.1", "3306", "root", "toor", "napelem", query);
            }
            tolts();
        }

        public void Failure()
        {
            int id = projectListUC1.ReturnProjectId();
            if (id >= 0)
            {
                string query = $"update projekt set allapot=2 where id={id}";
                Connector.ConnectToDatabase_change_project_state("127.0.0.1", "3306", "root", "toor", "napelem", query);
                query = $" update rekesz set mennyi=0 and project_id and alkatresz_id=0 where project_id={id}";
                Connector.ConnectToDatabase_change_project_koltseg("127.0.0.1", "3306", "root", "toor", "napelem", query);
            }
            tolts();
        }
        public void toWait()
        {
            int id = projectListUC1.ReturnProjectId();
            if (id >= 0)
            {
                string query = $"update projekt set allapot=2 where id={id}";
                Connector.ConnectToDatabase_change_project_state("127.0.0.1", "3306", "root", "toor", "napelem", query);
                query = $" update rendeles set rendeles_allapot=2 where projekt_id={id}";
                Connector.ConnectToDatabase_change_project_koltseg("127.0.0.1", "3306", "root", "toor", "napelem", query);
            }
            tolts();
        }

        public void tolts()
        {
            projectListUC1.adatok2();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.projectListUC1 = new Menu.ProjectListUC();
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(653, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 19);
            this.button4.TabIndex = 5;
            this.button4.Text = "Helyszínfelmérése kész";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // projectListUC1
            // 
            this.projectListUC1.Location = new System.Drawing.Point(15, 3);
            this.projectListUC1.Name = "projectListUC1";
            this.projectListUC1.Size = new System.Drawing.Size(789, 292);
            this.projectListUC1.TabIndex = 2;
            // 
            // ProjectCalcEndUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
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


        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private ProjectListUC projectListUC1;
        private System.Windows.Forms.Button button2;
        private Button button4;
        private System.Windows.Forms.Button button3;

        private bool vare()
        {
            int id = projectListUC1.ReturnProjectId();
            int db = Connector.ConnectToDatabase_list_rendid(id);
            if (db == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        
    }
}

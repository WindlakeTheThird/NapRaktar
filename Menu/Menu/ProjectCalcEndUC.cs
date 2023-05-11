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
        }

        public void arcalc(int id)
        {
            double sum = 0;
            string query = $" SELECT r.mennyi,a.ar from alkatresz a join rekesz r on alkatresz.tipus_id = rekesz.alkatresz_id where r.projekt_id={id}";
            sum +=Connector.ConnectToDatabase_read_alkatresz_arak("127.0.0.1", "3306", "root", "toor", "napelem", query);
            query = $" SELECT koltseg from projekt  where id={id}";
            sum += Connector.ConnectToDatabase_read_projekt_munka_ber("127.0.0.1", "3306", "root", "toor", "napelem", query);
            query = $"update projekt set koltseg={sum} where id={id}";
            textBox1.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Success();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Failure();
        }
        public void Success()
        {
            int id = projectListUC1.ReturnProjectId();
            if (id >= 0)
            {
                string query = $" update projekt set allapot=5 where id={id}";
                Connector.ConnectToDatabase_change_project_state("127.0.0.1", "3306", "root", "toor", "napelem", query);
                query = $" update rendeles set allapot=5 where id={id}";
            }
        }

        public void Failure()
        {
            int id = projectListUC1.ReturnProjectId();
            if (id >= 0)
            {
                string query = $"update projekt set allapot=6 where id={id}";
                Connector.ConnectToDatabase_change_project_state("127.0.0.1", "3306", "root", "toor", "napelem", query);
            }
        }
    }
}

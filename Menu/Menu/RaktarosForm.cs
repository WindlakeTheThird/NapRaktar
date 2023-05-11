using IOFunction_lib;
using System;
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
    public partial class RaktarosForm : Form
    {
        public RaktarosForm()
        {
            InitializeComponent();
            projectListUC1.adatok2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = projectListUC1.ReturnProjectId();
            string query = $"update projekt set allapot=4 where id={id}";
            Connector.ConnectToDatabase_change_project_state("127.0.0.1", "3306", "root", "toor", "napelem", query);
            projectListUC1.adatok2();
        }
    }
}

using MySql.Data.MySqlClient;
using napelemosztalyok.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace napelemosztalyok.usec
{
    public partial class ProjectListUC : UserControl
    {
        public ProjectListUC()
        {
            InitializeComponent();
            adatok();
        }
        public void adatok()
        {
            List<Project> projects = new List<Project>();
            string Query = "Select * from napelem.projekt";
            string MyConnection2 = "datasource=localhost;username=root;password=;Convert Zero Datetime=True";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.  
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            MessageBox.Show("Database exists");

            while (MyReader2.Read())
            {
                projects.Add(new Project(Convert.ToInt32(
                        MyReader2.GetString(0)),
                        MyReader2.GetString(1),
                        Convert.ToInt32(MyReader2.GetString(2)),
                        Convert.ToInt32(MyReader2.GetString(3)),
                        Convert.ToInt32(MyReader2.GetString(4)),
                        MyReader2.GetDateTime(5).ToString(),
                        MyReader2.GetString(6),
                        MyReader2.GetString(7),
                        MyReader2.GetString(8)));
            }
            MyConn2.Close();


            if (projects.Count != 0)
            {
                string sor = "";
                listBox1.Items.Add("ID\tProjekt név\tSzakember azonosító\tÁllapot\tKöltség\tKivitelezési idő\tHelyszín\tLeírás\tMegrendelő elérhetőség");
                listBox1.SelectedIndex = 0;
                foreach (Project item in projects)
                {
                    sor = $"{item.id}\t{item.projektnev}\t{item.szid}\t{item.allapot}\t{item.koltseg}\t{item.kivido.ToString()}\t{item.helyszin}\t{item.leiras}\t{item.elerhetoseg}";
                    listBox1.Items.Add(sor);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adatok();
        }
    }
}

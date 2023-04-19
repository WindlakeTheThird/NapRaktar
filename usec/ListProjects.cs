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
    public partial class ListProjects : UserControl
    {
        public ListProjects()
        {
            InitializeComponent();
            string Query = "Select * from projekt";
            string MyConnection2 = "datasource=localhost;username=root;password=";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.  
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            MessageBox.Show("Database exists");
            List<Project> projects = new List<Project>();
            while (MyReader2.Read())
            {
                projects.Add(new Project(Convert.ToInt32(
                        MyReader2.GetString(0)),
                        MyReader2.GetString(1),
                        Convert.ToInt32(MyReader2.GetString(2)),
                        Convert.ToInt32(MyReader2.GetString(3)),
                        Convert.ToInt32(MyReader2.GetString(4)),
                       MyReader2.GetString(5),
                        MyReader2.GetString(6),
                        MyReader2.GetString(7),
                        MyReader2.GetString(8)));
            }
            MyConn2.Close();


            if (projects.Count != 0)
            {
                string sor = "";
                listBox1.Items.Add("ID  -   Projekt név -   Szakember azonosító -   Állapot -   Költség -   Kivitelezési idő    -   Helyszín    -   Leírás  -   Megrendelő elérhetőség");
                listBox1.SelectedIndex = 0;
                foreach (Project item in projects)
                {
                    sor = $"{item.id}   {item.projektnev}   {item.szid} {item.allapot}  {item.koltseg}  {item.kivido.ToString()}    {item.helyszin} {item.leiras}   {item.elerhetoseg}";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

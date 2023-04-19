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
    public partial class AddProject : UserControl
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Project felt = new Project(0, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            string Query = "insert into napelem.projekt (projekt_nev,szakember_id,allapot,koltseg,kivitelezesi_ido,helyszin,leiras,megrendelo_elerhetoseg) values ("+felt.newProject()+")";
            string MyConnection = "datasource=localhost;username=root;password=";
            MySqlConnection MyConn = new MySqlConnection(MyConnection);
            //This is command class which will handle the query and connection object.  
            MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            while (MyReader.Read())
            {
            }
            MyConn.Close();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Menu
{
    public partial class SzakemberListPart : UserControl
    {
        string cs = @"server=localhost;username=root;password=;database=napelem";

        public SzakemberListPart()
        {
            InitializeComponent();
        }


        public void szakemberAlkatreszListazas()
        {
            string Query = $" SELECT tipus,ar,SUM(rekesz.mennyi)AS darabszám from alkatresz join rekesz " +
                            $"on alkatresz.tipus_id = rekesz.alkatresz_id group by tipus";
            MySqlConnection con = new MySqlConnection(cs);
            //This is command class which will handle the query and connection object.  
            MySqlCommand myCommand = new MySqlCommand(Query, con);
            con.Open();
            MySqlDataReader myReader;
            DataTable table = new DataTable();
            myReader = myCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.
            table.Load(myReader);
            szakemberAlkatreszDGW.DataSource = table;
            con.Close();
        }

        private void szakemberAlkatreszDGW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SzakemberListPart_Load(object sender, EventArgs e)
        {
            szakemberAlkatreszListazas();
        }

        private void btnFrissit_Click(object sender, EventArgs e)
        {
            szakemberAlkatreszListazas();
        }
    }
}

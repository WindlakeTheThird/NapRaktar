using MySql.Data.MySqlClient;
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
    public partial class SzakemberArazas : UserControl
    {

        string cs = @"server=localhost;username=root;password=;database=napelem";
        public SzakemberArazas()
        {
            InitializeComponent();
        }

        public void projektKoltseg_Date_modositas(int szakember_id=1)

        {
            DateTime kivitelezesi_ido = datepickerKivitelezesi_ido.Value;
            int koltseg = Convert.ToInt32(textBoxKoltseg.Text);
            string Query = $" UPDATE projekt" +
                $" SET koltseg={koltseg},kivitelezesi_ido={kivitelezesi_ido.ToString()}" +
                $" where szakember_id={szakember_id}";
            
            MySqlConnection con = new MySqlConnection(cs);
            //This is command class which will handle the query and connection object.  
            MySqlCommand myCommand = new MySqlCommand(Query, con);
            MySqlDataReader myReader;

            con.Open();
            myReader=myCommand.ExecuteReader();
            while (myReader.Read())
            {

            }
            
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKoltseg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            projektKoltseg_Date_modositas();
        }
    }
}

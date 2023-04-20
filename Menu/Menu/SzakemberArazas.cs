using Class_library;
using IOFunction_lib;
﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class SzakemberArazas : UserControl
    {
        Szakember worker= (Szakember)Login.worker;
        string cs = @"server=localhost;username=root;password=;database=napelem";
        public SzakemberArazas()
        {
            InitializeComponent();
        }
        public void projektKoltseg_Date_modositas(int projekt_id)

        {
            string kivitelezesi_ido = (Math.Ceiling((double)dtpSetTime.Value.Subtract(DateTime.Now).TotalDays)).ToString();
            int koltseg = Convert.ToInt32(txtPrice.Text);
            string query = $" UPDATE projekt SET koltseg={koltseg},kivitelezesi_ido={kivitelezesi_ido.ToString()} where id={projekt_id}";

            /*MySqlConnection con = new MySqlConnection(cs);

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
            myReader = myCommand.ExecuteReader();
            myReader=myCommand.ExecuteReader();
            while (myReader.Read())
            {

            }

            con.Close();*/
            Connector.ConnectToDatabase_read_rek_2("127.0.0.1", "3306", "root", "toor", "napelem", query);
        }
        public string ReturntxtVal()
        {
            return txtPrice.Text;
        }
        public DateTime ReturnePickedDate()
        {
            return dtpSetTime.Value;
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
            projektKoltseg_Date_modositas(worker.Id);
        }
    }
}

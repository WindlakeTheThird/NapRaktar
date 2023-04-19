using Class_library;
using IOFunction_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class RakVezRekeszhezAd : UserControl
    {

        List<Part> parts;
        int selectedPart;
        int partMax;

        public RakVezRekeszhezAd()
        {
            InitializeComponent();
            TablaFeltolt();
        }

        private void TablaFeltolt()
        {
            parts = Connector.ConnectToDatabase_list_parts("127.0.0.1", "3306", "root", "toor", "napelem");
            BindingList<Part> list = new BindingList<Part>();
            foreach (Part part in parts)
            {
                list.Add(part);
            }
            dGVAlkatreszek.DataSource = list;
            dGVAlkatreszek.Update();
            dGVAlkatreszek.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(tBMennyiseg.Text)>partMax)
            {
                string query = $"insert into rekesz(sor, oszlop, szint, alkatresz_id, mennyi) values({tBSor.Text.Trim()},{tBOszlop.Text.Trim()},{tBSzint.Text.Trim()},{selectedPart},{partMax})";
                string response = Connector.ConnectToDatabase_add_parts("127.0.0.1", "3306", "root", "toor", "napelem", query);
                MessageBox.Show(response, "Update", MessageBoxButtons.OK);
                MessageBox.Show("Több mint egy rekeszre szükség lesz még");
                tBMennyiseg.Text = (int.Parse(tBMennyiseg.Text)-partMax).ToString();
            }
            else
            {
                string query = $"insert into rekesz(sor, oszlop, szint, alkatresz_id, mennyi) values({tBSor.Text.Trim()},{tBOszlop.Text.Trim()},{tBSzint.Text.Trim()},{selectedPart},{tBMennyiseg.Text.Trim()})"; 
                string response = Connector.ConnectToDatabase_add_parts("127.0.0.1", "3306", "root", "toor", "napelem", query);
                MessageBox.Show(response, "Update", MessageBoxButtons.OK);
            }
        }

        private void SetAlkatresz(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            selectedPart = int.Parse(dGVAlkatreszek[0,row].Value.ToString());
            partMax = int.Parse(dGVAlkatreszek[2,row].Value.ToString());
            tBAlkatresz.Text = dGVAlkatreszek[1,row].Value.ToString();
        }
    }
}

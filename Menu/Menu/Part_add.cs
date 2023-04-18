using Class_library;
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
    public partial class Part_add : Form
    {
        public static Raktarvezeto raktvez;
        public Part_add()
        {
            InitializeComponent();
        }
        public void AdatokFeltoltese(object sender, EventArgs e)
        {
            partListUC1.Listazas();
        }
        public void AddingPart(object sender, EventArgs e)
        {
            if(txtNumber.Text.Trim().Length == 0 || txtPrice.Text.Trim().Length == 0 || txtType.Text.Trim().Length == 0)
            {
                MessageBox.Show("Minden mező kitöltése kötelező", "Hiba", MessageBoxButtons.OK);
            }
            else
            {
                if(!int.TryParse(txtNumber.Text.Trim(), out _))
                {
                    MessageBox.Show("A darabszámnak számnak kell lennie", "Hiba", MessageBoxButtons.OK);
                    txtNumber.Clear();
                    txtNumber.Focus();
                }
                else if(!int.TryParse(txtPrice.Text.Trim(), out _))
                {
                    MessageBox.Show("Az árnak számnak kell lennie", "Hiba", MessageBoxButtons.OK);
                    txtPrice.Clear();
                    txtPrice.Focus();
                }
                else
                {
                    string query = $"insert into alkatresz(tipus,darab_rekesz,ar)values('{txtType.Text.Trim()}',{txtNumber.Text.Trim()},{txtPrice.Text.Trim()})";
                    string response = Connector.ConnectToDatabase_add_parts("127.0.0.1", "3306", "root", "toor", "napelem", query);
                    MessageBox.Show(response, "Update", MessageBoxButtons.OK);
                    txtPrice.Clear();
                    txtNumber.Clear();
                    txtType.Clear();
                    partListUC1.Listazas();
                }
            }
        }

    }
}

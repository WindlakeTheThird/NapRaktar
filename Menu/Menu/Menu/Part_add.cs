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
            raktvez = Login.worker;
            lbPartList.Items.Clear();
            List<Part> parts = Connector.ConnectToDatabase_list_parts("127.0.0.1", "3306", "root", "toor", "napelem");
            lbPartList.Items.Add($"Azonosító  -  Tipus/megnevezés - rekeszenkénti darabszám - darab ár");
            lbPartList.SelectedIndex = 0;
            foreach (Part part in parts)
            {
                string sor = "";
                sor += $"{part.Id}  -  {part.Type} - {part.Amount} - {part.Unit_cost}";
                lbPartList.Items.Add(sor);
            }
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
                    lbPartList.Items.Add($"{Convert.ToInt32(lbPartList.Items[lbPartList.Items.Count-1].ToString()[0].ToString())+1}  -  {txtType.Text.Trim()} - {txtNumber.Text.Trim()} - {txtPrice.Text.Trim()}");
                    txtPrice.Clear();
                    txtNumber.Clear();
                    txtType.Clear();
                }
            }
        }
    }
}

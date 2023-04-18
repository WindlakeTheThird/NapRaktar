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
    public partial class Part_alter : Form
    {
        public static Raktarvezeto raktvez;
        public Part_alter()
        {
            InitializeComponent();
        }
        public void AdatokFeltoltese(object sender, EventArgs e)
        {
            raktvez = (Raktarvezeto)Login.worker;
            /*lbPartList.Items.Clear();
            List<Part> parts = Connector.ConnectToDatabase_list_parts("127.0.0.1", "3306", "root", "toor", "napelem");
            lbPartList.Items.Add($"Azonosító  -  Tipus/megnevezés - rekeszenkénti darabszám - darab ár");
            lbPartList.SelectedIndex = 0;
            foreach(Part part in parts)
            {
                string sor = "";
                sor+=$"{part.Id}  -  {part.Type} - {part.Amount} - {part.Unit_cost}";
                lbPartList.Items.Add(sor);
            }*/

            partListUC1.Listazas();
        }
        public void Listazas_UserControllal()
        {
            
            partListUC1.Refresh();
            partListUC1.BringToFront();
        }
        public void Alter_part(object sender,EventArgs e)
        {
            if (txtNewVal.Text.Trim().Length > 0)
            {
                if ((cbParameter.SelectedIndex != 0 && !double.TryParse(txtNewVal.Text, out _)))
                {
                    MessageBox.Show("A megadott értéknek számnak kell lennie!", "Hiba", MessageBoxButtons.OK);
                    txtNewVal.Clear();
                }
                else
                {
                    int selected_index = partListUC1.SelectedIndex();
                    if (selected_index == 0)
                    {
                        MessageBox.Show("A kiválasztott sor nem megfelelő", "Hiba", MessageBoxButtons.OK);
                    }
                    else
                    {

                        string selected_item = partListUC1.SelectedItem(selected_index);
                        string param = "";
                        string query = "";
                        if (cbParameter.SelectedIndex == 0)
                        {
                            param = "tipus";
                        }
                        else if (cbParameter.SelectedIndex == 1)
                        {
                            param = "darab_rekesz";
                        }
                        else if (cbParameter.SelectedIndex == 2)
                        {
                            param = "ar";
                        }
                        if (cbParameter.SelectedIndex == 0)
                        {
                            query = $"update alkatresz set {param} = '{txtNewVal.Text}' where tipus_id = {selected_item}";
                        }
                        else
                        {
                            query = $"update alkatresz set {param} = {txtNewVal.Text} where tipus_id = {selected_item}";
                        }
                        string response = Connector.ConnectToDatabase_update_parts("127.0.0.1", "3306", "root", "toor", "napelem", query);
                        MessageBox.Show(response, "Update", MessageBoxButtons.OK);
                        partListUC1.Listazas();
                        txtNewVal.Clear();
                    }
                }
            }
            
        }
    }
}


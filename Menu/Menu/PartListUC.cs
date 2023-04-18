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
    public partial class PartListUC : UserControl
    {
        public PartListUC()
        {
            InitializeComponent();
        }
        public void Listazas()
        {
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
        public int SelectedIndex()
        {
            return lbPartList.SelectedIndex;
        }
        public string SelectedItem(int index)
        {
            return lbPartList.Items[index].ToString().Split('-')[0].Trim().ToString();
        }
    }
}

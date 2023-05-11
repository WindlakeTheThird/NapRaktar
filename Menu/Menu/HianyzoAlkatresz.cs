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
    public partial class HianyzoAlkatresz : Form
    {
        public HianyzoAlkatresz()
        {
            InitializeComponent();
            Tablafeltolt();
        }

        private void Tablafeltolt()
        {
            string query = "Select rendeles.rendeles_id, rendeles.projekt_id, alkatresz.tipus, rendeles.mennyiseg, rendeles_allapot.allapot_nev from rendeles join rendeles_allapot on rendeles.rendeles_allapot = rendeles_allapot.allapot_id join alkatresz on rendeles.alkatresz = alkatresz.tipus_id";
            DataTable dt = new DataTable();
            dt = Connector.ConnectToDatabase_read_missing_stuff("127.0.0.1", "3306", "root", "toor", "napelem", query);
            dGVHiany.DataSource = dt;
            dGVHiany.Refresh();
            dGVHiany.Update();

            query= "Select rendeles.rendeles_id, rendeles.projekt_id, alkatresz.tipus, rendeles.mennyiseg, rendeles_allapot.allapot_nev from rendeles join rendeles_allapot on rendeles.rendeles_allapot = rendeles_allapot.allapot_id join alkatresz on rendeles.alkatresz = alkatresz.tipus_id where rendeles.rendeles_allapot = 1";


            dgwLefoglalt.DataSource= Connector.ConnectToDatabase_read_missing_stuff("127.0.0.1", "3306", "root", "toor", "napelem", query);
            dgwLefoglalt.Refresh();
            dgwLefoglalt.Update();
        }
    }
}

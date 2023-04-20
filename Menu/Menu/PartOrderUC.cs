using IOFunction_lib;
using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class PartOrderUC : UserControl
    {
        public PartOrderUC()
        {
            InitializeComponent();
        }
        public void szakemberAlkatreszListazas()
        {
            string query = $" SELECT tipus_id,tipus,ar,SUM(rekesz.mennyi)AS darabszám from alkatresz join rekesz on alkatresz.tipus_id = rekesz.alkatresz_id group by tipus";
            dgwPartList.DataSource = Connector.ConnectToDatabase_read_parts_worker("127.0.0.1", "3306", "root", "toor", "napelem", query);

        }
        public int return_part_id()
        {
            if (dgwPartList.SelectedRows.Count == 1)
            {
                int x = Convert.ToInt32(dgwPartList.SelectedRows[0].Cells[0].Value.ToString());
                return x;
            }
            return 0;
        }
        /*public void OrderPart(int alk_id, int mennyiseg, int projekt_id)
        {
            string query = "Select count(*) from napelem.rekesz where alkatresz_id=" + alk_id;
            int s = 0, mkell = mennyiseg, mkellv = mennyiseg;
            int van = Connector.ConnectToDatabase_read_rek_1("127.0.0.1", "3306", "root", "toor", "napelem", query);
            if (van == -1)
            {
                MessageBox.Show("Hiba","Hiba",MessageBoxButtons.OK);
            }
            else
            {
                if (van == 0)
                {
                    query = $"insert into napelem.rendeles (projekt_id,alkatresz,mennyiseg,rendeles_allapot) values ({projekt_id},{alk_id},{mennyiseg},0)";
                    Connector.ConnectToDatabase_read_rek_2("127.0.0.1", "3306", "root", "toor", "napelem", query);
                }
                else
                {
                    Connector.ConnectToDatabase_read_rek_3("127.0.0.1", "3306", "root", "toor", "napelem", projekt_id, alk_id, mennyiseg, mkell, s, mkellv);
                }
            }
            if (mkell > 0)
            {
                query = $"insert into napelem.rendeles (projekt_id,alkatresz,mennyiseg,rendeles_allapot) values ({projekt_id},{alk_id},{mkell},0)";
                Connector.ConnectToDatabase_read_rek_2("127.0.0.1", "3306", "root", "toor", "napelem", query);
                query = $"insert into napelem.rendeles (projekt_id,alkatresz,mennyiseg,rendeles_allapot) values ({projekt_id},{alk_id},{mennyiseg - mkell},1)";
                Connector.ConnectToDatabase_read_rek_2("127.0.0.1", "3306", "root", "toor", "napelem", query);
            }


        }*/
    }
}

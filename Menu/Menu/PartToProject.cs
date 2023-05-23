using Class_library;
using IOFunction_lib;
using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class PartToProject : Form
    {
        Szakember szakember = (Szakember)Login.worker;
        public PartToProject()
        {
            InitializeComponent();
            projectListUC1.adatok(szakember.Id);
            partOrderUC1.szakemberAlkatreszListazas();
        }
        public void OrderPart(int alk_id, int mennyiseg, int projekt_id)
        {
            string query = "Select count(*) from napelem.rekesz where alkatresz_id=" + alk_id+" and project_id=0";
            int s = 0, mkell = mennyiseg, mkellv = mennyiseg;
            int van = Connector.ConnectToDatabase_read_rek_1("127.0.0.1", "3306", "root", "toor", "napelem", query);
            if (van == -1)
            {
                MessageBox.Show("Hiba", "Hiba", MessageBoxButtons.OK);
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
                    Connector.ConnectToDatabase_read_rek_3("127.0.0.1", "3306", "root", "toor", "napelem", projekt_id, alk_id, mennyiseg, ref mkell, ref s, ref mkellv);
                }
            }
            if (mkell > 0)
            {
                query = $"insert into napelem.rendeles (projekt_id,alkatresz,mennyiseg,rendeles_allapot) values ({projekt_id},{alk_id},{mkell},0)";
                Connector.ConnectToDatabase_read_rek_2("127.0.0.1", "3306", "root", "toor", "napelem", query);
                query = $"insert into napelem.rendeles (projekt_id,alkatresz,mennyiseg,rendeles_allapot) values ({projekt_id},{alk_id},{mennyiseg - mkell},1)";
                Connector.ConnectToDatabase_read_rek_2("127.0.0.1", "3306", "root", "toor", "napelem", query);
            }
            query = $"update projekt set allapot = 1 where id={projekt_id}";
            Connector.ConnectToDatabase_read_rek_2("127.0.0.1", "3306", "root", "toor", "napelem", query);

        }

        public void SendOrder(object sender, EventArgs e)
        {

            if (projectListUC1.ReturnProjectId() != -1)
            {
                if (txtAmaunt.Text.Length > 0 && int.TryParse(txtAmaunt.Text, out _))
                {
                    OrderPart(partOrderUC1.return_part_id(), Convert.ToInt32(txtAmaunt.Text), projectListUC1.ReturnProjectId());
                }
                else
                {
                    MessageBox.Show("Adjon meg egy mennyiséget!", "HIBA", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Válaszzon ki egy projektet!", "HIBA", MessageBoxButtons.OK);
            }
            projectListUC1.adatok(szakember.Id);
            partOrderUC1.szakemberAlkatreszListazas();
        }
    }
}

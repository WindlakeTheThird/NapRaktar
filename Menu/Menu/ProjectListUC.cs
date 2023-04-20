using Class_library;
using IOFunction_lib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Menu
{
    public partial class ProjectListUC : UserControl
    {
        public ProjectListUC()
        {
            InitializeComponent();
        }
        public void adatok(int szak_id)
        {
            lbListPorjects.Items.Clear();
            lbListPorjects.Items.Add("ID\tProjekt név\tSzakember azonosító\tÁllapot\tKöltség\tKivitelezési idő\tHelyszín\tLeírás\tMegrendelő elérhetőség");
            List<Project> projects = Connector.ConnectToDatabase_list_projects("127.0.0.1", "3306", "root", "toor", "napelem", szak_id);
            if (projects.Count != 0)
            {
                string sor = "";
                lbListPorjects.SelectedIndex = 0;
                foreach (Project item in projects)
                {
                    sor = $"{item.Id}\t{item.Projektnev}\t{item.Szid}\t{item.Allapot}\t{item.Koltseg}\t{item.Kivido.ToString()}\t{item.Helyszin}\t{item.Leiras}\t{item.Elerhetoseg}";
                    lbListPorjects.Items.Add(sor);
                }
            }
        }
        public int ReturnProjectId()
        {
            if (lbListPorjects.SelectedIndex != 0)
            {
                return Convert.ToInt32(lbListPorjects.SelectedItem.ToString().Split('\t')[0].ToString());
            }
            else
            {
                return -1;
            }
        }
    }
}

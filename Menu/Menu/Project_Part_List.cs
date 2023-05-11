using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_library;
using IOFunction_lib;

namespace Menu
{
    public partial class Project_Part_List : Form
    {
        public Project_Part_List()
        {
            InitializeComponent();
            dataGridView1.DataSource = IOFunction_lib.Connector.ConnectToDatabase_projects_into_data_grid();
            lblOutput.Visible = false;
            
        }
        public void kigyujtes(object sender, EventArgs e)
        {
            Rekeszek_kigyujtese(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
        }
        public void Rekeszek_kigyujtese(int projekt_id)
        {
            lblOutput.Text = "A projekthez tartozó elemek helye és mennyisége:";
            Dictionary<int, List<ProjectPart>> parts_of_the_project = IOFunction_lib.Connector.ConnectToDatabase_part_to_project(projekt_id);
            if (parts_of_the_project == null)
            {
                MessageBox.Show("Hiba", "Hiba", MessageBoxButtons.OK);
            }
            else
            {
                foreach (var value in parts_of_the_project)
                {
                    foreach (var part in value.Value)
                    {
                        lblOutput.Text += $"\n\t{part.Peldany_to_string()}";
                    }
                }
                lblOutput.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            utvonal ut = new utvonal();
            ut.utAdd(new rekesz(1, 1, 1));
            rekeszek alkatreszek = new rekeszek();
            int projekt_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Dictionary<int, List<ProjectPart>> parts_of_the_project = IOFunction_lib.Connector.ConnectToDatabase_part_to_project(projekt_id);
            if (parts_of_the_project== null)
            {
                MessageBox.Show("Nincs hozzárendelve semmi", "hiba", MessageBoxButtons.OK);
            }
            else
            {
                foreach (var item in parts_of_the_project[projekt_id])
                {
                    alkatreszek.rekeszAdd(new rekesz(item.Rekesz_sor, item.Rekesz_oszlop, item.Rekesz_szint));
                }
                //alkatreszek.rekeszAdd(new rekesz(6, 3, 4));
                //alkatreszek.rekeszAdd(new rekesz(1, 3, 5));
                //alkatreszek.rekeszAdd(new rekesz(5, 3, 2));
                //alkatreszek.rekeszAdd(new rekesz(2, 3, 5));
                //alkatreszek.rekeszAdd(new rekesz(2, 2, 5));
                //alkatreszek.rekeszAdd(new rekesz(3, 3, 5));
                //alkatreszek.rekeszAdd(new rekesz(3, 3, 4));
                //alkatreszek.rekeszAdd(new rekesz(5, 3, 5));
                //alkatreszek.rekeszAdd(new rekesz(6, 3, 5));
                //alkatreszek.rekeszAdd(new rekesz(4, 2, 5));
                //alkatreszek.rekeszAdd(new rekesz(4, 3, 5));
                //alkatreszek.rekeszAdd(new rekesz(4, 2, 2));
                //alkatreszek.kiir();
                ut.getMinDistance(ref alkatreszek);
                string[] seg = ut.utvonalKi().Split('|');
                listBox1.Items.Clear();
                foreach (var item in seg)
                {
                    listBox1.Items.Add(item);
                }
                //ut.kiirUtvonal();
                //alkatreszek.kiir();
            }

        }
    }
}

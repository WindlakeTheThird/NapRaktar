using Class_library;
using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class New_project : Form
    {
        Szakember szakember = (Szakember)Login.worker;
        public New_project()
        {
            InitializeComponent();
            projectListUC1.adatok(szakember.Id);
        }
        public void ProjectLetrehozas(object sender, EventArgs e)
        {
            projectAddUC1.Projekt_add(szakember.Id);
            MessageBox.Show("Sikeres adatfelvitel", "OK", MessageBoxButtons.OK);
            projectListUC1.adatok(szakember.Id);

        }
    }
}

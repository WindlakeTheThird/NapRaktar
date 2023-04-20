using Class_library;
using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class SetPrice : Form
    {
        Szakember szakember = (Szakember)Login.worker;
        public SetPrice()
        {
            InitializeComponent();
            projectListUC1.adatok(szakember.Id);
        }
        private void btnModosit_Click(object sender, EventArgs e)
        {
            if (szakemberArazas1.ReturntxtVal().Trim().Length > 0)
            {
                if (szakemberArazas1.ReturnePickedDate() > DateTime.Now)
                {
                    szakemberArazas1.projektKoltseg_Date_modositas(projectListUC1.ReturnProjectId());
                    MessageBox.Show("Sikeres módosítás", "OK", MessageBoxButtons.OK);
                    projectListUC1.adatok(szakember.Id);
                }
                else
                {
                    MessageBox.Show("Adjon meg egy valós dátumot", "Hiba", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Adjon meg egy árat", "Hiba", MessageBoxButtons.OK);
            }

        }
    }
}

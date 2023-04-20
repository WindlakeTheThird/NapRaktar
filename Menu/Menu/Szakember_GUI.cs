using Class_library;
using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class Szakember_GUI : Form
    {

        public static Szakember user;


        public Szakember_GUI()
        {
            InitializeComponent();
        }
        public void getRaktarvezData(object sender, EventArgs e)
        {
            user = (Szakember)Login.worker;
        }
        public void UjProjectOpen(object sender, EventArgs e)
        {
            this.Hide();
            New_project new_project = new New_project();
            new_project.Show();
            new_project.FormClosed += sub_form_closeing;
        }
        public void AlkatreszProjektOpen(object sender, EventArgs e)
        {
            this.Hide();
            PartToProject part_to_project = new PartToProject();
            part_to_project.Show();
            part_to_project.FormClosed += sub_form_closeing;
        }
        public void ArEsKivitIdo(object sender, EventArgs e)
        {
            this.Hide();
            SetPrice price_and_time = new SetPrice();
            price_and_time.Show();
            price_and_time.FormClosed += sub_form_closeing;
        }
        public void LogOut(object sender, EventArgs e)
        {
            this.Close();
        }
        public void sub_form_closeing(object sender, EventArgs e)
        {
            this.Show();
        }

    }
}

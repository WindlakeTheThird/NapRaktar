using Class_library;
using System;
using System.Windows.Forms;


namespace Menu
{
    public partial class Raktarvez_GUI : Form
    {
        public static Raktarvezeto user;
        public Raktarvez_GUI()
        {
            InitializeComponent();
        }
        public void getRaktarvezData(object sender, EventArgs e)
        {
            user = (Raktarvezeto)Login.worker;
        }
        public void LogOut(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Part_Alter_Open(object sender, EventArgs e)
        {
            this.Hide();
            Part_alter part_alter = new Part_alter();
            part_alter.Show();
            part_alter.FormClosed += sub_form_closeing;
        }
        public void Part_Add_Open(object sender, EventArgs e)
        {
            this.Hide();
            Part_add part_add = new Part_add();
            part_add.Show();
            part_add.FormClosed += sub_form_closeing;
        }
        public void AlkatreszRekeszhez(object sender, EventArgs e)
        {
            this.Hide();
            AlkatreszRekeszhezAdasaForm part_add_to_basket = new AlkatreszRekeszhezAdasaForm();
            part_add_to_basket.Show();
            part_add_to_basket.FormClosed += sub_form_closeing;
        }
        public void sub_form_closeing(object sender, EventArgs e)
        {
            this.Show();
        }

    }
}

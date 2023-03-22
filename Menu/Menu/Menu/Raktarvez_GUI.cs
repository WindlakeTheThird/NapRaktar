using Class_library;
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
    public partial class Raktarvez_GUI : Form
    {
        public static Raktarvezeto user;
        public Raktarvez_GUI()
        {
            InitializeComponent();
        }
        public void getRaktarvezData(object sender, EventArgs e)
        {
            user = Login.worker;
        }
        public void LogOut(object sender, EventArgs e)
        {
            this.Hide();
            Login login_form = new Login();
            login_form.Closed += (s, args) => this.Close();
            login_form.Show();

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
        public void sub_form_closeing(object sender, EventArgs e)
        {
            this.Show();
        }

    }
}

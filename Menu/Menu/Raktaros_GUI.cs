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
    public partial class Raktaros_GUI : Form
    {
        public static Raktaros user;
        public Raktaros_GUI()
        {
            InitializeComponent();
        }

        public void ProjectStart(object sender, EventArgs e)
        {
            this.Hide();
            RaktarosForm raktaros_form = new RaktarosForm();
            raktaros_form.Show();
            raktaros_form.FormClosed += sub_form_closeing;
        }
        public void ProjectPartList(object sender, EventArgs e)
        {
            this.Hide();
            Project_Part_List projectpartlist = new Project_Part_List();
            projectpartlist.Show();
            projectpartlist.FormClosed += sub_form_closeing;
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

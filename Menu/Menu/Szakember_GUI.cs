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
        public void LogOut(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

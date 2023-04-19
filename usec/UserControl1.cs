using napelemosztalyok.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace napelemosztalyok.usec
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Szakember sz = new Szakember();
            sz.rendAlk(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
        }
    }
}

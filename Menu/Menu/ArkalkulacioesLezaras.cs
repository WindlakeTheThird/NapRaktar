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
    public partial class ArkalkulacioesLezaras : Form
    {
        private ProjectCalcEndUC projectCalcEndUC1;

        public ArkalkulacioesLezaras()
        {
            InitializeComponent();
        }

        /*private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ArkalkulacioesLezaras
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ArkalkulacioesLezaras";
            this.Load += new System.EventHandler(this.ArkalkulacioesLezaras_Load);
            this.ResumeLayout(false);

        }*/

        private void ArkalkulacioesLezaras_Load(object sender, EventArgs e)
        {
            projectCalcEndUC1.tolts();
        }

        private void InitializeComponent()
        {
            this.projectCalcEndUC1 = new Menu.ProjectCalcEndUC();
            this.SuspendLayout();
            // 
            // projectCalcEndUC1
            // 
            this.projectCalcEndUC1.Location = new System.Drawing.Point(12, 12);
            this.projectCalcEndUC1.Name = "projectCalcEndUC1";
            this.projectCalcEndUC1.Size = new System.Drawing.Size(887, 350);
            this.projectCalcEndUC1.TabIndex = 0;
            // 
            // ArkalkulacioesLezaras
            // 
            this.ClientSize = new System.Drawing.Size(958, 432);
            this.Controls.Add(this.projectCalcEndUC1);
            this.Name = "ArkalkulacioesLezaras";
            this.Load += new System.EventHandler(this.ArkalkulacioesLezaras_Load);
            this.ResumeLayout(false);

        }
    }
}

using Class_library;
using IOFunction_lib;
using System.Windows.Forms;

namespace Menu
{
    public partial class ProjectAddUC : UserControl
    {
        public ProjectAddUC()
        {
            InitializeComponent();
        }
        public void Projekt_add(int worker_id)
        {
            Project felt = new Project(worker_id, txtProjectName.Text, txtPlace.Text, txtDesc.Text, txtContact.Text);
            string query = "insert into napelem.projekt (projekt_nev,szakember_id,allapot,koltseg,kivitelezesi_ido,hely,leiras,elerhetoseg) values (" + felt.newProject() + ")";
            Connector.ConnectToDatabase_add_projekt("127.0.0.1", "3306", "root", "toor", "napelem", query);
        }
    }
}

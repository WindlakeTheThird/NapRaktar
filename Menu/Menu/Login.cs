using Class_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Menu
{
    public partial class Login : Form
    {
        public static Worker worker;
        public Login()
        {
            InitializeComponent();
        }

        public void Alkalmazott_Login(object sender, EventArgs e)
        {
            if (txtPw.Text.Trim() != "" && txtUser.Text.Trim() != "")
            {
                string user_data = IOFunction_lib.Connector.ConnectToDatabase_login("127.0.0.1", "3306", "root", "toor", "napelem", txtUser.Text, txtPw.Text);
                if (user_data.Contains("helyes-"))
                {
                    List<string> user = user_data.Split('-')[1].Split(',').ToList();
                    if (user[2] == "1")
                    {
                        this.Hide();
                        worker = new Raktarvezeto(int.Parse(user[0]), user[1]);
                        Raktarvez_GUI raktarvez_gui = new Raktarvez_GUI();
                        raktarvez_gui.Closed += (s, args) => this.Show();
                        raktarvez_gui.ShowDialog();
                        txtUser.Clear();
                        txtPw.Clear();
                    }
                    if (user[2] == "3")
                    {
                        this.Hide();
                        worker = new Szakember(int.Parse(user[0]), user[1]);
                        Szakember_GUI szakember_gui = new Szakember_GUI();
                        szakember_gui.Closed += (s, args) => this.Show();
                        szakember_gui.ShowDialog();
                        txtUser.Clear();
                        txtPw.Clear();
                    }
                }
                else
                {
                    MessageBox.Show(user_data, "Sikertelen belépés", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("A felhasználónév és jelészó megadása kötelező", "Sikertelen belépés", MessageBoxButtons.OK);
            }
        }
    }
}


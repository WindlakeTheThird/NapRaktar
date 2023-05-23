using Class_library;
using IOFunction_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Menu
{
    public partial class RakVezRekeszhezAd : UserControl
    {

        List<Part> parts;
        int selectedPart;
        int partMax;
        int row = -1;

        public RakVezRekeszhezAd()
        {
            InitializeComponent();
            TablaFeltolt();
        }

        private void TablaFeltolt()
        {
            parts = Connector.ConnectToDatabase_list_parts("127.0.0.1", "3306", "root", "toor", "napelem");
            BindingList<Part> list = new BindingList<Part>();
            foreach (Part part in parts)
            {
                list.Add(part);
            }
            dGVAlkatreszek.DataSource = list;
            dGVAlkatreszek.Update();
            dGVAlkatreszek.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tBAlkatresz.Text != dGVAlkatreszek[1, row].Value.ToString() && row != -1)
            {
                MessageBox.Show("Ezt az alkatrészt nem teheted ebbe a rekeszbe.", "Figyelmeztetés", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (tBOszlop.Text.Equals("") || tBSor.Text.Equals("") || tBSzint.Text.Equals(""))
                {
                    MessageBox.Show("Nem adtad meg hova kerül az alkatrész.", "Figyelmeztetés", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    string query = $"SELECT * from rekesz where oszlop = {tBOszlop.Text.Trim()} AND sor = {tBSor.Text.Trim()} AND szint = {tBSzint.Text.Trim()}";
                    DataTable response = Connector.ConnectToDatabase_rekesz_listazas(query);
                    DataRowCollection rows = response.Rows;
                    bool ures = true;
                    int[] sor = new int[6];

                    foreach (DataRow item in rows)
                    {
                        for (int i = 0; i < 6; i++)
                            sor[i] = Convert.ToInt32(item.ItemArray[i]);
                        if (sor[3] != selectedPart || (sor[4] != 0 && sor[5] != 0))
                        {
                            ures = false;
                        }
                    }

                    if (!ures)
                    {
                        MessageBox.Show("Ebben a Rekeszben már van valami más.", "Figyelmezetés", MessageBoxButtons.OK);
                        return;
                    }
                    int felt = int.Parse(tBMennyiseg.Text)+sor[4];
                    if (felt > partMax)
                    {
                        query = $"UPDATE rekesz set alkatresz_id={selectedPart},mennyi={partMax} where sor={tBSor.Text.Trim()} and oszlop={tBOszlop.Text.Trim()} and szint={tBSzint.Text.Trim()}";
                        string valasz = Connector.ConnectToDatabase_add_parts("127.0.0.1", "3306", "root", "toor", "napelem", query);
                        if (sor[4] != partMax)
                        {
                            MessageBox.Show(valasz, "Update", MessageBoxButtons.OK);
                            tBMennyiseg.Text = (int.Parse(tBMennyiseg.Text) - partMax + sor[4]).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Tele van a rekesz!", "Update", MessageBoxButtons.OK);
                        }
                            
                        MessageBox.Show("Több mint egy rekeszre szükség lesz még");
                    }
                    else
                    {
                        query = $"UPDATE rekesz set alkatresz_id={selectedPart},mennyi={felt} where sor={tBSor.Text.Trim()} and oszlop={tBOszlop.Text.Trim()} and szint={tBSzint.Text.Trim()}";
                        string valasz = Connector.ConnectToDatabase_add_parts("127.0.0.1", "3306", "root", "toor", "napelem", query);
                        MessageBox.Show(valasz, "Update", MessageBoxButtons.OK);
                    }
                }
            }

        }

        private void SetAlkatresz(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            selectedPart = int.Parse(dGVAlkatreszek[0, row].Value.ToString());
            partMax = int.Parse(dGVAlkatreszek[2, row].Value.ToString());
            tBAlkatresz.Text = dGVAlkatreszek[1, row].Value.ToString();
        }
    }
}
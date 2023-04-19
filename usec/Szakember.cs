using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace napelemosztalyok.classes
{
    public class Szakember
    {
        //test adatok
        //private readonly int pid = 0;
        private readonly int atip = 0;
        private readonly int menny = 0;
        private readonly int rend = 0;
        private readonly int kell = 50;
        /*public void rendAlk(int aid)
        {
            int van = -1;
            string Query = "Select count(*) from napelem.rekesz where alkatresz_id="+aid;
            string MyConnection2 = "datasource=localhost;username=root;password=";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand.ExecuteReader();     
            MessageBox.Show("Database exists");
            while (MyReader2.Read())
            {
                van = Convert.ToInt32(MyReader2.GetString(0));
            }
            MyReader2.Close();
            if (van == -1)
            {
                MessageBox.Show("Hiba");
            }
            else
            {
                if (van == 0)
                {
                    Query = $"insert into napelem.rendeles (projekt_id,alkatresz,mennyiseg,rendeles_allapot) values ({pid},{atip},{menny},{rend})";
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    MyReader2.Close();
                }
                else
                {
                    int s=0,mkell=kell,mkellv=kell;
                    Query = "Select * from napelem.rekesz where alkatresz_id=" + aid;
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                        s= Convert.ToInt32(MyReader2.GetString(4));
                        mkell -= s;
                        if (mkell <= 0)
                        {
                            string Query3 = $"Update napelem.rekesz set mennyi={s-mkellv} where sor={MyReader2.GetString(0)} and oszlop={MyReader2.GetString(1)} and szint={MyReader2.GetString(2)}";
                            string MyConnection3 = "datasource=localhost;username=root;password=";
                            MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                            MySqlCommand MyCommand3 = new MySqlCommand(Query3, MyConn3);
                            MySqlDataReader MyReader3;
                            MyConn3.Open();
                            MyReader3 = MyCommand3.ExecuteReader();
                            while (MyReader3.Read())
                            {
                            }
                            MyReader3.Close();
                            MyConn3.Close();
                            break;
                        }
                        else
                        {
                            string Query3 = $"Update napelem.rekesz set mennyi=0 where sor={MyReader2.GetString(0)} and oszlop={MyReader2.GetString(1)} and szint={MyReader2.GetString(2)}";
                            string MyConnection3 = "datasource=localhost;username=root;password=";
                            MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                            MySqlCommand MyCommand3 = new MySqlCommand(Query3, MyConn3);
                            MySqlDataReader MyReader3;
                            MyConn3.Open();
                            MyReader3 = MyCommand3.ExecuteReader();
                            while (MyReader3.Read())
                            {
                            }
                            MyReader3.Close();
                            MyConn3.Close();
                        }
                        mkellv = mkell;
                    }
                    MyReader2.Close();

                }
            }
            MyConn2.Close();
        }*/
        public void rendAlk(int aid,int m,int pid=0)
        {
            int van = -1;
            int s = 0, mkell = m, mkellv = m;
            string Query = "Select count(*) from napelem.rekesz where alkatresz_id=" + aid;
            string MyConnection2 = "datasource=localhost;username=root;password=";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand.ExecuteReader();
            while (MyReader2.Read())
            {
                van = Convert.ToInt32(MyReader2.GetString(0));
            }
            MyReader2.Close();
            if (van == -1)
            {
                MessageBox.Show("Hiba");
            }
            else
            {
                if (van == 0)
                {
                    Query = $"insert into napelem.rendeles (projekt_id,alkatresz,mennyiseg,rendeles_allapot) values ({pid},{aid},{m},0)";
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    MyReader2.Close();
                }
                else
                {
                    Query = "Select * from napelem.rekesz where alkatresz_id=" + aid;
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                        s = Convert.ToInt32(MyReader2.GetString(4));
                        mkell -= s;
                        if (mkell <= 0)
                        {
                            string Query3="";
                            if (s - mkellv==0)
                                Query3 = $"Update napelem.rekesz set mennyi={s - mkellv},alkatresz_id=0 where sor={MyReader2.GetString(0)} and oszlop={MyReader2.GetString(1)} and szint={MyReader2.GetString(2)}";
                            else
                                Query3 = $"Update napelem.rekesz set mennyi={s - mkellv} where sor={MyReader2.GetString(0)} and oszlop={MyReader2.GetString(1)} and szint={MyReader2.GetString(2)}";
                            string MyConnection3 = "datasource=localhost;username=root;password=";
                            MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                            MySqlCommand MyCommand3 = new MySqlCommand(Query3, MyConn3);
                            MySqlDataReader MyReader3;
                            MyConn3.Open();
                            MyReader3 = MyCommand3.ExecuteReader();
                            while (MyReader3.Read())
                            {
                            }//!!!!!!!!!!!!!!!!!!!!! rendelés disoster
                            MyReader3.Close();
                            Query3 = $"Insert into napelem.rendeles (projekt_id,alkatresz,mennyiseg,rendeles_allapot) values ({pid},{aid},{m},1)";
                            MySqlCommand MyCommand4 = new MySqlCommand(Query3, MyConn3);
                            MySqlDataReader MyReader4 = MyCommand4.ExecuteReader();
                            while (MyReader4.Read())
                            {
                            }
                            MyReader4.Close();
                            
                            MyConn3.Close();
                            break;
                        }
                        else
                        {
                            string Query3 = $"Update napelem.rekesz set mennyi=0,alkatresz_id=0 where sor={MyReader2.GetString(0)} and oszlop={MyReader2.GetString(1)} and szint={MyReader2.GetString(2)}";
                            string MyConnection3 = "datasource=localhost;username=root;password=";
                            MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                            MySqlCommand MyCommand3 = new MySqlCommand(Query3, MyConn3);
                            MySqlDataReader MyReader3;
                            MyConn3.Open();
                            MyReader3 = MyCommand3.ExecuteReader();
                            while (MyReader3.Read())
                            {
                            }
                            MyReader3.Close();
                            MyConn3.Close();
                        }
                        mkellv = mkell;
                    }
                    MyReader2.Close();

                }
            }
            if (mkell > 0)
            {
                Query = $"insert into napelem.rendeles (projekt_id,alkatresz,mennyiseg,rendeles_allapot) values ({pid},{aid},{mkell},0)";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MyReader2.Close();
                Query = $"insert into napelem.rendeles (projekt_id,alkatresz,mennyiseg,rendeles_allapot) values ({pid},{aid},{m-mkell},1)";
                MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MyReader2.Close();
            }
            MyConn2.Close();
        }

    }
}

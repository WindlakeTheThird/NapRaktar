using Class_library;
using MySqlConnector;
//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace IOFunction_lib
{
    public static class Connector
    {
        public static string Encode(string plaintext)
        {
            try
            {
                string ourText = plaintext;
                string _key = "abcdefgh";
                string privatekey = "hgfedcba";
                byte[] privatekeyByte = { };
                privatekeyByte = Encoding.UTF8.GetBytes(privatekey);
                byte[] _keybyte = { };
                _keybyte = Encoding.UTF8.GetBytes(_key);
                byte[] inputtextbyteArray = System.Text.Encoding.UTF8.GetBytes(ourText);
                using (DESCryptoServiceProvider dsp = new DESCryptoServiceProvider())
                {
                    var memstr = new MemoryStream();
                    var crystr = new CryptoStream(memstr, dsp.CreateEncryptor(_keybyte, privatekeyByte), CryptoStreamMode.Write);
                    crystr.Write(inputtextbyteArray, 0, inputtextbyteArray.Length);
                    crystr.FlushFinalBlock();
                    return Convert.ToBase64String(memstr.ToArray());
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string ConnectToDatabase_login(string server, string port, string user, string password, string database, string logname, string passwd)
        {                                                                                   //(passwd-admin)
            string connectionString = $"datasource={server}; port={port}; username={user}; Password={password}; database={database};";
            var asd = Encode(passwd);
            string query = $"Select * from dolgozok where felhasznalonev = '{logname}' and jelszo = '{Encode(passwd)}';";


            MySqlConnection connector;
            connector = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, connector);
            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;

            try
            {
                connector.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    string user_data = "";
                    while (reader.Read())
                    {
                        user_data += $"{reader.GetInt32(0)},{reader.GetString(1)},{reader.GetInt32(2)}";
                    }
                    connector.Close();
                    return $"helyes-{user_data}";
                }
                else
                {
                    connector.Close();
                    return "hibás felhasználónév vagy jelszó";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public static string ConnectToDatabase_update(string server, string port, string user, string password, string database, string query)
        {                                                                                   //(passwd-admin)
            string connectionString = $"datasource={server}; port={port}; username={user}; Password={password}; database={database};";

            MySqlConnection connector;
            connector = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, connector);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                connector.Open();
                reader = commandDatabase.ExecuteReader();
                connector.Close();

                return "A módosítás sikeres";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public static List<Part> ConnectToDatabase_list_parts(string server, string port, string user, string password, string database)
        {                                                                                   //(passwd-admin)
            string connectionString = $"datasource={server}; port={port}; username={user}; Password={password}; database={database};";

            MySqlConnection connector;
            connector = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand("Select * from alkatresz", connector);
            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;

            try
            {
                connector.Open();
                reader = commandDatabase.ExecuteReader();
                List<Part> parts = new List<Part>();
                while (reader.Read())
                {
                    parts.Add(new Part(Convert.ToInt32(reader.GetInt32(0)), reader.GetString(1), Convert.ToInt32(reader.GetInt32(2)), Convert.ToInt32(reader.GetInt32(3))));
                }
                return parts;


            }
            catch (Exception ex)
            {
                Environment.Exit(999);
            }
            return null;
        }

        public static string ConnectToDatabase_update_parts(string server, string port, string user, string password, string database, string query)
        {                                                                                   //(passwd-admin)
            string connectionString = $"datasource={server}; port={port}; username={user}; Password={password}; database={database};";

            MySqlConnection connector;
            connector = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, connector);
            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;

            try
            {
                connector.Open();
                reader = commandDatabase.ExecuteReader();
                connector.Close();
                return "A módosítás sikeres volt";
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
            }
            return null;
        }
        public static string ConnectToDatabase_add_parts(string server, string port, string user, string password, string database, string query)
        {                                                                                   //(passwd-admin)
            string connectionString = $"datasource={server}; port={port}; username={user}; Password={password}; database={database};";

            MySqlConnection connector;
            connector = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, connector);
            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;

            try
            {
                connector.Open();
                reader = commandDatabase.ExecuteReader();
                connector.Close();
                return "A felvitel sikeres volt";
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
            }
            return null;
        }
        public static List<Project> ConnectToDatabase_list_projects(string server, string port, string user, string password, string database, int szak_id)
        {
            string connectionString = $"datasource={server}; port={port}; username={user}; Password={password}; database={database};";

            MySqlConnection connector;
            connector = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand($"Select * from projekt where szakember_id = {szak_id}", connector);
            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;

            try
            {
                connector.Open();
                reader = commandDatabase.ExecuteReader();
                List<Project> projects = new List<Project>();
                while (reader.Read())
                {
                    projects.Add(new Project(Convert.ToInt32(
                        reader.GetInt32(0).ToString()),
                        reader.GetString(1),
                        Convert.ToInt32(reader.GetInt32(2).ToString()),
                        Convert.ToInt32(reader.GetInt32(3).ToString()),
                        Convert.ToInt32(reader.GetInt32(4).ToString()),
                        reader.GetString(5),
                        reader.GetString(6),
                        reader.GetString(7),
                        reader.GetString(8)));
                }
                return projects;


            }
            catch (Exception ex)
            {
                Environment.Exit(999);
            }
            return null;
        }

        public static void ConnectToDatabase_add_projekt(string server, string port, string user, string password, string database, string query)
        {

            string MyConnection = $"datasource={server}; port={port}; username={user}; Password={password}; database={database};";
            MySqlConnection MyConn = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
            }
            MyReader.Close();
            MyConn.Close();
        }

        public static int ConnectToDatabase_read_rek_1(string server, string port, string user, string password, string database, string query)
        {
            int van = -1;
            string MyConnection2 = $"datasource={server}; port={port}; username={user}; Password={password}; database={database};";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand.ExecuteReader();
            while (MyReader2.Read())
            {
                van = Convert.ToInt32(MyReader2.GetInt64(0));
            }
            MyReader2.Close();
            MyConn2.Close();
            return van;
        }
        public static void ConnectToDatabase_read_rek_2(string server, string port, string user, string password, string database, string query)
        {
            string MyConnection2 = $"datasource={server}; port={port}; username={user}; Password={password}; database={database};";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MyConn2.Open();
            MySqlDataReader MyReader2;
            MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
            MyReader2 = MyCommand2.ExecuteReader();
            while (MyReader2.Read())
            {
            }
            MyReader2.Close();
            MyConn2.Close();
        }
        public static void ConnectToDatabase_read_rek_3(string server, string port, string user, string password, string database, int pid, int aid, int m, ref int mkell, ref int s, ref int mkellv)
        {
            string MyConnection2 = $"datasource={server}; port={port}; username={user}; Password={password}; database={database};";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MyConn2.Open();
            MySqlDataReader MyReader2;
            MySqlCommand MyCommand2 = new MySqlCommand($"Select * from rekesz where alkatresz_id={aid}", MyConn2);
            MyReader2 = MyCommand2.ExecuteReader();
            while (MyReader2.Read())
            {
                s = Convert.ToInt32(MyReader2.GetInt32(4));
                mkell -= s;
                if (mkell <= 0)
                {
                    string Query3 = "";
                    if (s - mkellv == 0)
                        Query3 = $"Update napelem.rekesz set mennyi={s - mkellv},alkatresz_id=0 where sor={MyReader2.GetString(0)} and oszlop={MyReader2.GetString(1)} and szint={MyReader2.GetString(2)}";
                    else
                        Query3 = $"Update napelem.rekesz set mennyi={s - mkellv} where sor={MyReader2.GetString(0)} and oszlop={MyReader2.GetString(1)} and szint={MyReader2.GetString(2)}";
                    string MyConnection3 = $"datasource={server}; port={port}; username={user}; Password={password}; database={database};";
                    MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                    MySqlCommand MyCommand3 = new MySqlCommand(Query3, MyConn3);
                    MySqlDataReader MyReader3;
                    MyConn3.Open();
                    MyReader3 = MyCommand3.ExecuteReader();
                    while (MyReader3.Read())
                    {
                    }
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
                    string Query3 = $"Update napelem.rekesz set mennyi=0,alkatresz_id=0 where sor={MyReader2.GetInt32(0)} and oszlop={MyReader2.GetInt32(1)} and szint={MyReader2.GetInt32(2)}";
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
            MyConn2.Close();
        }

        public static DataTable ConnectToDatabase_read_parts_worker(string server, string port, string user, string password, string database, string query)
        {
            MySqlConnection con = new MySqlConnection($"datasource={server}; port={port}; username={user}; Password={password}; database={database};");
            //This is command class which will handle the query and connection object.  
            MySqlCommand myCommand = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader myReader;
            DataTable table = new DataTable();
            myReader = myCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.
            table.Load(myReader);
            con.Close();
            return table;
        }

        public static DataTable ConnectToDatabase_read_missing_stuff(string server, string port, string user, string password, string database, string query)
        {
            MySqlConnection con = new MySqlConnection($"datasource={server}; port={port}; username={user}; Password={password}; database={database};");
            MySqlCommand myCommand = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader myReader;
            DataTable table = new DataTable();
            myReader = myCommand.ExecuteReader();
            table.Load(myReader);
            con.Close();
            return table;
        }

    }
}

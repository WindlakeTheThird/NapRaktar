using Class_library;
using MySqlConnector;
using System.Text.Json;
//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace IOFunction_lib
{
    public static class Connector
    {

        public static string ClientSocket_Connector(string command)
        {
            string response = null;
            try
            {
                // Create a TCP/IP socket.
                Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Connect to the remote endpoint.
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1"); // Replace with the IP address of the server
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 65432); // Replace with the port number of the server

                clientSocket.Connect(remoteEP);

                // Send data to the server.
                byte[] data = Encoding.ASCII.GetBytes(command);
                clientSocket.Send(data);

                // Receive the response from the server.
                data = new byte[16000];
                var bytesReceived = clientSocket.Receive(data);
                response = Encoding.UTF8.GetString(data, 0, bytesReceived);



                // Release the socket.
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
            catch (Exception e)
            {
                return $"Exception: {e.ToString()}";
            }
            return response;
        }

        

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
        {
            //(passwd-admin)
            /*
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
            */
            string response=ClientSocket_Connector($"1#Select * from dolgozok where felhasznalonev = '{logname}' and jelszo = '{Encode(passwd)}';");
            if (response != "hibás felhasználónév vagy jelszó" && response != "hiba a csatlakozás során")
            {
                //"id":"2","nev":"Teszt Tímea","beosztas":"3","felhasznalonev":"teszttimi","jelszo":"gE7yon3pvuU="
                var seged = response.Split('#');
                var darabok = seged[0].Split(',');
                int id = Convert.ToInt32(darabok[0].Split(':')[1].Split('"')[1]);
                string nev = darabok[1].Split(':')[1].Split('"')[1];
                string beosztas = darabok[2].Split(':')[1].Split('"')[1];

                return $"helyes-{id},{nev},{beosztas}";

            }
            return response;

        }
        public static string ConnectToDatabase_update(string server, string port, string user, string password, string database, string query)
        {                                                                                   //(passwd-admin)
            /*
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
            */
            return ClientSocket_Connector($"2#{query}");
        }

        public static List<Part> ConnectToDatabase_list_parts(string server, string port, string user, string password, string database)
        {                                                                                   //(passwd-admin)
            /*
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
            */
            List<Part> resz_lista = new List<Part>();
            string response = ClientSocket_Connector($"1#Select * from alkatresz");
            var seged = response.Split('#');
            foreach(var resz in seged)
            {
                var darabok=resz.Split(',');
                int id = Convert.ToInt32(darabok[0].Split(':')[1].Split('"')[1]);
                string type = darabok[1].Split(':')[1].Split('"')[1];
                int amaunt = Convert.ToInt32(darabok[2].Split(':')[1].Split('"')[1]);
                double ar = Convert.ToDouble(darabok[3].Split(':')[1].Split('"')[1]);
                resz_lista.Add(new Part(id, type, amaunt, ar));
            }
            return resz_lista;
        }

        public static string ConnectToDatabase_update_parts(string server, string port, string user, string password, string database, string query)
        {                                                                                   //(passwd-admin)
            /*
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
            */
            if (ClientSocket_Connector($"2#{query}") == "done")
                return "A módosítás sikeres volt";
            else
                return "Hiba történt a módosítás során";
        }
        public static string ConnectToDatabase_add_parts(string server, string port, string user, string password, string database, string query)
        {                                                                                   //(passwd-admin)
            /*
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
            */
            if (ClientSocket_Connector($"2#{query}") == "done")
                return "A felvitel sikeres volt";
            else
                return "Hiba történt a felvitel során";
        }

        public static List<Project> ConnectToDatabase_list_projects(string server, string port, string user, string password, string database, int szak_id)
        {
            /*
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
            */
            var response=ClientSocket_Connector($"1#Select * from projekt where szakember_id = {szak_id}");
            if(response.Length==0)
            {
                return null;
            }
            var seged = response.Split('#');
            List<Project> proj_lista = new List<Project>();
            foreach (var resz in seged)
            {
                var darabok = resz.Split(',');
                int id = Convert.ToInt32(darabok[0].Split(':')[1].Split('"')[1]);
                string proj_name = darabok[1].Split(':')[1].Split('"')[1];
                int szakember_id = Convert.ToInt32(darabok[2].Split(':')[1].Split('"')[1]);
                int allapot = Convert.ToInt32(darabok[3].Split(':')[1].Split('"')[1]);
                int koltseg = Convert.ToInt32(darabok[4].Split(':')[1].Split('"')[1]);
                string kivitido = darabok[5].Split(':')[1].Split('"')[1];
                string hely = darabok[6].Split(':')[1].Split('"')[1];
                string leiras = darabok[7].Split(':')[1].Split('"')[1];
                string elerhetoseg = darabok[8].Split(':')[1].Split('"')[1];
                proj_lista.Add(new Project(id, proj_name,szakember_id,allapot,koltseg,kivitido,hely,leiras,elerhetoseg));
            }
            return proj_lista;
            
        }

        public static void ConnectToDatabase_add_projekt(string server, string port, string user, string password, string database, string query)
        {
            /*
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
            */

            string seged=ClientSocket_Connector($"2#{query}");
        }

        public static int ConnectToDatabase_read_rek_1(string server, string port, string user, string password, string database, string query)
        {
            /*
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
            */
            string response = ClientSocket_Connector($"1#{query}").Split(':')[1].Split('"')[1];
            return Convert.ToInt32(response);
        }
        public static void ConnectToDatabase_read_rek_2(string server, string port, string user, string password, string database, string query)
        {
            /*
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
            */
            string response = ClientSocket_Connector($"2#{query}");
        }
        public static void ConnectToDatabase_read_rek_3(string server, string port, string user, string password, string database, int pid, int aid, int m, ref int mkell, ref int s, ref int mkellv)
        {
            /*
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
                        Query3 = $"Update napelem.rekesz set mennyi={s - mkellv} where sor={MyReader2.GetInt32(0)} and oszlop={MyReader2.GetInt32(1)} and szint={MyReader2.GetInt32(2)}";
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

            */

            string response = ClientSocket_Connector($"1#Select * from rekesz where alkatresz_id ={ aid}");
            var seged = response.Split('#');
            foreach (var resz in seged)
            {
                s = Convert.ToInt32(resz.Split(',')[4].Split(':')[1].Split('"')[1]);
                mkell -= s;
                if (mkell <= 0)
                {
                    string query3 = "";
                    if (s - mkellv == 0)
                    {
                        query3 = $"Update napelem.rekesz set mennyi={s - mkellv},alkatresz_id=0 where sor={Convert.ToInt32(resz.Split(',')[0].Split(':')[1].Split('"')[1])} and oszlop={Convert.ToInt32(resz.Split(',')[1].Split(':')[1].Split('"')[1])} and szint={Convert.ToInt32(resz.Split(',')[2].Split(':')[1].Split('"')[1])}";
                        var response_2 = ClientSocket_Connector($"2#insert into projekt_rekesz (project_id,sor,oszlop,szint,mennyi) values ({pid},{Convert.ToInt32(resz.Split(',')[0].Split(':')[1].Split('"')[1])},{Convert.ToInt32(resz.Split(',')[1].Split(':')[1].Split('"')[1])},{Convert.ToInt32(resz.Split(',')[2].Split(':')[1].Split('"')[1])},{s})");
                    }
                    else
                    {
                        query3 = $"Update napelem.rekesz set mennyi={s - mkellv} where sor={Convert.ToInt32(resz.Split(',')[0].Split(':')[1].Split('"')[1])} and oszlop={Convert.ToInt32(resz.Split(',')[1].Split(':')[1].Split('"')[1])} and szint={Convert.ToInt32(resz.Split(',')[2].Split(':')[1].Split('"')[1])}";
                        var response_2 = ClientSocket_Connector($"2#insert into projekt_rekesz (project_id,sor,oszlop,szint,mennyi) values ({pid},{Convert.ToInt32(resz.Split(',')[0].Split(':')[1].Split('"')[1])},{Convert.ToInt32(resz.Split(',')[1].Split(':')[1].Split('"')[1])},{Convert.ToInt32(resz.Split(',')[2].Split(':')[1].Split('"')[1])},{s-mkellv})");
                    }
                    var seged_2 = ClientSocket_Connector($"2#{query3}");
                    var seged_3 = ClientSocket_Connector($"2#Insert into napelem.rendeles(projekt_id, alkatresz, mennyiseg, rendeles_allapot) values({ pid},{ aid},{ m},1)");
                    break;
                }
                else
                {
                    var seged_4 = ClientSocket_Connector($"2#Update napelem.rekesz set mennyi=0 where sor={Convert.ToInt32(resz.Split(',')[0].Split(':')[1].Split('"')[1])} and oszlop={Convert.ToInt32(resz.Split(',')[1].Split(':')[1].Split('"')[1])} and szint={Convert.ToInt32(resz.Split(',')[2].Split(':')[1].Split('"')[1])}");
                    var response_2 = ClientSocket_Connector($"2#insert into projekt_rekesz (project_id,sor,oszlop,szint,mennyi) values ({pid},{Convert.ToInt32(resz.Split(',')[0].Split(':')[1].Split('"')[1])},{Convert.ToInt32(resz.Split(',')[1].Split(':')[1].Split('"')[1])},{Convert.ToInt32(resz.Split(',')[2].Split(':')[1].Split('"')[1])},{s})");

                }
                mkellv = mkell;
            }
        }
    
       public static DataTable ConnectToDatabase_read_missing_stuff(string server, string port, string user, string password, string database, string query)
        {
            try
            {
                string response = ClientSocket_Connector($"1#{query}");
                DataTable dt = new DataTable();

                /*Select rendeles.rendeles_id, rendeles.projekt_id,alkatresz.tipus,rendeles.mennyiseg,
                 * rendeles_allapot.allapot_nev from rendelesjoin rendeles_allapot on rendeles.rendeles_allapot =
                 * rendeles_allapot.allapot_idjoin alkatresz on rendeles.alkatresz = alkatresz.tipus_id*/
                dt.Clear();
                dt.Columns.Add("Rendelés_ID");
                dt.Columns.Add("Projekt_ID");
                dt.Columns.Add("Alkatrész_tipus");
                dt.Columns.Add("Rendelt_mennyiség");
                dt.Columns.Add("Rendelés_állapota");
                foreach (var row in response.Split('#'))
                {
                    DataRow _drow = dt.NewRow();
                    _drow["Rendelés_ID"] = row.Split(',')[0].Split(':')[1].Split('"')[1];
                    _drow["Projekt_ID"] = row.Split(',')[1].Split(':')[1].Split('"')[1];
                    _drow["Alkatrész_tipus"] = row.Split(',')[2].Split(':')[1].Split('"')[1];
                    _drow["Rendelt_mennyiség"] = row.Split(',')[3].Split(':')[1].Split('"')[1];
                    _drow["Rendelés_állapota"] = row.Split(',')[4].Split(':')[1].Split('"')[1];
                    dt.Rows.Add(_drow);
                }

                return dt;
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public static DataTable ConnectToDatabase_read_parts_worker(string server, string port, string user, string password, string database, string query)
        {

            /*
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
            */


            //"tipus_id":"1","tipus":"100-as szög","ar":"70","darabszám":"50"

            try
            {
                string response = ClientSocket_Connector($"1#{query}");
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("Tipus id");
                dt.Columns.Add("Tipus");
                dt.Columns.Add("Ár");
                foreach (var row in response.Split('#'))
                {
                    DataRow _drow = dt.NewRow();
                    _drow["Tipus id"] = row.Split(',')[0].Split(':')[1].Split('"')[1];
                    _drow["Tipus"] = row.Split(',')[1].Split(':')[1].Split('"')[1];
                    _drow["Ár"] = row.Split(',')[2].Split(':')[1].Split('"')[1];
                    dt.Rows.Add(_drow);
                }

                return dt;
            }
            catch(Exception ex)
            {
                return new DataTable();
            }
        }


        public static double ConnectToDatabase_read_alkatresz_arak(string server, string port, string user, string password, string database, string query)
        {
            double sum = 0;
            /*
            MySqlConnection con = new MySqlConnection($"datasource={server}; port={port}; username={user}; Password={password}; database={database};");
            MySqlCommand myCommand = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                sum += myReader.GetInt32(0) * myReader.GetDouble(1);
            }
            con.Close();
            */
            string response = ClientSocket_Connector($"1#{query}");
            if (response.Equals("hibás felhasználónév vagy jelszó"))
                return 0;
            foreach (var row in response.Split('#'))
            {
                sum+= Convert.ToDouble(row.Split(',')[0].Split(':')[1].Split('"')[1])* Convert.ToDouble(row.Split(',')[1].Split(':')[1].Split('"')[1]);
            }
            return sum;
        }
        public static double ConnectToDatabase_read_projekt_munka_ber(string server, string port, string user, string password, string database, string query)
        {
            double ber = -1;
            /*
            MySqlConnection con = new MySqlConnection($"datasource={server}; port={port}; username={user}; Password={password}; database={database};");
            MySqlCommand myCommand = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                ber = myReader.GetDouble(0);
            }
            con.Close();
            */
            string response = ClientSocket_Connector($"1#{query}");
            if (response.Equals("hibás felhasználónév vagy jelszó"))
                return 0;
            foreach (var row in response.Split('#'))
            {
                ber = Convert.ToDouble(row.Split(',')[0].Split(':')[1].Split('"')[1]);
            }
            return ber;

        }
        public static void ConnectToDatabase_change_project_state(string server, string port, string user, string password, string database, string query)
        {
            /*
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
            */
            var seged = ClientSocket_Connector($"2#{query}");
        }
        public static List<Project> ConnectToDatabase_list_projects2(string server, string port, string user, string password, string database)
        {
            /*string connectionString = $"datasource={server}; port={port}; username={user}; Password={password}; database={database};";

            MySqlConnection connector;
            connector = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand($"Select * from projekt where allapot = 3", connector);
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
            return null;*/

            var response = ClientSocket_Connector($"1#Select * from projekt where allapot = 1 or allapot = 2 or allapot = 3");
            if (response.Length == 0 || response =="hibás felhasználónév vagy jelszó")
            {
                return null;
            }
            var seged = response.Split('#');
            List<Project> proj_lista = new List<Project>();
            foreach (var resz in seged)
            {
                var darabok = resz.Split(',');
                int id = Convert.ToInt32(darabok[0].Split(':')[1].Split('"')[1]);
                string proj_name = darabok[1].Split(':')[1].Split('"')[1];
                int szakember_id = Convert.ToInt32(darabok[2].Split(':')[1].Split('"')[1]);
                int allapot = Convert.ToInt32(darabok[3].Split(':')[1].Split('"')[1]);
                int koltseg = Convert.ToInt32(darabok[4].Split(':')[1].Split('"')[1]);
                string kivitido = darabok[5].Split(':')[1].Split('"')[1];
                string hely = darabok[6].Split(':')[1].Split('"')[1];
                string leiras = darabok[7].Split(':')[1].Split('"')[1];
                string elerhetoseg = darabok[8].Split(':')[1].Split('"')[1];
                proj_lista.Add(new Project(id, proj_name, szakember_id, allapot, koltseg, kivitido, hely, leiras, elerhetoseg));
            }
            return proj_lista;
        }
        public static List<Project> ConnectToDatabase_list_projects3(string v1, string v2, string v3, string v4, string v5)
        {
            var response = ClientSocket_Connector($"1#Select * from projekt where allapot = 3");
            if (response.Length == 0 || response == "hibás felhasználónév vagy jelszó")
            {
                return null;
            }
            var seged = response.Split('#');
            List<Project> proj_lista = new List<Project>();
            foreach (var resz in seged)
            {
                var darabok = resz.Split(',');
                int id = Convert.ToInt32(darabok[0].Split(':')[1].Split('"')[1]);
                string proj_name = darabok[1].Split(':')[1].Split('"')[1];
                int szakember_id = Convert.ToInt32(darabok[2].Split(':')[1].Split('"')[1]);
                int allapot = Convert.ToInt32(darabok[3].Split(':')[1].Split('"')[1]);
                int koltseg = Convert.ToInt32(darabok[4].Split(':')[1].Split('"')[1]);
                string kivitido = darabok[5].Split(':')[1].Split('"')[1];
                string hely = darabok[6].Split(':')[1].Split('"')[1];
                string leiras = darabok[7].Split(':')[1].Split('"')[1];
                string elerhetoseg = darabok[8].Split(':')[1].Split('"')[1];
                proj_lista.Add(new Project(id, proj_name, szakember_id, allapot, koltseg, kivitido, hely, leiras, elerhetoseg));
            }
            return proj_lista;
        }
        public static void ConnectToDatabase_change_project_koltseg(string server, string port, string user, string password, string database, string query)
        {
            /*
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
            */
            var response = ClientSocket_Connector($"2#{query}");
        }

        public static Dictionary<int, List<ProjectPart>> ConnectToDatabase_part_to_project(int pid)
        {
            Dictionary<int,List<ProjectPart>> resz_lista = new Dictionary<int,List<ProjectPart>>();
            List<ProjectPart> lista = new List<ProjectPart>();
            string response = ClientSocket_Connector($"1#Select * from projekt_rekesz where project_id = {pid}");
            if(response == "hibás felhasználónév vagy jelszó" ||response == "hiba a csatlakozás során")
            {
                return null;
            }
            var seged = response.Split('#');
            int proj_id = -1;
            foreach (var resz in seged)
            {
                var darabok = resz.Split(',');
                proj_id = Convert.ToInt32(darabok[0].Split(':')[1].Split('"')[1]);
                int sor = Convert.ToInt32(darabok[1].Split(':')[1].Split('"')[1]);
                int oszlop = Convert.ToInt32(darabok[2].Split(':')[1].Split('"')[1]);
                int szint = Convert.ToInt32(darabok[3].Split(':')[1].Split('"')[1]);
                int mennyiseg=Convert.ToInt32(darabok[4].Split(':')[1].Split('"')[1]);
                lista.Add(new ProjectPart(sor, oszlop, szint, mennyiseg));
            }
            resz_lista.Add(proj_id, lista);
            return resz_lista;
        }
        public static DataTable ConnectToDatabase_projects_into_data_grid()
        {

            try
            {
                string response = ClientSocket_Connector("1#select * from projekt where allapot =3");
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("Projekt_ID");
                dt.Columns.Add("Projekt_Nev");
                dt.Columns.Add("Szakember_ID");
                dt.Columns.Add("Állapot");
                dt.Columns.Add("Költség");
                dt.Columns.Add("Kivitelezési_idő");
                dt.Columns.Add("Hely");
                dt.Columns.Add("Leírás");
                dt.Columns.Add("Elérhetőség");
                foreach (var row in response.Split('#'))
                {
                    DataRow _drow = dt.NewRow();
                    _drow["Projekt_ID"] = row.Split(',')[0].Split(':')[1].Split('"')[1];
                    _drow["Projekt_Nev"] = row.Split(',')[1].Split(':')[1].Split('"')[1];
                    _drow["Szakember_ID"] = row.Split(',')[2].Split(':')[1].Split('"')[1];
                    _drow["Állapot"] = row.Split(',')[3].Split(':')[1].Split('"')[1];
                    _drow["Költség"] = row.Split(',')[0].Split(':')[1].Split('"')[1];
                    _drow["Kivitelezési_idő"] = row.Split(',')[1].Split(':')[1].Split('"')[1];
                    _drow["Hely"] = row.Split(',')[2].Split(':')[1].Split('"')[1];
                    _drow["Leírás"] = row.Split(',')[3].Split(':')[1].Split('"')[1];
                    _drow["Elérhetőség"] = row.Split(',')[3].Split(':')[1].Split('"')[1];
                    dt.Rows.Add(_drow);
                }

                return dt;
            }
            catch (Exception ex)
            {
                return new DataTable();
            }

        }
        //új
        public static int ConnectToDatabase_list_rendid(int id)
        {
            var response = ClientSocket_Connector($"1#Select count(*) from rendeles where projekt_id={id} and rendeles_allapot=0").Split(':')[1].Split('"')[1];
            if (response.Contains("hiba"))
            {
                return -1;
            }
            return Convert.ToInt32(response);
        }
        public static DataTable ConnectToDatabase_rekesz_listazas(string query)
        {
            string response = ClientSocket_Connector($"1#{query}");
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Sor");
            dt.Columns.Add("Oszlop");
            dt.Columns.Add("Szint");
            dt.Columns.Add("Alkatrész_ID");
            dt.Columns.Add("Mennyiség");
            dt.Columns.Add("Projekt_ID");
            foreach (var row in response.Split('#'))
            {
                DataRow _drow = dt.NewRow();
                _drow["Sor"] = row.Split(',')[0].Split(':')[1].Split('"')[1];
                _drow["Oszlop"] = row.Split(',')[1].Split(':')[1].Split('"')[1];
                _drow["Szint"] = row.Split(',')[2].Split(':')[1].Split('"')[1];
                _drow["Alkatrész_ID"] = row.Split(',')[3].Split(':')[1].Split('"')[1];
                _drow["Mennyiség"] = row.Split(',')[4].Split(':')[1].Split('"')[1];
                _drow["Projekt_ID"] = row.Split(',')[5].Split(':')[1].Split('"')[1];
                dt.Rows.Add(_drow);
            }

            return dt;
        }
    }
}   

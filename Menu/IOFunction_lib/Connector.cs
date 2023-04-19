using Class_library;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
                        user_data += $"{reader.GetString(0)},{reader.GetString(1)},{reader.GetString(2)}";
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
                    parts.Add(new Part(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), Convert.ToInt32(reader.GetString(2)), Convert.ToInt32(reader.GetString(3))));
                }
                return parts;


            }
            catch (Exception ex)
            {
                Environment.Exit(999);
            }
            return null;
        }

        public static string ConnectToDatabase_update_parts(string server, string port, string user, string password, string database,string query)
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

        public static string ConnectToDatabase_add_to_box(string server, string port, string user, string password, string database, string query)
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
    }
}

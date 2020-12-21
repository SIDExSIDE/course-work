using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class DB
    {
         private class ConfigConnection 
         {
            public static string Host = "127.0.0.1";
            public static string User = "root";
            public static string Password = "root";
            public static string DataBase = "polyclinic";
         }

        private static string StringConnection = $"server={ConfigConnection.Host};user={ConfigConnection.User};password={ConfigConnection.Password};database={ConfigConnection.DataBase}";

        MySqlConnection connection = new MySqlConnection(StringConnection);


        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }


        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }


        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}

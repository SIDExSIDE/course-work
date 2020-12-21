using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models.Users;

namespace WpfApp1
{
    class repositoryUsers
    {
        public static void AddUser(Users data)
        {
            DB db = new DB();

            const string TABLE = "users";

            string query = $"INSERT INTO {TABLE} (id, login, password) VALUE (NULL, '{data.login}', '{data.password}')";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            db.CloseConnection();
        }

        public static Users GetByLogin(string login)
        {
            Users data = new Users();
            DB db = new DB();

            const string TABLE = "users";
            string query = $"SELECT * FROM {TABLE} WHERE (login = '{login}')";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();
            
            data.id = reader.GetInt32("id");
            data.login = reader.GetString("login");
            data.password = reader.GetString("password");

            db.CloseConnection();

            return data;
        }

























        public static Users TEST()
        {
            Users data = new Users();
            DB db = new DB();

            const string TABLE = "users";
            string query = $"SELECT * FROM {TABLE}";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();

            data.id = reader.GetInt32("id");
            data.login = reader.GetString("login");
            data.password = reader.GetString("password");

            db.CloseConnection();

            return data;
        }
    }
}

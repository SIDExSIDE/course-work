using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Repository
{
    class repositoryPatients
    {
        public static List<Patients> GetAllPatients()
        {
            var result = new List<Patients>();

            var db = new DB();

            string table = "patients";
            string query = $"SELECT * FROM {table}";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var data = new Patients
                    (
                        Int32.Parse(reader.GetValue(0).ToString()),
                        reader.GetValue(1).ToString()
                    );

                result.Add(data);
            }

            db.CloseConnection();

            return result;
        }

        public static void AddPatient(Patients data)
        {
            var db = new DB();

            string query = $"INSERT patients VALUES (null, '{data.Name}')";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            command.ExecuteNonQuery();

            db.CloseConnection();
        }

        public static void DeletePatient(int id)
        {
            var db = new DB();

            string query = $"DELETE FROM patients WHERE id = {id}";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            command.ExecuteNonQuery();

            db.CloseConnection();
        }
    }
}

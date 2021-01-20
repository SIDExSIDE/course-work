using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using WpfApp1.Models;

namespace WpfApp1.Repository
{

    class repositorySession
    {
        public static List<Doctors> GetAllDoctors()
        {
            var result = new List<Doctors>();

            var db = new DB();

            string table = "doctors";
            string query = $"SELECT * FROM {table}";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var data = new Doctors
                    (
                        reader.GetValue(1).ToString()
                    );

                result.Add(data);
            }

            db.CloseConnection();

            return result;
        }

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
                        reader.GetValue(1).ToString()
                    );

                result.Add(data);
            }

            db.CloseConnection();

            return result;
        }

        public static void Add(Session data)
        {
            var db = new DB();

            string query = $"INSERT session VALUES (null, '{data.PatientName}', '{data.DoctorName}', '{data.Time}', '{data.Price}')";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            command.ExecuteNonQuery();

            db.CloseConnection();
        }

        /*public static void Delete(int id)
        {
            var db = new DB();

            string query = $"DELETE FROM session WHERE id = {id}";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            command.ExecuteNonQuery();

            db.CloseConnection();
        }*/
    }
}

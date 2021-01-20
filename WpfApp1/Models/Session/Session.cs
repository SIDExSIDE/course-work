using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string Time { get; set; }
        public int Price { get; set; }

        public Session(string patientName, string doctorName, string time, int price)
        {
            PatientName = patientName;
            DoctorName = doctorName;
            Time = time;
            Price = price;
        }

        public Session(int id, string patientName, string doctorName, string time, int price)
        {
            Id = id;
            PatientName = patientName;
            DoctorName = doctorName;
            Time = time;
            Price = price;
        }

        public override string ToString()
        {
            return $"Id:{this.Id}, PatientName:{this.PatientName}, DoctorName:{this.DoctorName}, Time:{this.Time}, Price:{this.Price}.";
        }
    }
}

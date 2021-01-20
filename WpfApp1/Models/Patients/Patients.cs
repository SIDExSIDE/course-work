using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Patients
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Patients(string name)
        {
            Name = name;
        }

        public Patients(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

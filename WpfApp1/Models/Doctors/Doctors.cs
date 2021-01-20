using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Doctors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Doctors(string name)
        {
            Name = name;
        }

        public Doctors(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        public Doctors(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}

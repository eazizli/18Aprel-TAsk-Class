using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18AprelTAskClass
{
    internal class Student
    {
        private static int _id;
        private static int _gropid;
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int GroupId { get; set; }

        public Student(string name, string surname)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            _gropid++;
           GroupId = _gropid;
        }
    }
}

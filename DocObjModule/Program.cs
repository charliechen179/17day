using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocObjModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { ID = 1, Name = "Sam", Gender = 'M', Age = 17 });
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
    }
}

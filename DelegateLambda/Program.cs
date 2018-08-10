using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambda
{
    public delegate void DelTest(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //DelTest delTest = (name) => { Console.WriteLine(name); };
            //delTest("list");
            //Console.ReadKey();

            object[] pers = { new Person { Name = "Sam", Age = 38 }, new Person { Name="Mike",Age=35} };

            object max = (pers) => {pers };


        }

        //static void Test1(string name)
        //{
        //    Console.WriteLine(name);
        //}
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

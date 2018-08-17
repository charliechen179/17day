using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynda.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = string.Empty;
            do
            {
                Console.WriteLine("Please input a number:");
                int input = 0;
               inputString = Console.ReadLine();
                if (Int32.TryParse(inputString, out input))
                {
                    // you know that the parsing attempt
                    // was successful
                    GetRamdonNumber ramdonNumber = new GetRamdonNumber();
                   
                    Console.WriteLine("Here is the number:{0:F8}",ramdonNumber.GetRandomNum(input));


                }
                else
                {
                    Console.WriteLine("Please input a valid number.");
                }
            } while (inputString.ToLower() != "exit");




        }
    }
}

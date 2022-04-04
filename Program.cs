using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name...");


            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Age...");

            string age = Console.ReadLine();

            //var input = Convert.ToInt32(age);

            Console.WriteLine("Hello {0}, you are {1} years old", name, age);



        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary;


namespace ClassLibraryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();

            Console.WriteLine(test.Print());

            Console.WriteLine(test.Print("Rik"));

            Console.WriteLine(test.CalculateAge(new DateTime(1990, 1, 1)));
        }

        
    }
}

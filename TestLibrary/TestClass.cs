using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TestLibrary
{
    public class TestClass
    {
  
        public string Print()
        {
            return "Hello World";
        }

        public string Print(string message)
        {
            return message;
        }

        public int CalculateAge(DateTime bornyear)
        {
            return DateTime.Now.Year - bornyear.Year;
        }

        

       

    }
}

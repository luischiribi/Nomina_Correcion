using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planta
{
    internal class ClassMain
    {
        public void Main(string[] args)
        {
            Operations operations = new Operations();
            Console.WriteLine("Welcome to the program payroll");
            Console.WriteLine("1.Register the new employed");
            Console.WriteLine("Exit the program");
            string op= Console.ReadLine();
            switch (op)
            {
                case "1":
                    operations.payroll();
                    operations.impresion();
                    break;
                case "2":
                    Console.WriteLine("Exit the program");
                    break;
                    default:
                    Console.WriteLine("Character invalid");
                    break;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Planta
{
    internal class Operations
    {
        Variables variables = new Variables();

        public void payroll()
        {
            TextWriter archivo = new StreamWriter("");
            Console.WriteLine("Eneter your id ");
            variables.Document1 = Console.ReadLine();
            Console.WriteLine("Enter your first name ");
            variables.FirstName1 = Console.ReadLine();
            Console.WriteLine("Enter your last name ");
            variables.LastName1 = Console.ReadLine();
            Console.WriteLine(" Enter your worked days ");
            variables.WorkedDays1 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Enter your salary ");
            variables.Salary1 = double.Parse(Console.ReadLine());
            string texto = Console.ReadLine().ToString();
            archivo.WriteLine(texto);
            archivo.Close();

            TextReader leer_archivo = new StreamReader("");
            Console.WriteLine(leer_archivo.ReadToEnd());
            leer_archivo.Close();

            TextWriter archivo2 = File.AppendText("");
            Console.WriteLine("Eneter your id ");
            variables.Document1 = Console.ReadLine();
            Console.WriteLine("Enter your first name ");
            variables.FirstName1 = Console.ReadLine();
            Console.WriteLine("Enter your last name ");
            variables.LastName1 = Console.ReadLine();
            Console.WriteLine(" Enter your worked days ");
            variables.WorkedDays1 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Enter your salary ");
            variables.Salary1 = double.Parse(Console.ReadLine());
            string texto2 = Console.ReadLine().ToString();
            archivo2.WriteLine(texto2);
            archivo2.Close();

            TextReader leer_archivo2 = new StreamReader("");
            Console.WriteLine(leer_archivo2.ReadToEnd());
            leer_archivo2.Close();
        }
        public void impresion()
        {
            Console.WriteLine($"document{variables.Document1}");
            Console.WriteLine($"First name{variables.FirstName1}");
            Console.WriteLine($"Second Name{variables.LastName1}");
            Console.WriteLine($"Salary{variables.Salary1}");
            Console.WriteLine($"Worked days{variables.WorkedDays1}");
            Console.WriteLine($"Total avanegado{variables.TotalAvanegado1}");
            Console.WriteLine($"Aux.Transport{variables.AuxTransport1}");
            Console.WriteLine($"Pension{variables.Pension}");
            Console.WriteLine($"Health{variables.Health1}");
            
        }

    }
}

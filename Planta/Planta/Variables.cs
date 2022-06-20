using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planta
{
    internal class Variables
    {
        private string Document;
        private string FirstName;
        private string LastName;
        private double Salary;
        private double WorkedDays;
        private double TotalAvanegado;
        private double AuxTransport;
        private double Health;
        private double pension;

        public Variables()
        {

        }

        public string Document1 { get => Document; set => Document = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public double Salary1 { get => Salary; set => Salary = value; }
        public double WorkedDays1 { get => WorkedDays; set => WorkedDays = value; }
        public double TotalAvanegado1 { get => TotalAvanegado; set => TotalAvanegado = value; }
        public double AuxTransport1 { get => AuxTransport; set => AuxTransport = value; }
        public double Health1 { get => Health; set => Health = value; }
        public double Pension { get => pension; set => pension = value; }
    }
}

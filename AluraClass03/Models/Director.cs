using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Director
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public double GetEmployeeBonus()
        {
            return Salario * 0.10;
        }
    }
}

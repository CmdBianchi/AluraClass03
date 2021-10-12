using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Director : Employee
    {
        // Base Constructor from Employee
        public Director( string cpf ) : base( cpf )
        {
        }

        // Override allow the overwritten
        public override void AddSalary() => Salary *= 1.15;
        public override double EmployeeBonus => Salary;
    }
}

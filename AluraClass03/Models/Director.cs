using Services;

namespace Models
{
    // Heritage Class SON : FATHER
    public class Director : ValidationEmployee
    {
        // Base 'SON' Constructor from 'FATHER' Employee
        public Director( string cpf ) : base(5000, cpf )
        {
        }

        // Override allow to overload the method
        public override void AddSalary() => Salary *= 1.15;
        public override double EmployeeBonus() => Salary + 1.10;
    }
}

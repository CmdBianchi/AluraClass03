namespace Models
{
    // Heritage Class SON : FATHER
    public class Director : Employee
    {
        // Base 'FATHER' Constructor from 'FATHER' Employee
        public Director( string cpf ) : base(5000, cpf )
        {
        }

        // Override allow to overload the method
        public override void AddSalary() => Salary *= 1.15;
        public override double EmployeeBonus() => Salary + 1.10;
    }
}

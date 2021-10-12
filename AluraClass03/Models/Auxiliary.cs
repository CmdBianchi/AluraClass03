namespace Models
{
    class Auxiliary : Employee
    {
        public Auxiliary( string cpf ) : base( 3000, cpf )
        {
        }

        // Override allow to overload the method
        public override void AddSalary() => Salary *= 1.05;
        public override double EmployeeBonus() => Salary * 0.25;
    }
}

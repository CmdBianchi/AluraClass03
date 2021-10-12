namespace Models
{
    class Designer : Employee
    {
        public Designer( string cpf ) : base( 3000, cpf )
        {
        }

        // Override allow to overload the method
        public override void AddSalary() => Salary *= 1.11;
        public override double EmployeeBonus() => Salary * 0.17;
    }
}

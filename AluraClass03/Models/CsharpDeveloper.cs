namespace Models
{
    class CsharpDeveloper : Employee
    {
        public CsharpDeveloper( string cpf ) : base( 3000, cpf )
        {
        }

        public override void AddSalary()
        {
            Salary *= 0.15;
        }

        public override double EmployeeBonus()
        {
            return Salary * 0.1;
        }
    }
}

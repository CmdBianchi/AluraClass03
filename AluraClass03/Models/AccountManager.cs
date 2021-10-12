using Services;

namespace Models
{
    // Heritage Class SON : FATHER
    class AccountManager : ValidationEmployee
    {
        // Base 'SON' Constructor from 'FATHER' Employee
        public AccountManager( string cpf ) : base( 4000, cpf )
        {
        }

        // Override allow to overload the method
        public override void AddSalary() => Salary *= 1.05;
        public override double EmployeeBonus() => Salary * 0.25;
    }
}

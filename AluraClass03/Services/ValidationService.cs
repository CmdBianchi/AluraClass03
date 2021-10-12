using Models;

namespace Services
{
    public abstract class ValidationService : Employee
    {
        public string Password { get; set; }
        public ValidationService( double salary, string cpf ) : base( salary, cpf )
        {
            Salary = salary;
            Cpf = cpf;
        }

        public bool Authentication( string passWord )
        {
            if( Password == passWord )
                return true;
            else
                return false;
        }
    }
}

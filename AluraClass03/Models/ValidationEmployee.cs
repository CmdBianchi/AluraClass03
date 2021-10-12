using Models;
using Services;

namespace Models
{
    public abstract class ValidationEmployee : Employee, IValidationService

    {
        public string Password { get; set; }
        public ValidationEmployee(double salary, string cpf ) : base(salary, cpf)
        {
        }

        public bool Authentication( string password)
        {
            return Password == password;
        }
    }
}

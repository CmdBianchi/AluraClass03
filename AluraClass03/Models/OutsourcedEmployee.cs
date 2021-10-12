using Services;

namespace Models
{
    public class OutsourcedEmployee : IValidationService
    {
        public string Password { get; set; }
        public bool Authentication( string password )
        {
            return Password == password;
        }                   
    }
}

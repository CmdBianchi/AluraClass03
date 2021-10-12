using Models;

namespace Services
{
    // Interface call contracts to permit polymorphism
    public interface IValidationService 
    {
        public bool Authentication( string passWord );
    }
}

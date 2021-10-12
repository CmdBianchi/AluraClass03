using Models;

namespace Services
{
    public class BonusService
    {
        private double _totalBonus;
        public void Register( Employee employee )
        {
            _totalBonus += employee.EmployeeBonus();
        }

        public double GetTotalBonus()
        {
            return _totalBonus;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Services
{
    public class BonusManager
    {
        private double _totalBonus;
        public void Register( Employee employee )
        {
            _totalBonus += employee.GetEmployeeBonus();
        }

        public void Register( Director director )
        {
            _totalBonus += director.GetEmployeeBonus();
        }

        public double GetTotalBonus()
        {
            return _totalBonus;
        }
    }
}

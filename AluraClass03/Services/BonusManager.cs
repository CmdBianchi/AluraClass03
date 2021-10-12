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
            _totalBonus += employee.EmployeeBonus;
        }

        public double GetTotalBonus()
        {
            return _totalBonus;
        }
    }
}

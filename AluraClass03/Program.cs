using System;
using Models;
using Services;

namespace AluraClass03
{
    class Program
    {
        static void Main( string[] args )
        {
            var b = new BonusManager();

            var e = new Employee();
            e.Name = "Charles";
            e.Cpf = "012.456.789-74";
            e.Salario = 1200.00;
            var bonusCharles = e.GetEmployeeBonus();

            var d = new Director();
            d.Name = "Roberta";
            d.Cpf = "458.745.693-78";
            d.Salario = 5000;
            var bonusRoberta = d.GetEmployeeBonus();

            b.Register( e );
            var totalBonus = b.GetTotalBonus();

            Console.WriteLine( bonusCharles );
            Console.WriteLine( bonusRoberta );
        }
    }
}

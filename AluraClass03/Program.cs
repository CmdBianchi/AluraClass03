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

            var e = new Employee( "012.456.789-74" );
            e.Name = "Charles";           
            e.Salary = 1200.00;
            var bonusCharles = e.EmployeeBonus;

            var d = new Director( "458.745.693-78");
            d.Name = "Roberta";           
            d.Salary = 5000;
            var bonusRoberta = d.EmployeeBonus;
            d.AddSalary();
            Console.WriteLine("New salary"+d.Salary);
            Console.WriteLine();

            b.Register( e );
            b.Register( d );
            var totalBonus = b.GetTotalBonus();

            Console.WriteLine( d.Name );
            Console.WriteLine( bonusCharles );
            Console.WriteLine( e.Name );
            Console.WriteLine( bonusRoberta );
            Console.WriteLine( "\n" + totalBonus );
            Console.WriteLine( );
        }
    }
}

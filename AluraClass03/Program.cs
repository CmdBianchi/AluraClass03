using System;
using Models;
using Services;
namespace AluraClass03
{
    class Program
    {
        static void Main( string[] args )
        {
            //BonusMethod();
            Loging();
            Console.ReadKey();
        }

        #region LogingChecker
        public static void Loging()
        {
            var internSystem = new InternSytemService();
            var roberta = new Director( "741.524.748-45" );
            roberta.Name = "Roberta";
            roberta.Password = "123";

            var camila = new AccountManager( "521.012.589-12" );
            camila.Name = "Camila";
            camila.Password = "abc";

            Console.WriteLine( internSystem.LogingChecker( roberta, "123" ) );
            Console.WriteLine( internSystem.LogingChecker( roberta, "123" ) );
            
        }
        #endregion

        #region BonusMethod
        public static void BonusMethod()
        {
            var b = new BonusService();

            var pedro = new Designer( "874.524.632-74" );
            pedro.Name = "Pedro";

            var roberta = new Director( "741.524.748-45" );
            roberta.Name = "Roberta";

            var igor = new Auxiliary( "741.458.852-41" );
            igor.Name = "Igor";

            var camila = new AccountManager( "521.012.589-12" );
            camila.Name = "Camila";

            var guilherme = new CsharpDeveloper( "147.548.357-89" );
            guilherme.Name = "Guilherme";


            b.Register( pedro );
            b.Register( roberta );
            b.Register( igor );
            b.Register( camila );
            b.Register( guilherme );
            Console.WriteLine( "Total of Employees: " + Employee.EmployeeAccount );
            Console.WriteLine( "Total bonus of the month: " + b.GetTotalBonus() );
        }
        #endregion
    }
}

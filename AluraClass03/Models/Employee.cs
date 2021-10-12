namespace Models
{
    public class Employee
    {
        public static int EmployeeAccount { get; private set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public double Salary { get; set; }

        public Employee( string cpf )
        {
            Cpf = cpf;
            EmployeeAccount++;
        }

        // Virtual allows method to be overwritten
        //Ways to write multiply a variable
        //Salary = Salary + ( Salary * 0.1 );
        //Salary = Salary * 1.1;
        public virtual void AddSalary() => Salary *= 1.1;
        public virtual double EmployeeBonus => Salary * 0.10;
    }
}

namespace Models
{
    public abstract class Employee
    {
        //Class Properties
        public static int EmployeeAccount { get; private set; }
        public string Name { get; set; }
        public string Cpf { get; protected set; }
        public double Salary { get; protected set; }

        //Class Constructors
        public Employee(double salary, string cpf )
        {
            Salary = salary;
            Cpf = cpf;
            EmployeeAccount++;
        }

        #region Click here to see ways to multilplie a variable
        //AddSalary() => Salary *= 1.1;
        // Salary = Salary + ( Salary * 0.1 );
        // Salary = Salary * 1.1;
        #endregion
       
        // Abstract allows the method to be call with declaration 
        public abstract void AddSalary();
        public abstract double EmployeeBonus();
    }
}

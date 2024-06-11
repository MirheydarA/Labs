namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee hourlyEmployee1 = new HourlyEmployee();
            hourlyEmployee1.Name = "Emp1";
            hourlyEmployee1.Surname = "emp1";
            hourlyEmployee1.Age = 30;
            hourlyEmployee1.HourlyRate = 10;
            hourlyEmployee1.HoursWorked = 5;

            hourlyEmployee1.CalculateSalary();
            hourlyEmployee1.DisplayDetails(hourlyEmployee1);

            Console.WriteLine("-------------------------------------------------");
            HourlyEmployee hourlyEmployee2 = new HourlyEmployee();
            hourlyEmployee1.Name = "Emp1";
            hourlyEmployee1.Surname = "emp1";
            hourlyEmployee1.Age = 30;
            hourlyEmployee1.HourlyRate = 10;
            hourlyEmployee1.HoursWorked = 5;

            hourlyEmployee1.CalculateSalary();
            hourlyEmployee1.DisplayDetails(hourlyEmployee1);


            Console.WriteLine("-------------------------------------------------");

            SalariedEmployee salariedEmployee = new SalariedEmployee();
            salariedEmployee.Name = "Emp2";
            salariedEmployee.Surname = "emp2";
            salariedEmployee.Age = 30;
            salariedEmployee.MonthlySalary = 1000;
            salariedEmployee.CalculateSalary();
            salariedEmployee.DisplayDetails(salariedEmployee);
        }
    }
}

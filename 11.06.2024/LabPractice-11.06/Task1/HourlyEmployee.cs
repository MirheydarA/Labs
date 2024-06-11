using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class HourlyEmployee : IEmployee
    {
        private static int _id;
        public HourlyEmployee() 
        {
            Id = _id;
            _id++;
        }

        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public void DisplayDetails<T>(T entity)
        {
            PropertyInfo[] properties = entity.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"{property.GetValue(entity)}");
            }
        }
    }
}

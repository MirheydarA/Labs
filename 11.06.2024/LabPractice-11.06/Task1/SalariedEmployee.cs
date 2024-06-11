using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SalariedEmployee : IEmployee
    {
        private static int _id;

        public SalariedEmployee()
        {
            Id = _id;
            _id++;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double MonthlySalary { get; set; }
        public double CalculateSalary()
        {
            return MonthlySalary;
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

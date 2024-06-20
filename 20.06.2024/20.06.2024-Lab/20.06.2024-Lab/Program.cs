//namespace _20._06._2024_Lab
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}

using _20._06._2024_Lab.Models;
using System.Linq.Expressions;

var employees = new List<Employee> {
    new Employee{ FirstName = "Nancy",    LastName="Davolio",   Age = 16 },
    new Employee{ FirstName = "Andrew",   LastName="Fuller",    Age = 12 },
    new Employee{ FirstName = "Janet",    LastName="Leverling", Age = 61 },
    new Employee{ FirstName = "Margaret", LastName="Peacock",   Age = 87 },
    new Employee{ FirstName = "Steven",   LastName="Buchanan",  Age = 69 },
    new Employee{ FirstName = "Michael",  LastName="Suyama",    Age = 61 },
    new Employee{ FirstName = "Robert",   LastName="King",      Age = 64 },
    new Employee{ FirstName = "Laura",    LastName="Callahan",  Age = 66 },
    new Employee{ FirstName = "Anne",     LastName="Dodsworth", Age = 58 },
};

Expression<Func<string, string>> expCustomizeName = n => n.Substring(0, 1).ToUpper()+n.Substring(1,n.Length-1).ToLower();
Expression<Func<string, string>> expCustomizeLastName = ln => ln.ToUpper();
Expression<Func<string, string, string>> expCreateMail = (m1,m2) => m1.ToLower()+m2.ToLower()+"@gmail.com";


var retVal = employees.AsQueryable().Select(
    x => new
    {
        Name = expCustomizeName.Compile()(x.FirstName),
        LastName = expCustomizeLastName.Compile()(x.LastName),
        Mail = expCreateMail.Compile()(x.FirstName, x.LastName),
    }
).ToList();

retVal.ForEach(x =>
{
    Console.WriteLine(x.Name);
    Console.WriteLine(x.LastName);
    Console.WriteLine(x.Mail);
});
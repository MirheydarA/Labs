namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OddOrEven(6);
            PositiveOrNegative(0);
            IsGPAA(91);
        }

        public static void OddOrEven(int number)
        {
            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
            else if (number == 0)
                Console.WriteLine("Number is 0");
            else
                Console.WriteLine("Number is Negative");


        }

        public static void PositiveOrNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine('+');
            }
            else if (number == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("-");
            }
        }

        public static void IsGPAA(int gpa)
        {
            if (gpa >= 91)
            {
                Console.WriteLine("GPA is 91+");
            }
            else
            {
                Console.WriteLine("GPA is not 91+");
            }
        }
    }
}

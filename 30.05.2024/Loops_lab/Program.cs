using System;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Channels;

namespace Loops_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmptySquare();
        }

        //Task3
        public static void Number(int num)
        {
            int sum = 0;
            int digit = 0;
            int k = 0;
            while (num >= 1)
            {
                digit = num % 10;
                sum = sum + digit;
                num = num - digit;
                num /= 10;

                k++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(k);
        }
        //Task1
        public static void FindMinAndMaxElements()
        {
            int[] numbers = { 9, 2, 8, 3, 4, 5, 6, 7, 1 };

            int min = numbers[0];
            int max = numbers[1];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
        //Task2
        public static void Find()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] oddNumber = { };
            int[] evenNumber = { };
            int countEven = 0;
            int countOdd = 0;
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Array.Resize(ref evenNumber, evenNumber.Length + 1);
                    evenNumber[evenNumber.Length - 1] = numbers[i];
                    countEven++;
                }

                else if (numbers[i] == 0)
                {
                    continue;
                }

                else
                {
                    Array.Resize(ref oddNumber, oddNumber.Length + 1);
                    oddNumber[oddNumber.Length - 1] = numbers[i];
                    countOdd++;
                }
            }

            Console.WriteLine(countEven);
            Console.WriteLine(countOdd);
        }


        //Task3
        public static void FindSumOfDigit()
        {
            string n = Console.ReadLine();
            int sum = 0;
            int num = Convert.ToInt32(n);
            for (int i = 0; i < n.Length; i++)
            {
                char digit = n[i];
                sum = sum + Convert.ToInt32(n[i].ToString());
            }
            Console.WriteLine(sum);
        }


        //Task4
        public static void Square()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine("");
            }
        }

        //Task5
        public static void Triangle()
        {
            int k = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write("x");
                }
                k++;
                Console.WriteLine("");
            }
        }

        //Task7
        public static void CarpimTablosu()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine("-  #---------------------#  -");
            }
        }
        //Task8
        public static void MiniConsoleApp()
        {
            Random rnd = new Random();
            int myRandomNo = rnd.Next(10000000, 99999999);

            Console.WriteLine(myRandomNo);
            int k = 1;
            while (k <= 3)
            {
                int testRandom = Convert.ToInt32(Console.ReadLine());
                if (testRandom == myRandomNo)
                {
                    Console.WriteLine("Congrulations");
                    break;
                }
                else
                {
                    Console.WriteLine($"You have just {3 - k}");
                    k++;
                }
            }
            Console.WriteLine("You dont have permission");
            Thread.Sleep(10000);

        }

        //Task9
        public static void MultiTasks()
        {
            int[] numbers = { 9, 2, 8, 3, 4, 5, 6, 7, 1, 12 };
            int[] divide2 = { };
            int[] notdivied2 = { };
            int sumodd = 0;
            int sumeven = 0;


            Console.WriteLine("divide both 2 and 3");
            foreach (var item in numbers)
            {
                if (item % 2 == 0 && item % 3 == 0)
                {
                    Console.WriteLine(item);
                }

                if (item % 2 == 0)
                {
                    Array.Resize(ref divide2, divide2.Length + 1);
                    divide2[divide2.Length - 1] = item;
                    sumeven = sumeven + item;
                }

                else
                {
                    Array.Resize(ref notdivied2, notdivied2.Length + 1);
                    notdivied2[notdivied2.Length - 1] = item;
                    sumodd = sumodd + item;
                }


            }
            Console.WriteLine("Just divide 2");
            foreach (var item in divide2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");
            Console.WriteLine("Not divide 2");
            foreach (var item in notdivied2)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"cift sayilarin toplami \n {sumeven} ");
            Console.WriteLine($"tek sayilarin toplami \n {sumodd} ");
        }

        //Task10
        public static void ShowMultiDimesnsionalArray()
        {
            int number;

            Console.Write("1 ile 6 arasında bir sayı girin: ");
            number = int.Parse(Console.ReadLine());

            int numberCount = number * number;

            int[] randomNumbers = new int[numberCount];

            Random random = new Random();

            int index = 0;
            while (index < numberCount)
            {
                int newNumber = random.Next(1, 50);
                bool exists = false;

                int i = 0;
                while (i < index)
                {
                    if (randomNumbers[i] == newNumber)
                    {
                        exists = true;
                        break;
                    }

                    i++;
                }

                if (!exists)
                {
                    randomNumbers[index] = newNumber;
                    index++;
                }
            }

            index = 0;
            while (index < numberCount)
            {
                int count = 0;
                while (count < number && index < numberCount)
                {
                    Console.Write(randomNumbers[index] + " ");
                    index++;
                    count++;
                }
                Console.WriteLine();
            }
        }

        //Task11
        public static void Login()
        {
            string username = "mirheyder";
            string password = "mirheyder123";

            string usernamFromConsolee;
            string passwordFromConsole;
            bool loginSuccess = false;

            do
            {
                Console.Write("Please enter username: ");
                usernamFromConsolee = Console.ReadLine();

                Console.Write("Please enter password: ");
                passwordFromConsole = Console.ReadLine();

                if (usernamFromConsolee == username && passwordFromConsole == password)
                {
                    Console.WriteLine("Login is successfull");
                    loginSuccess = true;
                }
                else
                {
                    Console.WriteLine("Login is not succesfull");
                }
            } while (!loginSuccess);
        }

        //Task6
        public static void EmptySquare()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Kenarlara X yaz
                    if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

using System.IO.Compression;

namespace ArraysLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsSimpleOrComplex();

        }

        public void FindMinElementIndex()
        {
            int[] array = { 0, 50, -11, 23, -18 };
            int indexOfMinEl;
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    indexOfMinEl = i;
                }
            }
        }

        public static void AvarageOfArray()
        {
            int sum = 0;
            int[] array = { 2, 4, 6 };
            int avarage = 0;
            foreach (var item in array)
            {
                sum = sum + item;
            }

            avarage = sum / array.Length;
            Console.WriteLine(avarage);
        }


        public static void IsSimpleOrComplex()
        {
            int k = 1;
            int count = 0;
            int[] array = { 2 , 3, 4, 6, 15 };
            int[] simpleNumber = { };
            int[] complexNumber = { };
            foreach (var item in array)
            {
                while (k <= item / 2)
                {
                    if (item % k == 0)
                    {
                        count++;
                    }
                    k++;
                }



                if (count >= 2)
                {
                    Array.Resize(ref complexNumber, complexNumber.Length + 1);
                    complexNumber[complexNumber.Length - 1] = item;
                }

                else
                {
                    Array.Resize(ref simpleNumber, simpleNumber.Length + 1);
                    simpleNumber[simpleNumber.Length - 1] = item;
                }




            }

            foreach (var item in complexNumber)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");

            foreach (var item in simpleNumber)
            {
                Console.Write($"{item} ");
            }


        }


    }
}

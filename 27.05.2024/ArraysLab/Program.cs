namespace ArraysLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public void FindMinElementIndex()
        {
            int[] array = { 0, 50, -11, 23, -18 };
            int indexOfMinEl;
            int min = array[0];
            for (int i = 0; i < array.Length ; i++) 
            {
                if (array[i] < min)
                {
                    min = array[i];
                    indexOfMinEl = i;

                }
            }
        }
    }
}

namespace Function_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindArea(5, 6, out int area);
            Console.WriteLine(area);
        }

        //circle
        public static void FindArea(int r, out int area)
        {
            int figureArea = 3 * r * r;
            area = figureArea;

        }

        //
        public static void FindArea(int a, int b, out int area)
        {
            int figureArea = (a * b) / 2;
            area = figureArea;
        }
    }
}

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Season");

            string season = Console.ReadLine().ToLower();

            switch (season)
            {
                case "spring":
                    Console.WriteLine("yaz");
                    break;
                case "summer":
                    Console.WriteLine("yay");
                    break;
                case "autumn":
                    Console.WriteLine("payiz");
                    break;
                case "winter":
                    Console.WriteLine("qis");
                    break;
                default:
                    Console.WriteLine("Season is not correct");
                    break;
            }

            var month = Console.ReadLine().ToLower();
            string monthAz = month switch
            {
                "spring" => "yaz",
                "summer" => "yay",
                "autumn" => "payiz",
                "winter" => "qis"
            };

            Console.WriteLine(monthAz);
        }
    }
}

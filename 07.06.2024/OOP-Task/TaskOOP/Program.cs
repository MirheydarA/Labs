using TaskOOP.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace TaskOOP
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter Author name");
            string authorName = Console.ReadLine();
            Console.WriteLine("enter price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter pagecount");
            int pageCount = Convert.ToInt32(Console.ReadLine());

            Book book = new Book(id, name, authorName, price, pageCount);

            Book.AddBook(book);

            Book.ListBooks();


            Console.WriteLine("enter name which you want delete");
            string selectedName = Console.ReadLine();
            Book getBook = Book.GetBook(selectedName);
            Console.WriteLine(getBook.Name);


        }


    }
}

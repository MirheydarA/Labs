using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace TaskOOP.Models
{
    public class Library
    {
        public static List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>();
        }


        //public static void AddBook(Book book)
        //{
        //    Books.Add(book);
        //    Console.WriteLine("book successfully added");
        //}


        public Book GetBook(string name)
        {
            name = Console.ReadLine();

            var selectedBook = Books.FirstOrDefault(b => b.Name == name);
            if (selectedBook is null)
            {
                Console.WriteLine("Book doesnt exist");
            }

            return selectedBook;
        }

        public void FindAllBooks()
        {
            foreach (var item in Books)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }


 
    }
}

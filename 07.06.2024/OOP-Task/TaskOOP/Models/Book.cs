using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace TaskOOP.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public float Price { get; set; }


        public static List<Book> Books = new List<Book>();

        public Book(int id, string name, string author, int pageCount, float price )
        {
            this.Id = id;
            this.Name = name;
            this.AuthorName = author;
            this.PageCount = pageCount;
            this.Price = price;

            Books = new List<Book>();
        }
        


        public static void AddBook(Book book)
        {
            
            Books.Add(book);
            Console.WriteLine("book successfully added");
        }

        public static void ListBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"{book.Id} - {book.Name} - {book.AuthorName}");
            }
        }

        public static Book GetBook(string name)
        {
            name = Console.ReadLine();

            var selectedBook = Books.FirstOrDefault(b => b.Name == name);
            if (selectedBook is null)
            {
                Console.WriteLine("Book doesnt exist");
            }

            return selectedBook;
        }

    }


    
}

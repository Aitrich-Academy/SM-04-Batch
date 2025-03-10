using static System.Reflection.Metadata.BlobBuilder;
using System.Net;
using System.Xml.Linq;
using System.Runtime.ExceptionServices;
using System.Xml.Serialization;

internal class Program
{
    public struct Book
    {
        public int Id;
        public string Title;
        public string Author;
    }
    private static void Main(string[] args)
    {

        Book book = new Book();

        Book[] book1 = new Book[5];


        Console.WriteLine("Welcome to vayana library");
        Console.WriteLine("Enter the no of books want to add:");
        int count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("enter the id of the book:");
            book.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the book title", i + 1);
            book.Title = Console.ReadLine();
            Console.WriteLine("Enter the Author details:", i + 1);
            book.Author = Console.ReadLine();
            Console.WriteLine($" Entered Book Details are:\n");


            Console.WriteLine($"Book Id:{book.Id}\nBook title: {book.Title}\nBook Author:{book.Author}");

            book1[i] = book;
        }

        Console.WriteLine("Book details\n");
        Console.WriteLine("ENTER the book id You want to search:");
        int id = Convert.ToInt32(Console.ReadLine());
        foreach (var Book in book1)
        {

            if (Book.Id == id)
            {
                Console.WriteLine($"Book Id:{Book.Id}\nBook title: {Book.Title}\nBook Author:{Book.Author}");
            }
        }
    }
}
     
  


    

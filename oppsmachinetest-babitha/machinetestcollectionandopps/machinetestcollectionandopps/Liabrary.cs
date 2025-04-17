using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machinetestcollectionandopps
{
    //Create a Library class that contains a collection (List) of books.
    // Implement methods to add books, remove books, and display all available books.

    public class Liabrary:Book

    {
       List<Book> books = new List<Book>();

    
        // Method to add a book to the library
        public void AddBook(Book book)
        {
            
            Console.WriteLine("how many books you want to add");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Book book1 = new Book();
                Console.WriteLine("Enter book title: ");
                book1.Title = Console.ReadLine();
                Console.WriteLine("Enter book author: ");
                book1.Author = Console.ReadLine();
                Console.WriteLine("Enter book ISBN: ");
                book1.ISBN = Console.ReadLine();
                Console.WriteLine("Enter quantity available: ");
                book1.QuantityAvailable = Convert.ToInt32(Console.ReadLine());
                books.Add(book1);
                Console.WriteLine("Book added successfully with ISBN:"+book1.ISBN);
            }


        }
        // Method to remove a book from the library
        public void RemoveBook(string isbn)
        {
           
            Console.WriteLine("Enter the ISBN of the book to remove: ");
            string isbnToRemove = Console.ReadLine();
            var bookToRemove = books.FirstOrDefault(b => b.ISBN == isbnToRemove);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Book with ISBN {isbnToRemove} removed from the library.");
            }
            else
            {
                Console.WriteLine($"Book with ISBN {isbnToRemove} not found in the library.");
            }
            try
            {                 
                if (bookToRemove == null)
                {
                    throw new Exception("Book not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void BorrowBook(string isbn)
        {
            Console.WriteLine("Enter ISBN of book for borrowing:");
            string isbnToBorrow= Console.ReadLine();

            var bookToBorrow = books.FirstOrDefault(b => b.ISBN == isbnToBorrow);
            if (bookToBorrow != null && bookToBorrow.QuantityAvailable > 0)
            {
                bookToBorrow.QuantityAvailable--;
                Console.WriteLine($"You have borrowed the book with ISBN {bookToBorrow.ISBN}. Remaining copies: {bookToBorrow.QuantityAvailable}");
            }
            else
            {
               Console.WriteLine($"Book with ISBN {isbn} is not available for borrowing.");
            }
            try
            {                 
                if (bookToBorrow.QuantityAvailable <= 0)
                {
                    throw new Exception("Book is out of stock.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            




        }
        // Method to display all available books
        public void DisplayAvailableBooks()
        {
            Console.WriteLine("Available books in the library:");
            if (books.Count == 0)
            {
                Console.WriteLine("No books available in the library.");
                return;
            }
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Quantity Available: {book.QuantityAvailable}");
            }
        }




    }
}

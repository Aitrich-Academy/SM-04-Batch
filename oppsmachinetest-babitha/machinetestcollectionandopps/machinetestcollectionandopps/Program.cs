using machinetestcollectionandopps;

internal class Program
{
    private static void Main(string[] args)
    {
        //Create a Library Management System using OOP concepts in C#.
        Liabrary library = new Liabrary();
        Book book = new Book();

       
        int choice;
        Console.WriteLine("Library Management System");
        Console.WriteLine("--------------------------------");
       
        do
        {
            Console.WriteLine("1. Add Book\n2.Remove Book\n3.Borrow Books\n4.Display all available book\n0.Exit");
            Console.WriteLine("Enter your choice: ");
             choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    library.AddBook(book);

                    break;
                case 2:
                    library.RemoveBook(book.ISBN);
                    break;
                case 3:
                    library.BorrowBook(book.ISBN);
                    break;
                case 4:
                    library.DisplayAvailableBooks();
                    break;
                case 0:
                    Console.WriteLine("Exiting the Library Management System.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
           
        } while (choice != 0);



    }
}
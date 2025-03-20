using constructoroverloading;

internal class Program
{
    private static void Main(string[] args)
    {
      Book b=new PrintedBook("c", "jo", 1991, 50);
        b.GetBookDetails();
    EBook eBook=new EBook("java", "jo", 1991, "big");
        eBook.GetBookDetails();

}
}


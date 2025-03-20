using Classexample;

internal class Program
{
    public static void Main(string[] args)
    {
        Fruit obj= new Fruit("mango","yellow");
        Fruit obj1 = new Fruit("apple", "red");
        obj1.display();
        obj.display();


    }
}
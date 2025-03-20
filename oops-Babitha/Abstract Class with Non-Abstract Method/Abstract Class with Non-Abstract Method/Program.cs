using Abstract_Class_with_Non_Abstract_Method;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal animal = new Dog();
        animal.MakeSound();
        Animal animal2 = new Cat();
        animal2.MakeSound();
    }
}
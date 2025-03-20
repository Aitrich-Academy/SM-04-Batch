using Basic_Interface_Implementation;

internal class Program
{
    private static void Main(string[] args)
    {
        IAnimal animal = new Cat();
        animal.MakeSound();
        IAnimal animal2 = new Dog();
        animal2.MakeSound();
    }
}
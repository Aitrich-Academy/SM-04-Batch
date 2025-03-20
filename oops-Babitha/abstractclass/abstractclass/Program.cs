using abstractclass;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal dog = new Dog();
        dog.Eat();
        dog.Sound();
    }
}
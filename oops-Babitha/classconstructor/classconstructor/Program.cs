using classconstructor;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal dog = new Animal("Dog", "Black", 4);
        dog.display();
        Animal cat = new Animal("Cat", "White", 4);
        cat.display();
        Animal lion = new Animal("Lion", "Brown", 4);
        lion.display();
        Animal elephant = new Animal("Elephant", "Grey", 4);
        elephant.display();
        Animal horse = new Animal("Horse", "Brown", 4);
        horse.display();
    }
}
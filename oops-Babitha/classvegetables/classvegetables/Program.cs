using classvegetables;

internal class Program
{
    private static void Main(string[] args)
    {
        Vegetable vegetable = new Vegetable("Tomato", "Red", "Fruit");
        vegetable.display();
        vegetable = new Vegetable("Carrot", "Orange", "Root");
        
        vegetable.display();
        vegetable = new Vegetable("Spinach", "Green", "Leafy");
        vegetable.display();
        Pulses pulses = new Pulses("Lentils", "Yellow", "Dal");
        pulses.display();
        pulses = new Pulses("Chickpeas", "Brown", "Chana");
        pulses.display();
        pulses = new Pulses("Green Gram", "Green", "Moong");
        pulses.display();
        Spices s1 = new Spices("Cumin", "Brown", "Seeds");
        s1.display();
        s1 = new Spices("Cinnamon", "Brown", "Sticks");
        s1.display();
        s1 = new Spices("Turmeric", "Yellow", "Powder");
        s1.display();
        Spices s2 = new Spices("Coriander", "Green", "Seeds");
        s2.display();


    }
}
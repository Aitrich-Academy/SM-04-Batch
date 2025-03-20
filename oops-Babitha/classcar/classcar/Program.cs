using classcar;

internal class Program
{
    private static void Main(string[] args)
    {
       Car car1 = new Car("Mustang", "Red", 1969);
        car1.display();
        car1.model = "Camaro";
        car1.color = "Black";
        car1.year = 1968;
        car1.display();
        car1 = new Car("Challenger", "Green", 1970);
        car1.display();
        car1 = new Car("swift", "Blue", 1971);
        car1.display();
    }
}
using polymorphism_vehicleshowroom;

internal class Program
{
    private static void Main(string[] args)
    {
     // Vehicle v=new Vehicle("Toyota", "Corolla", 20000);
        Vehicle c1 = new Car("Toyota", "Corolla", 20000);
        c1.DisplayInfo();
        Vehicle b1 = new Bike("Yamaha", "FZ", 1500);
        b1.DisplayInfo();
        

    }
}
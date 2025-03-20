using MultipleClassImplementingSameInterface;

internal class Program
{
    private static void Main(string[] args)
    {
        IVehicle bike = new Bike();
        bike.StartEngine();
        bike.StopEngine();
        IVehicle car = new Car();
        car.StartEngine();
        car.StopEngine();
    }
}
using Method_Overriding;

internal class Program
{
    private static void Main(string[] args)
    {
        //Vehicle vehicle = new Vehicle();
        //vehicle.ShowDetails();
        //Car car = new Car();
        //car.ShowDetails();
        Dog dog = new Dog("bow bow");
        dog.MakeSound();
        dog.Walk(); 

    }
}
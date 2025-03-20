using Abstract_Classshape;

internal class Program
{
    private static void Main(string[] args)
    {
       Circle shape = new Circle(3);
       shape.CalculateArea();
       
        Rectangle shape2 = new Rectangle(10,20);
        shape2.CalculateArea();
        
    }
}
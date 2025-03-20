using AbstrClasswithPropertie;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee1 employee1 = new FullTimeEmployee();
        employee1.salary();
        Employee1 employee2 = new FullTimeEmployee();
        employee2.salary();

    }
}
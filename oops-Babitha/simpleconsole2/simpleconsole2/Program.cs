using simpleconsole2;

internal class Program
{
    private static void Main(string[] args)
    {
        Manager m1 = new Manager();
        m1.DisplayDetails(1, "babi", "developer");
        Person p1= new Employee();
        p1.GetRole();
    }
}
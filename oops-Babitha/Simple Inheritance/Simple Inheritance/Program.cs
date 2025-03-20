using Simple_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student();
        student.name = "John";
        student.age = 21;
        student.studentID = 1001;
        student.display();
    }
}
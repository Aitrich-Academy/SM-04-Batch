internal class Program
{
    struct Employee
    {
        public int Id;
        public string Name;
        public int salary;

        public Employee(int id, string name, int salary)
        {
            Id = id;
            Name = name;
            salary = salary;
        }
       public void Display()
        {
            Console.WriteLine("Employee Id: " + Id);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Salary: " + salary);
        }
    }

    

    private static void Main(string[] args)
    {
       
        Employee e1 = new Employee(1, "Raj", 10000);
         e1.Display();


    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------Sales Data Analysis---------------");
        double[] sales = new double[7];

        Console.WriteLine("Enter sales data for a week:");
        for (int i = 0; i < sales.Length; i++)
        {
            Console.Write("Enter sales for day " + (i + 1) + ": ");
            sales[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nSales data entered successfully\n");
        Console.WriteLine("\nSales data is as follows\n");
        for (int i = 0; i < sales.Length; i++)
        {
            Console.WriteLine("Sales for day " + (i + 1) + ": " + sales[i]);
        }

        double total = 0;
        double average = 0;
        for (int i = 0; i < sales.Length; i++)
        {
            total += sales[i];
            average = total / sales.Length;
        }
        Console.WriteLine("\nTotal sales is: " + total);
        Console.WriteLine("Average sales is: " + average);
    
        double highest = sales[0];
        double lowest = sales[0];
        int highestindex = 0;
        int lowestindex = 0;
        for (int i = 0; i < sales.Length; i++)
        {
            if (sales[i] > highest)
            {
                highest = sales[i];
                highestindex = i;
            }
            if (sales[i] < lowest)
            {
                lowest = sales[i];
                lowestindex = i;
            }
        }
        Console.WriteLine("Highest sales is: " + highest + " on day: " + (highestindex +1));
        Console.WriteLine("Lowest sales is: " + lowest + " on day: " + (lowestindex + 1));

    }
}
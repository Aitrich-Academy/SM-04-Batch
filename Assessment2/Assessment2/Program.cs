using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using Assessment2;

internal class Program
{
    private static void Main(string[] args)
    {
        bool Chance=true;
        do {

            

            Console.WriteLine("Welcome to SBI");

            Console.WriteLine($"Select the Bank Process for You\n1.Create a new bank account\n2.Remove an account\n3.Deposit Money\n4.Withdraw Money\n5.Check bankbalance");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter your details");
                   
                    
                    break;
                case 2:
                    Console.WriteLine("Enter the Account Number want to remove");
                    
                   

                    break;
                case 3:
                    Console.WriteLine("Enter the amount want to deposit");

                    break;
                case 4:
                    Console.WriteLine("Enter the aamount want to withdraw");
                    break;
                case 5:
                    Console.WriteLine("Your balance ");
                    


                    break;

                default:
                    Console.WriteLine("invalid");
                    break;
            }
            List<Bankaccount> list = new List<Bankaccount>();
            try
            {
                list.Add(new Bankaccount(3211, "Meenu", 290000, "Saving"));
                list.Add(new Bankaccount(2534, "Reguvaran", 15000, "Current"));
                list.Add(new Bankaccount(3422, "Leelamma", 150000, "Current"));
                list.Add(new Bankaccount(2578, " Abdul Khader", 1600000, "Savings"));
                list.Add(new Bankaccount(1234, "Rani Bhai", 343256, "Current"));
                list.Add(new Bankaccount(6543, "Soudha Subair", 37000, "Current"));



                foreach (Bankaccount item in list)
                {
                    if (item.AccountNumber != 0)
                    {
                        Console.WriteLine(item.AccountNumber);
                        Console.WriteLine(item.AccountHolderName);
                        Console.WriteLine(item.Balance);
                        Console.WriteLine(item.AccountType);
                    }
                    else
                    {
                        throw new NotFiniteNumberException();
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }





        }while (Chance==true);
}
}
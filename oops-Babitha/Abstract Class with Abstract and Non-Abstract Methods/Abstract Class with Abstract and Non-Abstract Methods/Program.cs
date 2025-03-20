using Abstract_Class_with_Abstract_and_Non_Abstract_Methods;

internal class Program
{
    private static void Main(string[] args)
    {
       BankAccount account = new SavingsAccount();
        account.CalculateInterest();
        BankAccount a=new CurrentAccount();
        a.CalculateInterest();
        account.ShowBalance();
        a.ShowBalance();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public class Bankaccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public int Balance { get; set; }
        public string AccountType { get; set; }
        public Bankaccount(int accountnum, string accountholdername, int bal, string accounttype)
        {
            AccountNumber = accountnum;
            AccountHolderName = accountholdername;
            Balance = bal;
            AccountType = accounttype;
        }
        public void display()
        {
            if (AccountNumber == 0)
            {
                Console.WriteLine("Invalid ");

            }
            else
            {
                Console.WriteLine("Welcome to SBI");
                Console.WriteLine($"Account number:{AccountNumber}\nName:{AccountHolderName}\nBalance Amount:{Balance}\nAccountType:{AccountType}");
            }
        }
    }
}
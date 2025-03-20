using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_with_Abstract_and_Non_Abstract_Methods
{
   public abstract class BankAccount
    {
        public abstract void CalculateInterest();
        public void ShowBalance()
        {
            Console.WriteLine("balance");
        }
    }
}

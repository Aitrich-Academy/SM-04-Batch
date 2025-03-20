using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_with_Abstract_and_Non_Abstract_Methods
{
  public  class SavingsAccount:BankAccount
    {
       public override  void CalculateInterest()
        {
            Console.WriteLine("the interest is: 5%");
            
            

        }
    }
}

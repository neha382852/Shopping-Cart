using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingcart
{
    class CardPayment : IPayment
    {
        int cardno, cvv, expirydate;
        string cardname;
         public void PayAmount(int amount)
            {
                Console.WriteLine("Enter card details");
                Console.WriteLine("Enter cardno:");
                cardno = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter cvv:");
                 cvv = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Expiry Date:");
                expirydate = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Card Name:");
                cardname = Console.ReadLine();
                Console.WriteLine("The amount: " + amount + "has been successfully deducted from your account");
            }

        }
}


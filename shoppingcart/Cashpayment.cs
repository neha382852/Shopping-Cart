using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingcart
{
    class Cashpayment : IPayment
    {
        public void PayAmount(int amount)
        {
            Console.WriteLine("Payable Amount:" + amount);
        }
    }
}

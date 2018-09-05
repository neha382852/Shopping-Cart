using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingcart
{
    class PayAmount
    {
        int totalPrice = 0;
        public void CalculatePayment(List<Item> itemsList)
        {
            foreach (Item item in itemsList)
            {
                totalPrice += item.ItemPrice;
            }
            Console.WriteLine("Total amount to pay: "+ totalPrice);
        }
    }
}


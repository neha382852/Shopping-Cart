using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingcart
{
    interface ICartOperations
    {
       void AddToCart(Item item,int countofitems);

        void RemoveFromCart(Item item);

        void DisplayCart();

        void ClearCart();

      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingcart
{
    class CartOperations:ICartOperations
    {
        Program obj = new Program();
        public List<Item> cartItems = new List<Item>();
        Item itemObject = new Item();
        int itemindex = 0;
        int flag= 0;
        public void AddToCart(Item item,int countofitems)
        {
            for(int i=0; i < countofitems;i++)
            {
                cartItems.Add(item);
            }
            
            Console.WriteLine(countofitems+ "Item successfully added to cart");
        }

        public void RemoveFromCart(Item item)
        {
            flag = 0;
            foreach (Item items in cartItems)
            {
                if (item.ItemId == items.ItemId)
                {
                    cartItems.Remove(item);
                    Console.WriteLine("The item is removed from the cart.");
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("The item does not exists in the cart.");
            }

        }

        public void DisplayCart()
        {
            itemindex = 0;
            foreach (Item item in cartItems)
            {
                Console.WriteLine("index:" + itemindex + " Id: " + item.ItemId + " Name: " + item.ItemName + " Quantity: " + item.ItemQuantity + " Price:" + item.ItemPrice);
                itemindex++;
            }
        }

        public void ClearCart()
        {
            cartItems.Clear();
            Console.WriteLine("Cart is empty");
        }

    }
}

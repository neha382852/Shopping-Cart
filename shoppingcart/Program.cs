using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemsContainer obj = new ItemsContainer();
            List<Item> itemsList = obj.getItems();
            CartOperations cartObject = new CartOperations();
            PayAmount paymentObject = new PayAmount();
            int flag = 1;
            int itemid = 0;
            int index = 0;
            int option;
            int quantity = 0;
            while (flag == 1)
            {
                Console.WriteLine("Enter number of operation you want to perform \n 1: display items available \n 2: Add to cart \n 3: Remove item from cart \n 4: Display cart \n 5: clear cart \n 6: Purchase items from the cart \n ");
                option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            foreach (Item item in itemsList)
                            {
                                Console.WriteLine(" Id: " + item.ItemId + " Name: " + item.ItemName + " Quantity: " + item.ItemQuantity + " Price:" + item.ItemPrice);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the id of item which you want to add");
                            itemid = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the quantity of item which you want to add");
                            quantity = Int32.Parse(Console.ReadLine());

                            cartObject.AddToCart(itemsList.Find(x => x.ItemId == itemid), quantity);
                            
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the id of item from cart list which you want to remove");
                            index = Int32.Parse(Console.ReadLine());
                            cartObject.RemoveFromCart(itemsList[index]);
                            break;
                        }
                    case 4:
                        {
                            cartObject.DisplayCart();
                            break;
                        }
                    case 5:
                        {
                            cartObject.ClearCart();
                            break;
                        }
                    case 6:
                        {
                            paymentObject.CalculatePayment(cartObject.cartItems);
                            break;
                        }

                }

                Console.WriteLine("Do you want to exit:- 1. No 0. Yes");
                flag = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
  
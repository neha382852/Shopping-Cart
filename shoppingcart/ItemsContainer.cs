using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingcart
{
    class ItemsContainer
    {
        public static List<Item> itemsList = new List<Item>()
            {
                new Item
            {
               ItemName="Basketball",
               ItemId=1,
               ItemQuantity=80,
               ItemPrice=1000,
            },
            new Item
            {
                ItemName="SchoolBag",
               ItemId=2,
               ItemQuantity=50,
               ItemPrice=2000,

            },
             new Item
            {
                ItemName="MobilePhone",
               ItemId=3,
               ItemQuantity=100,
               ItemPrice=20000,

            }

            };
       public List<Item> getItems()
        {
            return itemsList;
        }
    }
}

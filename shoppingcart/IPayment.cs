using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingcart
{
    interface IPayment
    { 
        void PayAmount(int amount);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Drinks.RequestModels
{
    public class DrinkInventoryRequest
    {
        public string DrinkName { get; set; }
        public int Quantity { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Drinks.ResponseModels
{
    public class DrinkInventoryList
    {
        // Currently no count is implemented on the server side
        public int Count { get; set; }
        public List<DrinkInventory> Data { get; set; }
    }
}

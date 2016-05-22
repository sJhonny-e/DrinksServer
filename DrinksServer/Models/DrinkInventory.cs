using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrinksServer.Models
{
    public class DrinkInventory
    {
        public Drink Drink { get; private set; }
        public int Quantity { get; private set; }

        public DrinkInventory(Drink drink)
        {
            Drink = drink;
            Quantity = 0;
        }

        public DrinkInventory(Drink drink, int quantity): this(drink)
        {
            Quantity = quantity;
        }
    }
}
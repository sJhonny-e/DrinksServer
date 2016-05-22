using DrinksServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrinksServer.Controllers.DTOs
{
    public class DrinkDTO
    {
        public string DrinkName { get; set; }
        public int Quantity { get; set; }

        public DrinkDTO(DrinkInventory drinkInventory)
        {
            DrinkName = drinkInventory.DrinkName;
            Quantity = drinkInventory.Quantity;
        }
    }
}
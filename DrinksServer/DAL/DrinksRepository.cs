using DrinksServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrinksServer.DAL
{
    public class DrinksRepository : IDrinksRepository
    {

        private List<DrinkInventory> _allDrinks = new List<DrinkInventory>();

        public bool Add(DrinkInventory drinkInventory)
        {
            var existing = Get(drinkInventory.DrinkName);
            if (existing != null)
            {
                return false;
            }

            _allDrinks.Add(drinkInventory);
            return true;
        }

        public DrinkInventory Get(string drinkName)
        {
            return _allDrinks.FirstOrDefault(drinkInventory => drinkInventory.DrinkName.ToLower() == drinkName.ToLower());
        }

        public IEnumerable<DrinkInventory> GetAll()
        {
            return _allDrinks;
        }
    }
}
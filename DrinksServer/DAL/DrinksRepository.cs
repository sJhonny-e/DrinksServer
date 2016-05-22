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

        public DrinkInventory Get(string drinkName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DrinkInventory> GetAll()
        {
            return _allDrinks;
        }
    }
}
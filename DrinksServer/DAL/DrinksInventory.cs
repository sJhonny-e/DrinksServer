using DrinksServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrinksServer.DAL
{
    public class DrinksInventory : IDrinksRepository
    {
        public DrinkInventory Get(string drinkName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DrinkInventory> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
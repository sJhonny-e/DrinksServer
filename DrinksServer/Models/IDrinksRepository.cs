using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksServer.Models
{
    public interface IDrinksRepository
    {
        IEnumerable<DrinkInventory> GetAll();
        DrinkInventory Get(string drinkName);
        bool Add(DrinkInventory drinkInventory);
        bool Delete(string drinkName);
    }
}

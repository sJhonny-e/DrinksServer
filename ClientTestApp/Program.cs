using Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var apiClient = new APIClient("not really a key", Checkout.Helpers.Environment.Sandbox, true);
            var drinksService = apiClient.DrinksService.GetDrinksList();
        }
    }
}

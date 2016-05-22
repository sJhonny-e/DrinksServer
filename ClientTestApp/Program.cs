using Checkout;
using Checkout.ApiServices.Drinks.RequestModels;
using Checkout.ApiServices.Drinks.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTestApp
{
    class Program
    {
        static APIClient _client;
        static void Main(string[] args)
        {
            _client = new APIClient("not really a key", Checkout.Helpers.Environment.Sandbox, true);
            
            PrintList();

            var request = new DrinkInventoryRequest { DrinkName = "wot", Quantity = 88 };
            var response = _client.DrinksService.CreateDrink(request);
            Console.WriteLine("Create drink response: {0}", response);

            PrintList();

            var updateRequest = new DrinkInventoryRequest { DrinkName = "WOT", Quantity = 45 };
            response = _client.DrinksService.UpdateDrink(updateRequest);
            Console.WriteLine("Update drink response: {0}", response);

            var singleDrinkResponse = _client.DrinksService.GetDrink("wot");
            Console.WriteLine("Wot now has quantity of: {0}", singleDrinkResponse.Model.Quantity);

            var deleteResponse = _client.DrinksService.DeleteDrink("wot");
            Console.WriteLine("Delete drink response: {0}", deleteResponse);

            PrintList();

        }

        private static void PrintList()
        {
            var drinksResponse = _client.DrinksService.GetDrinksList();
            var drinks = drinksResponse.Model;
            Console.WriteLine("Currently, we have {0} total drinks: {1}", drinks.Count, String.Join(", ", drinks.Select(d => d.DrinkName)));
        }
    }
}

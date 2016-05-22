using Checkout.ApiServices.Drinks.ResponseModels;
using Checkout.ApiServices.SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Drinks
{
    public class DrinksService
    {
        public HttpResponse<DrinkInventoryList> GetDrinksList()
        {
            var getDrinksListUri = ApiUrls.Drinks;

            var kuku = new ApiHttpClient().GetRequest<List<DrinkInventory>>(getDrinksListUri, AppSettings.SecretKey);

            return null;
        }
    }
}

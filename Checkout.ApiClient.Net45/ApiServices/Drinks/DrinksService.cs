using Checkout.ApiServices.Drinks.RequestModels;
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
        public HttpResponse<List<DrinkInventory>> GetDrinksList()
        {
            var getDrinksListUri = ApiUrls.Drinks;

            return new ApiHttpClient().GetRequest<List<DrinkInventory>>(getDrinksListUri, AppSettings.SecretKey);
        }

        public HttpResponse<OkResponse> CreateDrink(DrinkInventoryRequest request)
        {
            return new ApiHttpClient().PostRequest<OkResponse>(ApiUrls.Drinks, AppSettings.SecretKey, request);
        }
    }
}

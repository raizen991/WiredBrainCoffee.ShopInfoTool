using System;
using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { Location = "Frankfurt", BeansInStocInKg = 107 };
            yield return new CoffeeShop { Location = "Freiburg", BeansInStocInKg = 23 };
            yield return new CoffeeShop { Location = "Munich", BeansInStocInKg = 56 };
        }
    }
}

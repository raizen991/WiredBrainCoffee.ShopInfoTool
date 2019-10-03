using System;
using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.ShopInfoTool
{
    internal class HelpCommandHandler : ICommandHandler
    {
        private IEnumerable<CoffeeShop> coffeeShops;
        private string line;

        public HelpCommandHandler(IEnumerable<CoffeeShop> coffeeShops, string line)
        {
            this.coffeeShops = coffeeShops;
            this.line = line;
        }

        public void HandleCommand()
        {
            Console.WriteLine("> Available shop commands:");
            foreach (var coffeeShop in coffeeShops)
            {
                Console.WriteLine($"> {coffeeShop.Location}");
            }
        }
    }
}
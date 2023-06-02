using CoffeeShop.ShopInfoTool.Data;

namespace CoffeeShop.ShopInfoTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to WiredBrainCoffee Shopping info tool. ");
            Console.WriteLine("Commands:");
            Console.WriteLine(" quit  exit application");
            Console.WriteLine(" shops Show coffeeshops");
            while (true)
            {
                var command = Console.ReadLine();
                if (string.Equals("quit", command, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else if (string.Equals("shops", command, StringComparison.OrdinalIgnoreCase))
                {
                    var dataProvider = new CoffeeShopDataProvider();
                    var coffeeShops =  dataProvider.LoadShops();
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"{coffeeShop.City} has {coffeeShop.CupsInStock} cups in stock. ");

                    }
                }
                else
                {
                    Console.WriteLine($"Invalid command: {command}");
                }
            }
        }
    }
}
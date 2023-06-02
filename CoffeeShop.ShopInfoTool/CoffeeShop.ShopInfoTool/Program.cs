namespace CoffeeShop.ShopInfoTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to WiredBrainCoffee Shopping info tool. ");
            Console.ReadLine();
            Console.WriteLine(" quit  exit application");
            while (true)
            {
                var command = Console.ReadLine();
                if (string.Equals("quit", command, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
        }
    }
}
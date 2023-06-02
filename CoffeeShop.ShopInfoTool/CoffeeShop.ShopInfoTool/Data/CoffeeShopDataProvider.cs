namespace CoffeeShop.ShopInfoTool.Data;
using CoffeeShop.ShopInfoTool.Model;

public class CoffeeShopDataProvider
{
    public IEnumerable<CoffeeShop> LoadShops()
    {
        return new CoffeeShop[]
        {
            new CoffeeShop("Frankfurt",45),
            new CoffeeShop("Zurich",39),
            new CoffeeShop("Rome",25),
        };
    }
}

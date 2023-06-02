namespace CoffeeShop.ShopInfoTool.Model
{

    public class CoffeeShop
    {
        public string City;
        public int CupsInStock;
        public CoffeeShop(string city, int cups)
        {
            this.City = city;
            this.CupsInStock = cups;
        }
    }

}


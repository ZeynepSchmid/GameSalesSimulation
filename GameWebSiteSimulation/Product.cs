using System;
namespace GameWebSiteSimulation
{
    public class Product
    {
        public double price=0;
        public string name=" ";
        public int star=0;

        public Product(string name, double price, int stars) {
            if (name.Length > 1)
                this.name = name;
            this.price = price;
            if (stars <= 5 && stars > 0)
                this.star = stars;
        }
        public Product(string name, double price)
        {
            if (name.Length > 1)
                this.name = name;
            this.price = price;
        }

     
    }
}

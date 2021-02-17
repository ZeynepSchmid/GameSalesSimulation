using System;
namespace GameWebSiteSimulation
{
    public class SaleManager
    {
        Client client;
        public SaleManager(Client client)
        {
            this.client = client;
            Console.WriteLine(client.firstName + " in shop");
        }
        public void buy(Product product) {
            if (client.ifReal())
            {
                Console.WriteLine(client.firstName + " buyed " + product.name +
                    " for " + product.price.ToString() + "$");
            }
            else {
                Console.WriteLine("you have to existence to buy something");
            }
        }
        public void buyWithCampaign(Product product, Campaign campaign)
        {
            product.price = (product.price / 100) * campaign.getDiscount();

            if (client.ifReal())
            {
                Console.WriteLine(client.firstName + " buyed " + product.name +
                " for " + product.price.ToString() + "$ with Campaign " + campaign.getName());
            }
            else
            {
                Console.WriteLine("you have to existence to buy something");
            }

        }

    }
}

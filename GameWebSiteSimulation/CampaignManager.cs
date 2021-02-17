using System;
using System.Collections.Generic;
namespace GameWebSiteSimulation
{
    public class CampaignManager:IClientManager
    {
        private List<Campaign> campaigns;
        public CampaignManager()
        {
            campaigns = new List<Campaign>();
        }
        public void Add(object campaign)
        {
            campaigns.Add((Campaign)campaign);
            Console.WriteLine("Campaign added");
        }
        public void Delete(object campaign)
        {
            campaigns.Remove((Campaign)campaign);
            Console.WriteLine("Campaign deleted");
        }
        public void ShowAll()
        {
            foreach (Campaign c in campaigns)
            {
                Console.WriteLine("The great campaign: " + c.getName() +" with discount of " + c.getDiscount().ToString() );
            }
        }
    }
}

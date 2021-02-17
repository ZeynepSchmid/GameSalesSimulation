using System;
namespace GameWebSiteSimulation
{
    public class Campaign
    {
        private string name;
        private double discountPercent;
        public Campaign(string name,double discount) {
            this.name = name;
            this.discountPercent = discount;
        }
        public string getName()
        {
            return this.name;
        }
        public double getDiscount()
        {
            return this.discountPercent;
        }
    }
}

using System;
namespace Loyals
{
    public class LoyaltyCards
    {
        public LoyaltyCards()
        {
            
        }

        public LoyaltyCards(string name, string location, string loyaltyCardURL)
        {
            StoreName = name;
            Location = location;
            LoyaltyCardURL = loyaltyCardURL;
        }

        public string StoreName { get; set; }
        public string Location { get; set; }
        public string LoyaltyCardURL { get; set; }

    }
}
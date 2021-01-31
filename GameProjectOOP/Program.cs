using GameProjectOOP.Abstract;
using GameProjectOOP.Entitiy;
using GameProjectOOP.Managers;
using System;

namespace GameProjectOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            Gamer serkan = new Gamer { Id = 1, FirstName = "SERKAN", birthYear = "1993", IdentityNumber = "1234" };
            gamerManager.Add(serkan);

           
            CampaignManager campaignManager = new CampaignManager();
            Campaign mubarekCuma = new Campaign { Id = 1, Name = "Mubarek Cuma", DiscountRate = 50 };
            campaignManager.Add(mubarekCuma);


            OrderManager orderManager = new OrderManager();
            orderManager.Sell(serkan, mubarekCuma);
           

        }
    }
}

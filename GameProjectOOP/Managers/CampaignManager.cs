using GameProjectOOP.Abstract;
using GameProjectOOP.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOOP
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campagain)
        {
            Console.WriteLine("Kampanya Eklendi : " + campagain.Name);
        }

        public void Delete(Campaign campagain)
        {
            Console.WriteLine("Kampanya Silindi : " + campagain.Name);
        }

        public void Update(Campaign campagain)
        {
            Console.WriteLine("Kampanya Güncellendi "+campagain.Name);
        }
    }
}

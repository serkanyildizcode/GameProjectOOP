using GameProjectOOP.Abstract;
using GameProjectOOP.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOOP.Managers
{
    class OrderManager : IOrderService
    {
        public void Sell(User gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " isimli kullanıcıya " + campaign.Name + " kampanyasından %" + campaign.DiscountRate + " oranında indirim yapıldı.");
        }
    }
}

using GameProjectOOP.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOOP.Abstract
{
    public class GamerManager : IGamerService
    {

        IUserValidationService GamerValidationManager;

        public GamerManager(IUserValidationService gamerValidationManager)
        {
            GamerValidationManager = gamerValidationManager;
        }

        public void Add(Gamer gamer)
        {
            if (GamerValidationManager.Validate(gamer))
            {
                Console.WriteLine("Kullanıcı Eklendi : " +gamer.FirstName);
            } else
            {
                Console.WriteLine("Kullanıcı Doğrulaması Hatası, eklenemedi.");
            }
           
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi: " +gamer.FirstName);
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi : " + gamer.FirstName);

        }
    }
}

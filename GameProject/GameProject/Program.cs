using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                DateOfBirth = new DateTime(1996, 6, 1),
                Name = " Enes ",
                LastName = "  Çetintaş ",
                UserName = " seytan500 ",
                NationalityId = "10161102260"
            };
            Gamer gamer2 = new Gamer
            {
                Id = 2,
                DateOfBirth = new DateTime(1997, 12, 28),
                Name = " Mikail ",
                LastName = "  Çetintaş ",
                UserName = " iscoo97 ",
                NationalityId = "10164101116"
            };
            gamerManager.Add(gamer1);

            Console.WriteLine("----------------------------");

            CampaignManager campaingManager = new CampaignManager();
            Campaign campaign = new Campaign { Id = 1, CampaignName = "  %60 İNDİRİMLİ ", Discount = 0.60M };
            Campaign campaign2 = new Campaign { Id = 2, CampaignName = "  %80 İNDİRİMLİ ", Discount = 0.80M };
            campaingManager.Add(campaign);

            Console.WriteLine("----------------------------");

            GameManager gameManager = new GameManager();
            Game game1 = new Game { Id = 1, GameName = "Counter Strike ", GamePrice = 200 };
            Game game2 = new Game { Id = 2, GameName = "GTA 5  ", GamePrice = 140 };

            gameManager.Add(game2);
            gameManager.Update(game1);

            Console.WriteLine("----------------------------");

            OrderManager orderManager = new OrderManager();

            orderManager.CampaignOrder(game1, gamer1, campaign);
            orderManager.Order(game2, gamer2);

            Console.ReadLine();
        }
    }
}

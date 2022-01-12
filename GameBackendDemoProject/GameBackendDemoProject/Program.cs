using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendDemoProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirsName = "Enes";
            gamer1.LastName = "Çetintaş";
            gamer1.NationalityId = "12345678910";
            gamer1.DateOfBirth =  new System.DateTime(1996, 6, 1);

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignName = "2022 Yılbaşı";
            campaign.CampaignPrice = 40;

            Game game = new Game();
            game.Id = 1;
            game.GameName = "GTA 5";
            game.Fiyat = 120;





            //Real MERNİS
            //MernisService mernisServiceAdapter = new MernisService();
            //GamerManager gamerManager = new GamerManager(mernisServiceAdapter);
            //gamerManager.Add(gamer1);
            //gamerManager.Delete(gamer1);
            //gamerManager.Update(gamer1);


            //Fake MERNİS sürekli true döndürüyorum
            MernisService fakeGamerCheckManager = new MernisService();
            GamerManager gamerManager1 = new GamerManager(fakeGamerCheckManager);
            gamerManager1.Add(gamer1);
            gamerManager1.Add(gamer1);
            //gamerManager1.Delete(gamer1);
            //gamerManager1.Update(gamer1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            //campaignManager.Delete(campaign);
            //campaignManager.Update(campaign);

            GameManager gameManager = new GameManager();
            gameManager.BuyGame(gamer1, game);


            SaleManager saleManager = new SaleManager();
            saleManager.GameSale(game, gamer1, campaign);

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendDemoProject
{
    internal class SaleManager : ISaleService
    {
        public void GameSale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirsName + " adlı oyuncu " + game.GameName + "  oyununu %" + campaign.CampaignPrice + " " + campaign.CampaignName + " indirimiyle satın aldı");
        }
    }
}

using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
        public void CampaignOrder(Game game, Gamer gamer, Campaign campaign)
        {
            decimal indirimOranı = game.GamePrice - (game.GamePrice) * (campaign.Discount);

            Console.WriteLine(" Sayın " + gamer.Name + " " + gamer.LastName + " " + campaign.CampaignName +
                " " + game.GameName + " : Oyununu  " + indirimOranı + " TL' ye Satın Aldınız");
        }

        public void Order(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " " + gamer.LastName + " Satın Aldı : " + game.GameName + "  " + game.GamePrice + " TL ");
        }
    }
}

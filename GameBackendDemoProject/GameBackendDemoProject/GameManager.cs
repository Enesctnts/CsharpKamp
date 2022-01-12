using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendDemoProject
{
    public class GameManager : IGameService
    {
        public void BuyGame(Gamer gamer, Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyunu " + gamer.FirsName + " " + gamer.LastName + " satın aldı.");
        }
    }
}

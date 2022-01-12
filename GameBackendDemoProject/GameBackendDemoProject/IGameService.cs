using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendDemoProject
{
    public interface IGameService
    {
        void BuyGame(Gamer gamer,Game game);
    }
}

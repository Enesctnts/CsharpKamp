using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendDemoProject
{
    public interface ISaleService
    {
        void GameSale(Game game, Gamer gamer, Campaign campaign);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendDemoProject
{
    public class FakeGamerCheckService:IGamerCheckService
    {
        public bool CheckGamer(Gamer gamer)
        {
            return true;
        }
    }
}

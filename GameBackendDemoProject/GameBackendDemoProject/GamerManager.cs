using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendDemoProject
{
    public class GamerManager : IGamerService
    {
         IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
       
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckGamer(gamer))
            {
                Console.WriteLine("Oyuncu eklendi : " + gamer.FirsName);
            }
            else
            {
                Console.WriteLine("Bilgiler gerçek bir oyuncu ile uyuşmuyor");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi : " + gamer.FirsName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi : " + gamer.FirsName);
        }


    }

}

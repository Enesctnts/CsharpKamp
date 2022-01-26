using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckManager;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckManager = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckManager.Check(gamer)==true)
            {
                Console.WriteLine(" Kayıt Başarılı ");
                Console.WriteLine(gamer.Name + "   : Oyuncusu Eklendi. ");
            }
            else
            {
                Console.WriteLine(" Lütfen Kendi Bilgilerinizi Giriniz.");
            }
        
        }

        public void Delete(Gamer gamer)
        {

            Console.WriteLine(gamer.Name + "   : Oyuncusu Silindi. ");

        }

        public void Update(Gamer gamer)
        {
            if (_gamerCheckManager.Check(gamer))
            {
                Console.WriteLine("BAŞARILI");
                Console.WriteLine(gamer.Name + "   : Oyuncusu Güncellendi. ");

            }
            else
            {
                Console.WriteLine(" Güncelleme Başarısız Oldu. Gerçek Bilgilerinizi Giriniz. ");
            }
        }
    }
}

using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " :  Oyunu Eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " :  Oyunu Silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " :  Oyunu Güncellendi.");
        }
    }
}

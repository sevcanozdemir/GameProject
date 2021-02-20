using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    class GameManager : IGameService

    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+"oyunu eklendi" ); 
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "oyunu silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "oyunu güncellendi");
        }
    }
}

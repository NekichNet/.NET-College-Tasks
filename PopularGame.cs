using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public static class PopularGame
    {
        private static double rating = 8.5;
        private static double averagePlayers = 1000;
        private static double maxPlayers = 10000;

        public static bool IsGamePopular(Game game)
        {
            return game.getRating() >= rating && game.getAverage() >= averagePlayers && game.getMax() >= maxPlayers;
        }
    }
}
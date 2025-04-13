using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public class Game
    {
        private string title_;
        private double average_;
        private double max_;
        private double rating_;

        public static Game operator ++(Game game)
        {
            if(game.rating_ < 10)
            {
                game.rating_ += 0.1;
            }
            return game;
        }

        public static Game operator --(Game game)
        {
            if (game.rating_ > 0)
            {
                game.rating_ -= 0.1;
            }
            return game;
        }

        public static bool operator <(Game game1, Game game2)
        {
            return Compare(game1, game2) < 0;
        }

        public static bool operator >(Game game1, Game game2)
        {
            return Compare(game1, game2) > 0;
        }

        public static bool operator ==(Game game1, Game game2)
        {
            return Compare(game1, game2) == 0;
        }

        public static bool operator !=(Game game1, Game game2)
        {
            return !(game1 == game2);
        }

        private static int Compare(Game game1, Game game2)
        {
            int count = 0;
            if (game1.average_ > game2.average_) count++;
            if (game1.max_ > game2.max_) count++;
            if (game1.rating_ > game2.rating_) count++;
            return count;
        }

        public override bool Equals(object obj)
        {
            return (obj is Game otherGame) && (this.title_ == otherGame.title_ &&
            this.average_ == otherGame.average_ && this.max_ == otherGame.max_ &&
            this.rating_ == otherGame.rating_);
        }

        public double getAverage() { return average_; }
        public double getMax() { return max_; }
        public double getRating() { return rating_; }
    }
}
